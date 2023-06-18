using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess.DataBase;
using System.Data.SqlClient;

namespace DataAccess.Concrete
{
    public class EventDal : IReporsitory<Events>
    {

        static EventDal eventDal;//kullancağımız nesnelerimiz
        SqlService sqlService;
        SqlDataReader dataReader;


        public EventDal()
        {
            sqlService = SqlDataBase.GetInstance();
        }

        public string Add(Events entity)//yeni bir olay eklemek için
        {
            try
            {
                sqlService.Stored("AddDescription", new SqlParameter("@eventName", entity.EventName), new SqlParameter("@userName", entity.UserName),
                    new SqlParameter("@eventContent", entity.EventContent), new SqlParameter("@startTime", entity.StartTime));


                return entity.EventName + " Kaydı Başarılı Bir Şekilde Oluşturuldu";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(int id)//eklenecek
        {
            try
            {
                sqlService.Stored("DeleteDescription", new SqlParameter("@id", id));
                return "Olay Tanımlaması Başarılı Bir Şekilde Kaldırıldı";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
        }

        public Events Get(int id)//eklenecek
        {
            throw new NotImplementedException();
        }

        public List<Events> Getlist()//aşağıda yazdık yenisini
        {
            throw new NotImplementedException();
        }



        public string Update(Events entity)//güncelleme methodumuz
        {
            try
            {
                 sqlService.Stored("UpdateDescription", new SqlParameter("@id", entity.Id), new SqlParameter("@eventName", entity.EventName),
                    new SqlParameter("@eventContent", entity.EventContent), new SqlParameter("@startTime", entity.StartTime));
                return entity.EventName + " Olayı Başarılı Bir Şekilde Güncellendi";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public List<Events> OlaylarıListele(string procedure,string userName)
        {
            try
            {
                List<Events> eventsList = new List<Events>();
                dataReader = sqlService.StoreReader(procedure, new SqlParameter("@userName",userName));
                while (dataReader.Read())
                {
                    Events events;
                    events = new Events(dataReader["ID"].ConInt(), dataReader["EVENTID"].ConInt(), dataReader["USERNAME"].ToString(),
                        dataReader["EVENTNAME"].ToString(), dataReader["EVENTCONTENT"].ToString(), dataReader["CREATTIME"].ConDate(), dataReader["STARTTIME"].ConDate());

                    eventsList.Add(events);
                }
                dataReader.Close();
                return eventsList;
            }
            catch 
            {

                return new List<Events>();
            }
        }



        public static EventDal GetInstance()//nesne newleme methodumuz
        {
            if(eventDal==null)
            {
                eventDal = new EventDal();
            }
            return eventDal;
        }

       
    }
}
