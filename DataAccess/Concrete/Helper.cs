﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public static class Helper//yardımcı sınıfımız
    {
        public static DateTime ConDate(this object param)
        {
            return Convert.ToDateTime(param);
        }

        public static int ConInt(this object param)
        {
            return Convert.ToInt32(param);
        }

        public static bool ConBool(this object param)
        {
            return Convert.ToBoolean(param);
        }
    }
}
