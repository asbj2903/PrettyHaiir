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



namespace GUILayer
{
	
	public partial class MainWindow : Window
	{
        Controller controller = new Controller();
        public MainWindow()
		{
			InitializeComponent();
		}

        
        private void Button_FindCustomer_Click(object sender, RoutedEventArgs e)
        {
            ViewCustomerBox.Text = controller.GetCustomer(int.Parse(Txt_FindCustomer.Text));

        }

        private void Button_OpretKunde_Click(object sender, RoutedEventArgs e)
        {
            //CustomerRepository customerRepository = new CustomerRepository();

            //int ct_id = Convert.ToInt32(Txt_CustomerID.Text);
            //string ct_name = Txt_CustomerName.Text;
            //string ct_address = Txt_CustomerAddress.Text;
            //int ct_zip = Convert.ToInt32(Txt_CustomerZip.Text);
            //string ct_Town = Txt_CustomerTown.Text;
            //int ct_Telephone = Convert.ToInt32(Txt_CustomerTelefon.Text);

            //customerRepository.AddCustomer(ct_id,ct_name,ct_address,ct_zip,ct_Town,ct_Telephone);

            controller.CreateCustomer(Txt_CustomerName.Text, Txt_CustomerAddress.Text, Convert.ToInt32(Txt_CustomerZip.Text), Txt_CustomerTown.Text, Convert.ToInt32(Txt_CustomerTelefon.Text));

            Txt_CustomerName.Text = null;
            Txt_CustomerAddress.Text = null;
            Txt_CustomerZip.Text = null;
            Txt_CustomerTown.Text = null;
            Txt_CustomerTelefon.Text = null;

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

        private void Txt_CustomerID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
