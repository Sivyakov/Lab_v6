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

namespace Lab_v6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Firm firm = new Firm();
            
            firm.Name = BoxName.Text;
            firm.Age = Convert.ToInt32(BoxAge.Text);
            firm.Salary= Convert.ToInt32(BoxSallary.Text);
            firm.Rating = Convert.ToInt32(BoxRating.Text);
            firm.Insurance = BoxInsurance.Text;
            firm.Index2 = firm.Index;
            boxResult.Text = ($"Фирма {firm.GetStatus}");
        }
    }
}
