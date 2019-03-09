using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Connecntion.Table
{
    public class Pages
    {
        public Pages()
        {
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PageID { get; set; }
        [StringLength(100)]
        public string PageName { get; set; }
        public bool IsAdmin { get; set; }
        public ICollection<AllText> AllTexts { get; set; }
        //public ICollection<AllImages> AllImages { get; set; }
    }
}
