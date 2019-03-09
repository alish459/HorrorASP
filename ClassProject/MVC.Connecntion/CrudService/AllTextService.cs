using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Connecntion.CrudService
{
    public class AllTextService : IRule
    {
        public bool Create(object ObjectName)
        {
            using (var context = new Connecntion.MVC_AccModel.MVCModel())
            {
                context.Database.CommandTimeout = 0;
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.AllTexts.Add(ObjectName as Connecntion.Table.AllText);
                        context.SaveChanges();
                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.ToString());
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }
        public bool Delete(int ID)
        {
            using (var context = new Connecntion.MVC_AccModel.MVCModel())
            {
                context.Database.CommandTimeout = 0;
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.AllTexts.Remove(context.AllTexts.Find(ID));
                        context.SaveChanges();
                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.ToString());
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }
        public object Read()
        {
            using (var context = new Connecntion.MVC_AccModel.MVCModel())
            {
                return context.AllTexts.ToList();
            }
        }
        public object Read(int ID)
        {
            using (var context = new Connecntion.MVC_AccModel.MVCModel())
            {
                return context.AllTexts.Find(ID);
            }
        }
        public bool Update(object ObjectName)
        {
            using (var context = new Connecntion.MVC_AccModel.MVCModel())
            {
                context.Database.CommandTimeout = 0;
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.AllTexts.Attach(ObjectName as Connecntion.Table.AllText);
                        context.Entry(ObjectName as Connecntion.Table.AllText).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();
                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.ToString());
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}
