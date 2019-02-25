using DomainLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;

namespace ApplicationLayer
{
	public class DatabaseController
	{
		private static readonly string conntectionString =
		  "Server = ealSQL1.eal.local; Database = A_DB06_2018; User Id = A_STUDENT06; Password = A_OPENDB06;";
        
		public void OPRET_KUNDE(Customer customer)
		{
			using (System.Data.SqlClient.SqlConnection con = new SqlConnection(conntectionString))
			{
				try
				{
					con.Open();

					SqlCommand cmd1 = new SqlCommand("OPRET_KUNDE", con);
					cmd1.CommandType = CommandType.StoredProcedure;

					cmd1.Parameters.Add(new SqlParameter("@CustomerID", customer.CustomerID));
					cmd1.Parameters.Add(new SqlParameter("Customer_Name", customer.Customer_Name));
					cmd1.Parameters.Add(new SqlParameter("@Customer_Address", customer.Address));
					cmd1.Parameters.Add(new SqlParameter("@Customer_Zip", customer.Zip));
					cmd1.Parameters.Add(new SqlParameter("@CustomerTown", customer.Town));
					cmd1.Parameters.Add(new SqlParameter("@CustomerTelephone", customer.PhoneNumber));

					cmd1.ExecuteNonQuery();
				}
				catch (SqlException e)
				{
					Console.WriteLine("OPRET_KUNDE FEJL" +" " + e.Message);
				}
                
			}
		}

         public void FineCustomerByCustomerID()
        {
            using (SqlConnection con = new SqlConnection(conntectionString))
            {
                try
                {
                    Console.WriteLine("Indtast CustomerID: ");
                    string CustomerIDString = Console.ReadLine();
                    int CustomerID = Convert.ToInt32(CustomerIDString);


                    con.Open();

                    SqlCommand cmd2 = new SqlCommand("GetCustomerByCustomerID", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add(new SqlParameter("@CustomerID", CustomerID));


                    SqlDataReader reader = cmd2.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string Customer_ID = reader["CustomerID"].ToString();
                            string Customer_Name = reader["Customer_Name"].ToString();
                            string Customer_Adress = reader["Customer_Address"].ToString();
                            string customer_Zip = reader["Customer_Zip"].ToString();
                            string Customer_Town = reader["Customer_Town"].ToString();
                            string Customer_Telephone = reader["Customer_Telephone"].ToString();

                            Console.WriteLine(Customer_ID + " " + Customer_Name + " " + Customer_Adress + " " + customer_Zip + " "+ Customer_Town + " " + Customer_Telephone);
                            Console.ReadLine();
                        }
                    }
                }
                catch (SqlException e)
                
                {
                    Console.WriteLine("Error: " + e.Message);
                    Console.ReadLine();
                }

            
            }

        }

	}
}
		

