using DomainLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
	public class DatabaseController
	{
        private string customerString;
        private static readonly string connectionString =
		  "Server = ealSQL1.eal.local; Database = A_DB06_2018; User Id = A_STUDENT06; Password = A_OPENDB06;";
        
		public void OPRET_KUNDE(Customer customer)
		{
			using (System.Data.SqlClient.SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();

					SqlCommand cmd1 = new SqlCommand("OPRET_KUNDE", con);
					cmd1.CommandType = CommandType.StoredProcedure;

					
					cmd1.Parameters.Add(new SqlParameter("Customer_Name", customer.Customer_Name));
					cmd1.Parameters.Add(new SqlParameter("@Customer_Address", customer.Customer_Address));
					cmd1.Parameters.Add(new SqlParameter("@Customer_Zip", customer.Customer_Zip));
					cmd1.Parameters.Add(new SqlParameter("@Customer_Town", customer.Customer_Town));
					cmd1.Parameters.Add(new SqlParameter("@Customer_Telephone", customer.Customer_PhoneNumber));

					cmd1.ExecuteNonQuery();
				}
				catch (SqlException e)
				{
					Console.WriteLine("OPRET_KUNDE FEJL" +" " + e.Message);
				}
                
			}
		}

         public string FindCustomerByCustomerID(int customerID)
         {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    //Console.WriteLine("Indtast CustomerID: ");
                    //string CustomerIDString = Console.ReadLine();
                    //int CustomerID = Convert.ToInt32(CustomerIDString);


                    con.Open();

                    SqlCommand cmd2 = new SqlCommand("GetCustomerByCustomerID", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add(new SqlParameter("@CustomerID", customerID));


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

                            customerString = (Customer_ID + " " + Customer_Name + " " + Customer_Adress + " " + customer_Zip + " "+ Customer_Town + " " + Customer_Telephone);
                           
                        }
                        
                    }
                }
                    
                catch (SqlException e)
                
                {
                    Console.WriteLine("Error: " + e.Message);
                    
                }

            
            }
            return customerString;

        }

	}
}


