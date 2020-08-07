using CprDLLShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CPRValidaterShared
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Assembly myDll = Assembly.Load("CprDLLShared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=be353884b567f8b6");
        //Assembly myDll = Assembly.LoadFile("C:\\Windows\\Microsoft.NET\\assembly\\GAC_MSIL\\CprDLLShared\\v4.0_1.0.0.0__be353884b567f8b6\\CPRDLLSHARED.dll");
        Type assType;
        CprCheck cprDLL;
        public MainWindow()
        {
            InitializeComponent();
            assType = myDll.GetType("CprDLLShared.CprCheck");
            cprDLL = new CprCheck();
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
        private void Button_Click_GetInfo(object sender, RoutedEventArgs e)
        {

            name.Text = assType.Assembly.FullName;
            AssemblyName assName = assType.Assembly.GetName();
            version.Text = assName.Version.ToString();
            Location.Text = assType.Assembly.Location;
            LoadFromGAC.Text = assType.Assembly.GlobalAssemblyCache.ToString();//Get's loaded from the GAC but still says false

        }
    }
}
