using CA_CRUD_Theaters.Abstracts;
using CA_CRUD_Theaters.Data;

namespace CA_CRUD_Theaters.Models
{
    internal class Theaters : Cinema, ICRUD<Theaters>
    {
        public override int ID { get; set; }
        public int MovieID { get; set; }
        public int SessionID { get; set; }
        public int SaloonID { get; set; }
        public int WeekID { get; set; }

        public string Create(Theaters model)
        {
            TheaterData.Theaters.Add(model);
            return "Ekleme Başarılı";
        }

        public List<Theaters> Read()
        {
            return TheaterData.Theaters;
        }

        public string Update(Theaters model)
        {
            for (int index = 0; index < TheaterData.Theaters.Count; index++)
            {
                if (TheaterData.Theaters[index].ID == model.ID)
                {
                    TheaterData.Theaters[index].MovieID = model.MovieID;
                    TheaterData.Theaters[index].SessionID = model.SessionID;
                    TheaterData.Theaters[index].SaloonID = model.SaloonID;
                    TheaterData.Theaters[index].WeekID = model.WeekID;
                }
            }
            return "Güncelleme Başarılı";
        }

        public string Delete(int id)
        {
            for (int index = 0; index < TheaterData.Theaters.Count; index++)
            {
                if (TheaterData.Theaters[index].ID == id)
                {
                    TheaterData.Theaters.Remove(TheaterData.Theaters[index]);
                }
            }
            return "Silme Başarılı";
        }
    }
}
