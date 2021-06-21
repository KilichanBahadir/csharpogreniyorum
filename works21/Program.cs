using System;
using System.Data;
using System.Data.SqlClient;

namespace works21
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
            Console.WriteLine("Güncellemek istediğiniz ID giriniz");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Güncellemek istediğiniz AD giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Güncellemek istediğiniz SOYAD giriniz");
            string soyad = Console.ReadLine();
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

                    //UPDATE table_name  SET column1 = value1, column2 = value2, ...  WHERE condition;
                    String sql = @"Update Ogrenci Set Ad=@Ad, Soyad=@Soyad WHERE ID=@id";

                    using (SqlCommand command = new SqlCommand(sql, connection))

                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);
                        command.ExecuteNonQuery();
                        Console.WriteLine("Kayıt Güncellendi");

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
    

