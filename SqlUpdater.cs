using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;


namespace C969_Software_2
{
    class SqlUpdater
    {
        private static Dictionary<int, Hashtable> _appointments = new Dictionary<int, Hashtable>();
        private static int _currentUserID;
        private static string _currentUserName;
        public static string conString = "server=3.227.166.251 ;database=U04yKm ;uid=U04yKm ;password=53688383395; convert zero datetime = True; ";


        public static string GetconString()

        {
            return conString;
        }

        public static int GetCurrentUserID()
        {
            return _currentUserID;
        }

        public static void SetCurrentUserID(int currentUserID)
        {
            _currentUserID = currentUserID;
        }

        public static string GetCurrentUserName()
        {
            return _currentUserName;
        }

        public static void SetCurrentUserName(string currentUserName)
        {
            _currentUserName = currentUserName;
        }

        public static string CreateTimestamp()
        {
            return DateTime.Now.ToString("u");
        }

        public static Dictionary<int, Hashtable> GetAppointments()
        {
            return _appointments;
        }

        public static void SetAppointments(Dictionary<int, Hashtable> appointments)
        {
            _appointments = appointments;
        }

        public static string ConvertToTimezone(string dateTime)
        {
            if (string.IsNullOrEmpty(dateTime))
            {
                throw new ArgumentException("message", nameof(dateTime));
            }

            DateTime utcDateTime = DateTime.Parse(dateTime.ToString());
            DateTime localDateTime = utcDateTime.ToLocalTime();

            return localDateTime.ToString("yyyy-MM-dd hh:mm:ss");
        }

        public static int NewID(List<int> idlist)
        {
            int highestID = 0;
            foreach (int id in idlist)
            {
                if (id > highestID)
                    highestID = id;
            }
            return highestID + 1;
        }

        public static int CreateID(string table)
        {
            MySqlConnection c = new MySqlConnection(conString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT {table + "Id"} FROM {table}", c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<int> idlist = new List<int>();
            while (rdr.Read())
            {
                idlist.Add(Convert.ToInt32(rdr[0]));
            }
            rdr.Close();
            c.Close();
            return NewID(idlist);
        }
        public static DataTable FirstCal(string filter, bool week)
        {

            MySqlConnection conn = new MySqlConnection(conString);
            conn.Open();
            string query = week ? $"SELECT (select customerName from customer where customerId = appointment.customerId) as 'Customer',  customerId as 'Customer Id', title as 'Title', type as 'Type', start as 'Start Time', end as 'End Time', location as 'Location' FROM appointment where start < '{filter}' and end < '{filter}'  and end > now() order by start;"
                : $"SELECT  (select customerName from customer where customerId = appointment.customerId) as 'Customer', customerId as 'Customer Id', title as 'Title', type as 'Type', start as 'Start Time', end as 'End Time', location as 'Location' FROM appointment where start < '{filter}' and end < '{filter}' and end > now() order by start;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                DateTime utcStart = Convert.ToDateTime(row["Start Time"]);
                DateTime utcEnd = Convert.ToDateTime(row["End Time"]);
                row["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                row["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
            }

            conn.Close();
            return dt;

        }

        public static string DateSQLFormat(DateTime dateValue)
        {
            string formatForMySql = dateValue.ToString("yyyy-MM-dd HH:mm");

            return formatForMySql;
        }

        public static DataTable Schedule(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("message", nameof(id));
            }

            MySqlConnection conn = new MySqlConnection(conString);
            conn.Open();
            string query = $"SELECT (select customerName from customer where customerId = appointment.customerId) as 'Customer',  type as 'Type', start as 'Start Time', end as 'End Time', createdBy as 'Created By', location as 'Location', title as 'Title' FROM appointment order by start;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                DateTime utcStart = Convert.ToDateTime(row["Start Time"]);
                DateTime utcEnd = Convert.ToDateTime(row["End Time"]);
                row["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                row["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
            }

            conn.Close();
            return dt;
        }

