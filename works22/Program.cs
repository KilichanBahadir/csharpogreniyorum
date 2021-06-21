using System;
using System.Data;
using System.Data.SqlClient;

namespace works22
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"TRIPLE-PC\SQLEXPRESS";
                builder.UserID = "sa";
                builder.Password = "Provera@2016";
                builder.InitialCatalog = "studentdb";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();

                    String sql = "SELECT ID,Ad,Soyad  FROM Ogrenci";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0}-{1} {2}", reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2));
                            }
                        }
                    }
                }

            }

            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("Silmek istediğiniz ID giriniz");
            int id = int.Parse(Console.ReadLine());
            
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"TRIPLE-PC\SQLEXPRESS";
                builder.UserID = "sa";
                builder.Password = "Provera@2016";
                builder.InitialCatalog = "studentdb";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();

                    //DELETE FROM table_name WHERE condition;
                    String sql = @"Delete From Ogrenci WHERE ID=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection))

                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id", id);
                        
                        command.ExecuteNonQuery();
                        Console.WriteLine("Kayıt Silindi");

                    }
                }

            }

            catch (SqlException e)
            {

                Console.WriteLine(e.ToString());
            }


            Console.ReadLine();
        }
    }
}
    

