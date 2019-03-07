namespace MVC.Connecntion.MVC_AccModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCModel : DbContext
    {
        public MVCModel()
            : base("name=MVCModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<MVC.Connecntion.Table.Pages> AllPages { get; set; }
        public virtual DbSet<MVC.Connecntion.Table.AllImages> AllImages { get; set; }
    }
}
