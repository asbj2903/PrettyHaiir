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
					cmd1.Parameters.Add(new SqlParameter("@Customer_Town", customer.Town));
					cmd1.Parameters.Add(new SqlParameter("@Customer_Telephone", customer.PhoneNumber));

					cmd1.ExecuteNonQuery();
				}
				catch (SqlException e)
				{
					Console.WriteLine("OPRET_KUNDE FEJL" +" " + e.Message);
				}
                
			}
		}
	}
}
		

