using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for ExpenseReportPage.xaml
    /// </summary>
    public partial class ExpenseReportPage : Page
    {
        public ExpenseReportPage(string name)
        {
            InitializeComponent();
            NameData.Content = name.ToString();// NmaeData = 
            showEntiteses(name);
          //  ShowTheReport(name);
        }
      //  public void ShowTheReport(string name)
       // {
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RE9P1QC;Initial Catalog=ExpenseIt;Integrated Security=True;");
            //SqlCommand cmd = new SqlCommand
            //{
            //    Connection = conn,
            //    CommandText = "Select * From Expense Where Names = @empName"
            //};
            //cmd.Parameters.AddWithValue("@empName" , name);
            //conn.Open();

            //var records = cmd.ExecuteReader();
            //while (records.Read())
            //{
            //    DepartmentData.Content = records["Department"].ToString();
            //}
            //records.Close();

            //SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            //DataTable dt = new DataTable();
            //dataAdapter.Fill(dt);
            //ExpenseDataGrid.ItemsSource = dt.DefaultView;




      //  }

      //  private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
            
       // }

        public void showEntiteses(string empname)
        {
           ExpenceseEntities1 entities1 = new ExpenceseEntities1();//to can acess table
            var Dep_recored = entities1.TbExpences.Where(x => x.Names == empname).ToList();
            ExpenseDataGrid.ItemsSource = Dep_recored;
            var dep = entities1.TbExpences.Where(x=> x.Names == empname).Select(y => y.Department).First();
            DepartmentData.Content = dep;
            //var dep = entities1.TbExpences.FirstOrDefault(x => x.Names == empname);

            //MessageBox.Show(dep.ToString());
        }



    }
}
