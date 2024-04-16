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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> ComboBoxItems { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            ComboBoxItems = new List<string> { "1", "2" };
            dataGrid.ItemsSource = new List<DataGridItem>
            {
                new DataGridItem { Field1 = "Sample1"},
                new DataGridItem { Field1 = "Sample2"}
            };
            this.DataContext = this;
        }

        
    }
    public class DataGridItem
    {
        public string Field1 { get; set; }
    }

}
