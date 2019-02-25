using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ApplicationLayer;
using DomainLayer;



namespace GUILayer
{
	
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

        Controller controller = new Controller();
        private void Button_FindCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_OpretKunde_Click(object sender, RoutedEventArgs e)
        {
            CustomerRepository customerRepository = new CustomerRepository();

            string ct_name = Txt_CustomerName.Text;
            string ct_address = Txt_CustomerAddress.Text;
            int ct_zip = Convert.ToInt32(Txt_CustomerZip.Text);
            string ct_Town = Txt_CustomerTown.Text;
            int ct_Telephone = Convert.ToInt32(Txt_CustomerTelefon.Text);

            customerRepository.AddCustomer(ct_name,ct_address,ct_zip,ct_Town,ct_Telephone);

            DatabaseController DBC = new DatabaseController();

            DBC.OPRET_KUNDE(customerRepository.AddCustomer(ct_name, ct_address, ct_zip, ct_Town, ct_Telephone));

            for (int i = 0; i < 100; i++)
            {
                
            }

        }

        private void Txt_CustomerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
            
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Txt_CustomerAddress_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
        }

        private void Txt_CustomerZip_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Txt_CustomerTown_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Txt_CustomerTown.IsEnabled = false;
        }

        private void Txt_CustomerTelefon_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Txt_CustomerTelefon.IsEnabled = false;
        }
    }
}
