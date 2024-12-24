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
using NewEventLogDLL;
using DataValidationDLL;
using WorkTaskStatsDLL;
using ProductivityDataEntryDLL;
using DateSearchDLL;
using EmployeeDateEntryDLL;
using ProjectMatrixDLL;
using NewEmployeeDLL;
using ProjectsDLL;
using WorkTaskDLL;

namespace TechKioskEntry
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

        private void expClose_Expanded(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
