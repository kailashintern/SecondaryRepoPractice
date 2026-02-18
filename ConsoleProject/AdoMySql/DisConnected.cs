/*using System;
using System.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;


namespace ConsoleProject.AdoMySql
{
    public class DisConnected
    {

        static string connectionstring = "server=localhost;database=employee;user=appuser;password=App@123";
        public static void Practice1()
        {
            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {



                string query = "SELECT * from students";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adapter);

                DataTable table = new DataTable();

                adapter.Fill(table);


                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine($"{row["name"]}  {row["rollno"]} ");
                }


            }



        }

        public static void practiceTwo()
        {


            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {


                string query = "select * from students";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);


                DataTable d = new DataTable();
                adapter.Fill(d);


                foreach (DataRow row in d.Rows)
                {
                    Console.WriteLine($"{row["name"]}  {row["rollno"]} ");
                }


            }
        }


        public static void InsertMethod()
        {



            using (MySqlConnection con = new MySqlConnection(connectionstring))
            {


                string query = "select * from students";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                MySqlCommandBuilder cmd = new MySqlCommandBuilder(adapter);
                DataTable table = new DataTable();
                adapter.Fill(table);

                //insert
                DataRow row = table.NewRow();
                row["name"] = "ajith";
                row["rollno"] = 456;
                table.Rows.Add(row);

               // adapter.Update(table);

                Console.WriteLine("updated table");

                table.Rows[1].Delete();
                

                adapter.Update(table);




            }
        }





            static void Main(string[]args)
            {

                // Practice1();
                // practiceTwo();
                InsertMethod();
            }
        }
    }

*/