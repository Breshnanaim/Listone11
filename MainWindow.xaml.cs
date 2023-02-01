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

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> items = new List<string>();
        List<string> nameslist = new List<string>()
         {
                "green",
                "pink",
                "red",
                "apple",
                "orange",

            };
        public MainWindow()
        {
            InitializeComponent();

            mademethod();
        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {

            string addtex = txtAddItem.Text;

            nameslist.Add(addtex);
            textbox.Text += nameslist.Count()-1 + " " + nameslist.Last() + "\n";
            // mademethod();





        }
        public void mademethod()
        {
            for (int i = 0; i < nameslist.Count; i++)
            {
                textbox.Text += i + " " + nameslist[i] + "\n";
            }
            nameslist.Add("orange");
            nameslist.RemoveAt(2);

        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            string showindex = testdisplay.Text;
            MessageBox.Show(showindex);
        }

        private void btnRemoveIndex_Click(object sender, RoutedEventArgs e)
        {
            int numclean = int.Parse (textremovebyindex.Text);
            nameslist.RemoveAt(numclean);
            textbox.Text = "";
            // textbox.Text += nameslist.Count() - 1 + " " + nameslist.Last() + "\n";
            mademethod();
        }

        private void btnRemoveItem_Click(object sender, RoutedEventArgs e)
        {
            string itemsremove = textremovebyitem.Text;

            nameslist.Remove(itemsremove);
            textbox.Text = "";
            mademethod();
        }

        private void btnRemoveRange_Click(object sender, RoutedEventArgs e)
        {
            int firstnum =int.Parse( textrangefirst.Text);
            int secondnum =int.Parse( textrangesecond.Text);
            
            nameslist.RemoveRange(firstnum, secondnum);
            // firstnum = 0;
            // secondnum = 0;
            textbox.Text = "";
            mademethod();
            
            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = "";
        }
    }
}