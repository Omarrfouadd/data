using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for modify.xaml
    /// </summary>
    public partial class modify : Page
    {
        ExpenceseEntities1 db = new ExpenceseEntities1();  // make obejct of db bec  i want acess data in DATAbase 
        public modify()
        {
            InitializeComponent();
            newdatagrid.ItemsSource =db.TbExpences.ToList();     
        }
        private void ADD(object sender, RoutedEventArgs e)
        {
            if(textid.Text != "")
            {
                MessageBox.Show("ID Created Automaticlly ");
            }
            TbExpence tb_Expence = new TbExpence();
            tb_Expence.Names = textname.Text;
            tb_Expence.E_type = textexpencetype.Text;
            tb_Expence.Amount = textamount.Text;
            tb_Expence.Department = textdepartment.Text;
            db.TbExpences.Add(tb_Expence);
            db.SaveChanges();   //save change un database
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            newdatagrid.ItemsSource = db.TbExpences.ToList();

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            int Idd = int.Parse(textid.Text); // bec amake search with id
            var ex = db.TbExpences.FirstOrDefault(x=> x.Id == Idd);//store id  after found in ex
            if(ex != null)
            {
                db.TbExpences.Remove(ex);   
                db.SaveChanges();
                MessageBox.Show("Id is removed succefully : ");
            }
            else
            {
                MessageBox.Show("This Id is not found !");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
            int Idd = int.Parse(textid.Text); // bec amake search with id
            var ex = db.TbExpences.FirstOrDefault(x => x.Id == Idd);//store recored in  found in ex
            if (ex != null)
            {//turnary opreator
                ex.Id = int.Parse(textid.Text);
                ex.Names = textname.Text =="" ? ex.Names :  textname.Text;    
                ex.Department = textdepartment.Text == "" ?  ex.Department :textdepartment.Text;    
                ex.Amount = textamount.Text =="" ? ex.Amount : textamount.Text;   
                ex.E_type = textexpencetype.Text =="" ? ex.E_type : textexpencetype.Text;
                db.TbExpences.AddOrUpdate(ex);
                //  db.SaveChanges();
                MessageBox.Show("Data update succefully");

            }
            else
            {
                MessageBox.Show("No Data founded");
            }

        }
    }
}
