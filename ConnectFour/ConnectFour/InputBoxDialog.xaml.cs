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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for InputBoxDialog.xaml
    /// </summary>
    public partial class InputBoxDialog : Window
    {
        String name1;
        String name2;
        public InputBoxDialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            name1 = playerName1.Text;
            name2 = playerName1.Text;
            this.Close();
        }

        public String Name1 { get { return this.name1; }  }
        public String Name2 { get { return this.name2; } }


    }
}
