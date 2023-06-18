using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataBase
{
     class SqlDataBase:SqlService
    {
        static SqlDataBase sqlDataBase;

        public static SqlDataBase GetInstance()
        {
            if(sqlDataBase==null)
            {
                sqlDataBase = new SqlDataBase();
            }
            return sqlDataBase;
        }
    }
}
