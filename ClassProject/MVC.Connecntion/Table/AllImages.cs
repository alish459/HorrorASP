using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Connecntion.Table
{
    public class AllImages
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageID { get; set; }
        [StringLength(200)]
        public string ImageUrl { get; set; }
        public int BlogID { get; set; }
    }
}
