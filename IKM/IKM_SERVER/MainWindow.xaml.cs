using IKM_SERVER.DataBase_Management;
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

namespace IKM_SERVER
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            calldata();
        }

        private void calldata()
        {
            try
            {
                using (var context = new MyContext())
                {
                    var query = context.User_DBSet.Where(p => p.USR_PassWord == "7777" && p.USR_login_Id == "Vishwa").FirstOrDefault();
                    if (query != null)
                        MessageBox.Show("User ID or Password" + query.USR_Access_Lvl);
                    else
                        MessageBox.Show("Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
