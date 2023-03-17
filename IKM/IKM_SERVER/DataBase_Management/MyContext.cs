using IKM_SERVER.DataBase_Management.Table_Object;
using System.Data.Entity;

namespace IKM_SERVER.DataBase_Management
{
    public class MyContext : DbContext
    {
        public MyContext():base("IKM_SERVER_DB")
        {
        }
        public virtual DbSet<Users> user { get; set; }
    }
}
