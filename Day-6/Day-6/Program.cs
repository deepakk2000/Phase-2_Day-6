using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Day_6
{
    internal class Program
    {
        public static void Select()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CTG4A6O;Initial Catalog=ProductInventoryDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Product", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4] + "\t" + dr[5]);

            }
            con.Close();
        }
        public static void Insert()
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-CTG4A6O;Initial Catalog=ProductInventoryDB;Integrated Security=True");
            string sql = "insert into Product values(2,'Toy2',3000,5,'2023-02-20','2023-03-23')";
            SqlCommand cmd1 = new SqlCommand(sql, con1);
            try
            {
                con1.Open();
                cmd1.ExecuteNonQuery();

                Console.WriteLine("Data inserted Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error when inserting Products" + ex.Message);
            }
            finally
            {
                con1.Close();
                Console.ReadKey();
            }
            
        }
        public static void Update()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-CTG4A6O;Initial Catalog=ProductInventoryDB;Integrated Security=True");
            string sql2 = "update Product Set Quantity=10 where ProductName='Toy2'";
            SqlCommand cmd2 = new SqlCommand(sql2, con2);
            try
            {
                con2.Open();
                cmd2.ExecuteNonQuery();

                Console.WriteLine("Data Updated Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error when inserting Products" + ex.Message);
            }
            finally
            {
                con2.Close();
                Console.ReadKey();
            }
          
        }
        public static void Delete()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-CTG4A6O;Initial Catalog=ProductInventoryDB;Integrated Security=True");
            string sql2 = "delete from Product where ProductId=1";
            SqlCommand cmd2 = new SqlCommand(sql2, con2);
            try
            {
                con2.Open();
                cmd2.ExecuteNonQuery();

                Console.WriteLine("Data Deleted Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error when Deleteing Products" + ex.Message);
            }
            finally
            {
                con2.Close();
                Console.ReadKey();
            }
        }
            static void Main(string[] args)
        {
            Select();
            Insert();
            Update();
            Delete();



           
         
        }
    }
}
