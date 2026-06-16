using System;
using System.Data;
using System.Data.SqlClient;

namespace Module3.Exercise30
{
    class Program
    {
        static string ConnString => "Server=localhost;Database=TestDb;Trusted_Connection=True;"; // update as needed

        static void Main()
        {
            using(var conn = new SqlConnection(ConnString))
            {
                conn.Open();
                // Insert
                using(var cmd = new SqlCommand("INSERT INTO Employees(Name) VALUES('John')", conn)) cmd.ExecuteNonQuery();
                // Read
                using(var cmd = new SqlCommand("SELECT TOP 10 * FROM Employees", conn)) using(var r = cmd.ExecuteReader()) { while(r.Read()) Console.WriteLine(r["Name"]); }
                // Update
                using(var cmd = new SqlCommand("UPDATE Employees SET Name='John Updated' WHERE Name='John'", conn)) cmd.ExecuteNonQuery();
                // Delete
                using(var cmd = new SqlCommand("DELETE FROM Employees WHERE Name='John Updated'", conn)) cmd.ExecuteNonQuery();
            }
        }
    }
}
