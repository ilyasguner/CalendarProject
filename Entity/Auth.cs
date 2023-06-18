using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Auth
    {
        int id;string name;//kullanıcı tipleri admin,kullanıcı

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
