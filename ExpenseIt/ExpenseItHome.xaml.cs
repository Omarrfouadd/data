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

namespace ExpenseIt
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Page
    {
        public ExpenseItHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var SelectedEmp = EmpNames.SelectedItem as ListBoxItem;
            ExpenseReportPage expenseReportPage = new ExpenseReportPage(SelectedEmp.Content.ToString());
            this.NavigationService.Navigate(expenseReportPage);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            modify modify  = new modify();
            this.NavigationService.Navigate(modify);
        }
    }
}
