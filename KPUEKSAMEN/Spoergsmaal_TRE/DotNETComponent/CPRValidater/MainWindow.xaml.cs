using CprDLLShared;
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

namespace CPRValidater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    //For Test Purposes use: 0609240121
    public partial class MainWindow : Window
    {
        CprCheck cprDLL = new CprCheck();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Validate(object sender, RoutedEventArgs e)
        {
            CprCheck.CprError err;
            string cprString = cprNumber.Text;
            cprDLL.Check(cprString, out err);
            if (err != CprCheck.CprError.NoError)
            {
                switch (err)
                {
                    case CprCheck.CprError.FormatError:
                        cprNumber.BorderBrush = Brushes.Red;
                        errMsg.Text = "Format is wrong!";
                        break;
                    case CprCheck.CprError.DateError:
                        cprNumber.BorderBrush = Brushes.Red;
                        errMsg.Text = "Date is wrong!";
                        break;
                    case CprCheck.CprError.Check11Error:
                        cprNumber.BorderBrush = Brushes.Red;
                        errMsg.Text = "Cpr 11-check is wrong!";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                cprNumber.BorderBrush = Brushes.Green;
                errMsg.Text = "Cpr is valid!";
            }
        }
    }
}
