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
using CprDLL;

namespace ValidateCpr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            CprTest.CprError cprErr;
            CprTest cprTest = new CprTest();

            cprTest.CheckCPR(tbxCprNo.Text, out cprErr);
            switch (cprErr)
            {
                case CprTest.CprError.NoError:
                    tblErrMessage.Text = "Gyldigt";
                    break;
                case CprTest.CprError.FormatError:
                    tblErrMessage.Text = "Forkert format";
                    break;
                case CprTest.CprError.DateError:
                    tblErrMessage.Text = "Dato ugyldig";
                    break;
                case CprTest.CprError.Check11Error:
                    tblErrMessage.Text = "Ugyldigt";
                    break;
                default:
                    tblErrMessage.Text = "Ukendt fejl";
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbxCprNo.Focus();
        }

        private void tbxCprNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblErrMessage.Text = " ";
        }
    }
}
