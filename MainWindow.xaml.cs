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

namespace ENCHANTCMDGENERATE_WPFAPP
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static string cmd = "/give @p ";
        public static string enchlist = "[";

        private void button_Click(object sender, RoutedEventArgs e)
        {
            enchlist = enchlist + "{id:";
            enchlist = enchlist + Convert.ToString(ENCHID.Text);
            enchlist = enchlist + ",lvl:";
            enchlist = enchlist + Convert.ToString(LEVEL.Text);
            enchlist = enchlist + "}";
            ENCHID.Text = "";
            LEVEL.Text = "";

        }
        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            cmd = cmd + Convert.ToString(ITEMID.Text);
            //enchlist = enchlist + "]";
            cmd = cmd + "{Enchantments:";
            cmd = cmd + enchlist;
            cmd = cmd + "]}";
            cmd = cmd + " ";
            cmd = cmd + Convert.ToString(NUM.Text);
            MessageBox.Show(cmd);
        }
    }
}
