using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IReporsitory<T>//diğer sınıflarımızda da kullanacağımız methodlarımızı kalıtım verecek olan interface
    {
        List<T> Getlist();

        T Get(int id);

        string Add(T entity);

        string Update(T entity);

        string Delete(int id);


    }
}
