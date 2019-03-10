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
        public int TextID { get; set; }
        public string H1Text { get; set; }
        public string H2Text { get; set; }
        public string TextExplain { get; set; }
        public int PageID { get; set; }
        public int? ImageID { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
        public string PublishedDate { get; set; }
        public int VisitCount  { get; set; }
        [ForeignKey("PageID")]
        public Pages Pages { get; set; }
        [ForeignKey("ImageID")]
        public AllImages AllImages { get; set; }
    }
}
