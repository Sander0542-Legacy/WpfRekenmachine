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

namespace WpfRekenmachine
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

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button) sender;
            tbResult.Text += b.Content.ToString();
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Calculate();
            }
            catch (Exception)
            {
                tbResult.Text = "Syntacs Error";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbResult.Text = "";
        }

        public void Calculate()
        {
            int iOp = 0;
            if (tbResult.Text.Contains("+"))
            {
                iOp = tbResult.Text.IndexOf("+");
            }
            else if (tbResult.Text.Contains("-"))
            {
                iOp = tbResult.Text.IndexOf("-");
            }
            else if (tbResult.Text.Contains("x"))
            {
                iOp = tbResult.Text.IndexOf("x");
            }
            else if (tbResult.Text.Contains("/"))
            {
                iOp = tbResult.Text.IndexOf("/");
            }
            else
            {
                //Error
            }

            string sOp = tbResult.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(tbResult.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(tbResult.Text.Substring(iOp + 1, tbResult.Text.Length - iOp - 1));

            if (sOp == "+")
            {
                tbResult.Text += "=" + (op1 + op2);
            }
            else if (sOp == "-")
            {
                tbResult.Text += "=" + (op1 - op2);
            }
            else if (sOp == "x")
            {
                tbResult.Text += "=" + (op1 * op2);
            }
            else
            {
                tbResult.Text += "=" + (op1 / op2);
            }
        }
    }
}
