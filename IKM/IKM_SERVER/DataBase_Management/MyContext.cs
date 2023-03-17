using IKM_SERVER.DataBase_Management.Table_Model;
using System.Data.Entity;

namespace IKM_SERVER.DataBase_Management
{
    public class MyContext : DbContext
    {
        public MyContext():base("IKM_SERVER_DB")
        {
        }
        public virtual DbSet<UsersModel> User_DBSet { get; set; }
    }
}
