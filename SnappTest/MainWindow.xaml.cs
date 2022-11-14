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

namespace SnappTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void txtResults_TextChanged(object sender, TextChangedEventArgs e)
        {
            MainWindowViewModel myVM = (MainWindowViewModel)DataContext;
            TextBox txtSender = (TextBox)sender;
            int intResult;
            if(int.TryParse(myVM.ResultString, out intResult)) 
            {
                if (intResult > -1)
                { txtResults.Style = (Style)this.Resources["GreenText"]; }

                else 
                { txtResults.Style = (Style)this.Resources["DefaultColor"]; }

            }

            else
            { txtResults.Style = (Style)this.Resources["DefaultColor"]; }

        }
    }
}
