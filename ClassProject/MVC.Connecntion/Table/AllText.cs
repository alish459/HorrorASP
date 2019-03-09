using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Connecntion.Table
{
    public class AllText
    {
        public AllText()
        {
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int TextID { get; set; }
        [Column(Order = 1)]
        public string H1Text { get; set; }
        [Column(Order = 2)]
        public string H2Text { get; set; }
        [Column(Order = 3)]
        public string TextExplain { get; set; }
        [Column(Order = 4)]
        public int PageID { get; set; }
        [Column(Order = 5)]
        public int? ImageID { get; set; }
        [Column(Order = 6)]
        public decimal Price { get; set; }
        [ForeignKey("PageID")]
        public Pages Pages { get; set; }
        [ForeignKey("ImageID")]
        public AllImages AllImages { get; set; }
    }
}