        public static int CreateRecord(string timestamp, string userName, string table, string partOfQuery, int userId = 0)
        {
            int recId = CreateID(table);
            string recInsert;
            if (userId == 0)
            {
                recInsert = $"INSERT INTO {table}" +
                $" VALUES ('{recId}', {partOfQuery}, '{timestamp}', '{userName}', '{timestamp}', '{userName}')";
            }
            else
            {
                recInsert = $"INSERT INTO {table} (appointmentId, customerId, start, end, type, userId, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                $" VALUES ('{recId}', {partOfQuery}, '{userId}', '{timestamp}', '{userName}', '{timestamp}', '{userName}')";
            }

            MySqlConnection c = new MySqlConnection(conString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(recInsert, c);
            cmd.ExecuteNonQuery();

            return recId;

        }

        public static int UpdateAppt(int customerId, int userId, string st, string et, string type, string timestamp, string username, int appointmentId)
        {
            int uId = 0;
            string Update;
            if (userId == 0)
            {

                Update = $"UPDATE appointment SET customerId = '{customerId}', userId = '{userId}', start = '{st}', end = {et}', type = '{type}', createDate = '{timestamp}', createdBy = '{username}', lastUpdate = '{timestamp}', lastUpdateBy = '{username}' WHERE appointmentId = '{appointmentId}'";
            }
            else
            {

                Update = $"UPDATE appointment SET customerId = '{customerId}', userId = '{userId}', start = '{st}', end = '{et}', type = '{type}', createDate = '{timestamp}', createdBy = '{username}', lastUpdate = '{timestamp}', lastUpdateBy = '{username}' WHERE appointmentId = '{appointmentId}'";
            }

            MySqlConnection c = new MySqlConnection(conString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(Update, c);
            cmd.ExecuteNonQuery();

            return uId;

        }

        public static Dictionary<string, object> ReportAppoint(string item)
        {
            Dictionary<string, object> reportINFO = new Dictionary<string, object>();

            MySqlConnection conn = new MySqlConnection(conString);
            conn.Open();
            var query = $"select distinct" +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 1) as 'Jan'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 2) as 'Feb'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 3) as 'Mar'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 4) as 'Apr'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 5) as 'May'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 6) as 'Jun'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 7) as 'Jul'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 8) as 'Aug'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 9) as 'Sep'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 10) as 'Oct'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 11) as 'Nov'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 12) as 'Dec'" +
                $"            from appointment;";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                reportINFO.Add("Jan", rdr[0]);
                reportINFO.Add("Feb", rdr[1]);
                reportINFO.Add("Mar", rdr[2]);
                reportINFO.Add("Apr", rdr[3]);
                reportINFO.Add("May", rdr[4]);
                reportINFO.Add("Jun", rdr[5]);
                reportINFO.Add("Jul", rdr[6]);
                reportINFO.Add("Aug", rdr[7]);
                reportINFO.Add("Sep", rdr[8]);
                reportINFO.Add("Oct", rdr[9]);
                reportINFO.Add("Nov", rdr[10]);
                reportINFO.Add("Dec", rdr[11]);
            }

            return reportINFO;
        }

        public static Dictionary<string, object> ReportAll()
        {
            Dictionary<string, object> reportINFO = new Dictionary<string, object>();

            MySqlConnection conn = new MySqlConnection(conString);
            conn.Open();
            var query = $"select distinct" +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 1) as 'Jan'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 2) as 'Feb'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 3) as 'Mar'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 4) as 'Apr'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 5) as 'May'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 6) as 'Jun'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 7) as 'Jul'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 8) as 'Aug'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 9) as 'Sep'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 10) as 'Oct'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 11) as 'Nov'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 12) as 'Dec'" +
                $"            from appointment;";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                reportINFO.Add("Jan", rdr[0]);
                reportINFO.Add("Feb", rdr[1]);
                reportINFO.Add("Mar", rdr[2]);
                reportINFO.Add("Apr", rdr[3]);
                reportINFO.Add("May", rdr[4]);
                reportINFO.Add("Jun", rdr[5]);
                reportINFO.Add("Jul", rdr[6]);
                reportINFO.Add("Aug", rdr[7]);
                reportINFO.Add("Sep", rdr[8]);
                reportINFO.Add("Oct", rdr[9]);
                reportINFO.Add("Nov", rdr[10]);
                reportINFO.Add("Dec", rdr[11]);
            }

            return reportINFO;
        }

        public static int FindCustomer(string search)
        {
            string query;
            if (int.TryParse(search, out int customerId))
            {
                query = $"SELECT customerId FROM customer WHERE customerid = '{search}'";
            }
            else
            {
                query = $"SELECT customerId FROM customer WHERE customerName LIKE '{search}'";
            }

            MySqlConnection c = new MySqlConnection(SqlUpdater.conString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                customerId = Convert.ToInt32(rdr[0]);
                rdr.Close();
                c.Close();
                return customerId;
            }
            return 0;

        }

        public static Dictionary<string, string> GetCustomerDetails(int customerId)
        {
            string query = $"SELECT * FROM customer WHERE customerId = '{customerId}'";
            MySqlConnection c = new MySqlConnection(SqlUpdater.conString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            Dictionary<string, string> customerDict = new Dictionary<string, string>
            {
                { "customerName", rdr[1].ToString() },
                { "addressId", rdr[2].ToString() }
            };
            rdr.Close();

            query = $"SELECT * FROM address WHERE addressId = '{customerDict["addressId"]}'";
            cmd = new MySqlCommand(query, c);
            rdr = cmd.ExecuteReader();
            rdr.Read();

            customerDict.Add("address", rdr[1].ToString());
            customerDict.Add("cityId", rdr[3].ToString());
            customerDict.Add("zip", rdr[4].ToString());
            customerDict.Add("phone", rdr[5].ToString());
            rdr.Close();

            query = $"SELECT * FROM city WHERE cityId = '{customerDict["cityId"]}'";
            cmd = new MySqlCommand(query, c);
            rdr = cmd.ExecuteReader();
            rdr.Read();

            customerDict.Add("city", rdr[1].ToString());
            customerDict.Add("countryId", rdr[2].ToString());
            rdr.Close();

            query = $"SELECT * FROM country WHERE countryId = '{customerDict["countryId"]}'";
            cmd = new MySqlCommand(query, c);
            rdr = cmd.ExecuteReader();
            rdr.Read();

            customerDict.Add("country", rdr[1].ToString());
            rdr.Close();
            c.Close();

            return customerDict;
        }

        public static Dictionary<string, string> GetAppointmentDetails(string appointmentId)
        {
            string query = $"SELECT * FROM appointment WHERE appointmentId = '{appointmentId}'";
            MySqlConnection c = new MySqlConnection(conString);
            c.Open();
            MySqlCommand cmd = new MySqlCommand(query, c);
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();

            Dictionary<string, string> appointmentDict = new Dictionary<string, string>
            {
                { "appointmentId", appointmentId },
                { "customerId", read[1].ToString() },
                { "type", read[7].ToString() },
                { "start", read[9].ToString() },
                { "end", read[10].ToString() }
            };

            read.Close();

            return appointmentDict;

        }
    }

}

