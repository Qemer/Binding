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

namespace WpfApp14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Student> list;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<Student>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list.Add(new Student
            {
                Name = "Aleksandr",
                Surname = "Molomed",
                Company = new Company("comp")

            });
            Grid1.DataContext = list;
        }
    }
}
