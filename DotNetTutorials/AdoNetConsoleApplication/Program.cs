using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication {
    public class Program {
        static void Main(string[] agrs) {
            new Program().CreateTable();
            Console.ReadKey();
        }
        public void CreateTable() {
            SqlConnection con = null;
            try {
                // Creating Connection
                con = new SqlConnection("data source = '(localdb)\\mssqllocaldb';database=student; integrated security=SSPI");
                // writing sql query
                SqlCommand cm = new SqlCommand("create table student(id int not null, name varchar(100), email varchar(50), join_date date)", con);
                // Opening Connection
                con.Open();
                // Executing the SQL query 
                cm.ExecuteNonQuery(); 
                // Displaying a message 
                Console.WriteLine("Table created Successfully");
            } catch (Exception e) {
                Console.WriteLine("OOPS,sonething went wrong." + e);
            } finally {
                con.Close();
            }
        }
    }
}