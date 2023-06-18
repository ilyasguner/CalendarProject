using DataAccess.Abstract;
using DataAccess.DataBase;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concrete
{
    public class UserDal:IReporsitory<User>
    {
        static UserDal userDal;
        SqlService sqlService;
        SecurityProcess securityProcess;
        SqlDataReader dataReader;
        public UserDal()
        {
            sqlService = SqlDataBase.GetInstance();
            securityProcess = SecurityProcess.GetInstance();
        }

        

        public string Add(User entity)
        {
            try
            {
                sqlService.Stored("AddUser", new SqlParameter("@userName", entity.UserName), new SqlParameter("@nameSurname", entity.Name),
                    new SqlParameter("@identityNo", entity.IdentityNo), new SqlParameter("@telephone", entity.Telphone),new SqlParameter("@mail",entity.Mail),
                    new SqlParameter("@adress",entity.Adress),new SqlParameter("@authId",entity.AuthId));

                return entity.UserName + " Adlı Kullanıcı Başarıyla Eklendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                sqlService.Stored("DeleteUser", new SqlParameter("@id", id));
                return "Kullanıcı Başarılı Bir Şekilde Kaldırıldı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Getlist()
        {
            throw new NotImplementedException();
        }

        public string Update(User entity)
        {
            try
            {
                sqlService.Stored("UpdateUser", new SqlParameter("@id", entity.Id), new SqlParameter("@telephone", entity.Telphone),
                   new SqlParameter("mail", entity.Mail), new SqlParameter("@adress", entity.Adress));
                return entity.UserName + " Kullanıcısı Başarılı Bir Şekilde Güncellendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


        public object[] Login(string kullanıcıAdı,string şifre)
        {
            try
            {
                object[] infos = null;
                string şifre2 = securityProcess.Encrypt("key", şifre);
                dataReader = sqlService.StoreReader("UserLogin", new SqlParameter("@userName", kullanıcıAdı), new SqlParameter("@password", şifre2));
                if(dataReader.Read())
                {
                    string userName, adSoyad, kimlik, telefon, mail, adres;
                    userName = dataReader["USERNAME"].ToString();
                    adSoyad = dataReader["NAME_SURNAME"].ToString();
                    kimlik = dataReader["IDENTITYNO"].ToString();
                    telefon = dataReader["TELEPHONE"].ToString();
                    mail = dataReader["EMAIL"].ToString();
                    adres = dataReader["ADRESS"].ToString();


                    infos = new object[] { userName, adSoyad, kimlik, telefon, mail, adres };
                }
                dataReader.Close();
                return infos;
            }
            catch 
            {

                return null;
            }
            
        }
        public void AddLogin(string kullanıcıAdı,string şifre)
        {
            try
            {
                string şifre2 = securityProcess.Encrypt("key", şifre);
                sqlService.Stored("AddLogın",new SqlParameter("@userName",kullanıcıAdı),new SqlParameter("@password",şifre2));
            }
            catch (Exception)
            {

                throw;
            }
        }



        public static UserDal GetInstance()
        {
            if (userDal == null)
            {
                userDal = new UserDal();
            }
            return userDal;
        }
    }
}
