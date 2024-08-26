using CA_CRUD_Theaters.Abstracts;
using CA_CRUD_Theaters.Data;

namespace CA_CRUD_Theaters.Models
{
    internal class Sessions : Cinema, ICRUD<Sessions>
    {
        override public int ID { get; set; }
        public DateTime SessionsTime { get; set; }

        public string Create(Sessions model)
        {
            SessionData.Sessions.Add(model);
            return "Ekleme Başarılı";
        }

        public List<Sessions> Read()
        {
            return SessionData.Sessions;
        }

        public string Update(Sessions model)
        {
            for (int index = 0; index < SessionData.Sessions.Count; index++)
            {
                if (SessionData.Sessions[index].ID == model.ID)
                {
                    SessionData.Sessions[index].SessionsTime = model.SessionsTime;
                }
            }
            return "Güncelleme Başarılı";
        }

        public string Delete(int id)
        {
            for (int index = 0; index < SaloonData.Saloons.Count; index++)
            {
                if (SessionData.Sessions[index].ID == id)
                {
                    SessionData.Sessions.Remove(SessionData.Sessions[index]);
                }
            }
            return "Silme Başarılı";
        }
    }
}
