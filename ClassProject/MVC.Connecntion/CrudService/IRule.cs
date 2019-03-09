using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Connecntion.CrudService
{
    interface IRule
    {
        bool Create(object ObjectName);
        bool Delete(int ID);
        bool Update(object ObjectName);
        object Read();
        object Read(int ID);
    }
}
