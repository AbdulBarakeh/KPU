using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CprTBControl
{
    /// <summary>
    /// Interaction logic for ToolboxControl.xaml
    /// </summary>
    [ProvideToolboxControl("KPU Controls", true)]
    public partial class CprControl : UserControl
    {
        private CprError error;

        public CprControl()
        {
            InitializeComponent();
        }

        public bool IsValid
        {
            get
            {
                return CprTest.CheckCPR(tbxCprNo.Text, out error);
            }
        }

        public CprError Error
        {
            get
            {
                CprTest.CheckCPR(tbxCprNo.Text, out error);
                return error;
            }
        }

        public string CprNo
        {
            get { return tbxCprNo.Text; }
            set { tbxCprNo.Text = value; }
        }

        public event EventHandler evCprChanged;

        private void tbxCprNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (evCprChanged != null)
                evCprChanged(this, new EventArgs());
        }
    }
}
