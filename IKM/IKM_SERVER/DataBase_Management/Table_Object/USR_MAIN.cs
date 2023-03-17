using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM_SERVER.DataBase_Management.Table_Object
{
    public class USR_MAIN
    {
        [Key]
        [Required(ErrorMessage = "Please Enter UserId")]
        [Display(Name = "Please Enter UserId")]
        public string USR_login_Id = null;

        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Please Enter Password")]
        public string USR_PassWord = null;

        public int USR_Access_Lvl = 2;
    }
}
