using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User
    {
        int id,authId; string name, authName,userName,telphone,identityNo,mail,adress;
        //kullanıcı özellikleri
        

        public int Id { get => id; set => id = value; }
        public int AuthId { get => authId; set => authId = value; }
        public string Name { get => name; set => name = value; }
        public string AuthName { get => authName; set => authName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Telphone { get => telphone; set => telphone = value; }
        public string IdentityNo { get => identityNo; set => identityNo = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Adress { get => adress; set => adress = value; }

        

        public User(string userName, string name, string identityNo, string telephone, string mail, string adress,int authId)
        {
            this.userName = userName;
            this.name = name;
            this.identityNo = identityNo;
            this.telphone = telephone;
            this.mail = mail;
            this.adress = adress;
            this.authId = authId;
        }
    }
}
