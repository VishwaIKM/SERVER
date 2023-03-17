using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM_SERVER.DataBase_Management.Table_Object
{
    [Table("USR_MAIN")]
    public class Users
    {
        [Key]
        //[Required(ErrorMessage = "Please Enter UserId")]
        //[Display(Name = "Please Enter UserId")]
        public string USR_login_Id { get; set; }

        //[Required(ErrorMessage = "Please Enter Password")]
        //[Display(Name = "Please Enter Password")]
        public string USR_PassWord { get; set; }

        public int USR_Access_Lvl { get; set; }
    }
}
