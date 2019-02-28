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
using System.Windows.Shapes;
using ApplicationLayer;

namespace GUILayer
{
	/// <summary>
	/// Interaction logic for OpretOrdre.xaml
	/// </summary>
	public partial class OpretOrdre : Window
	{
		public OpretOrdre()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Controller controller = new Controller();

			controller.CreateOrder(Convert.ToDateTime(txt_OrderDate.Text), Convert.ToDateTime(txt_DeliveryDate.Text), Convert.ToInt32(txt_OrderPicked.Text), Convert.ToInt32(txt_CustomerID.Text));

			txt_OrderDate.Text = null;
			txt_DeliveryDate.Text = null;
			txt_OrderPicked.Text = null;
			txt_CustomerID.Text = null;

			this.Close();
		}
	}
}
