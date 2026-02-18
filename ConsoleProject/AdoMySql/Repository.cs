/*using System;

using MySql.Data.MySqlClient;

namespace ConsoleProject.AdoMySql
{
    public class Repository
    {


       static string ConnectionString = "server=localhost;database=employee;user=appuser;password=App@123";

        public static void GetAll()
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                string query = "Select * from dummy";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    int id = Convert.ToInt32(reader["id"]);
                    string? name = reader["name"].ToString();
                    string? address = reader["address"].ToString();
                    Console.WriteLine($"{id} , {name} {address}");
                }
            }
        }

        public static void ParaMethod()
        {
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                string query = "select *from dummy where id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id",1);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idd = Convert.ToInt32(reader["id"]);
                    Console.WriteLine(idd);

                }
            }



        }



        public static void Insertdata()
        {


            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                string query = "Insert into dummy (name,address) values(@NAME, @ADDRESS)";
                MySqlCommand cmd = new MySqlCommand(query,con);
                cmd.Parameters.AddWithValue("@NAME","dhanush");
                cmd.Parameters.AddWithValue("@ADDRESS","kochi");
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine(result);
            }


        }

        public static void ScalarMethod()
        {
            using(MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                string query = "select count(*) from dummy";
                MySqlCommand cmd = new MySqlCommand(query,con);
                var result =cmd.ExecuteScalar();
                Console.WriteLine(result);



            }
        }
      public  static void Main()
        {
            //GetAll();
            //  ParaMethod();
            // Insertdata();
           // ScalarMethod();

        }

        


    }
}
*/