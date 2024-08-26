using CA_CRUD_Theaters.Abstracts;
using CA_CRUD_Theaters.Data;

namespace CA_CRUD_Theaters.Models
{
    internal class Weeks : Cinema, ICRUD<Weeks>
    {
        public override int ID { get; set; }
        public string Week { get; set; }
        public DateTime WeekFirstDay { get; set; }
        public DateTime WeekLastDay { get; set; }

        public string Create(Weeks model)
        {
            WeekData.Weeks.Add(model);
            return "Ekleme Başarılı";
        }

        public List<Weeks> Read()
        {
            return WeekData.Weeks;
        }

        public string Update(Weeks model)
        {
            for (int index = 0; index < WeekData.Weeks.Count; index++)
            {
                if (WeekData.Weeks[index].ID == model.ID)
                {
                    WeekData.Weeks[index].Week = model.Week;
                    WeekData.Weeks[index].WeekFirstDay = model.WeekFirstDay;
                    WeekData.Weeks[index].WeekLastDay = model.WeekLastDay;
                }
            }
            return "Güncelleme Başarılı";
        }

        public string Delete(int id)
        {
            for (int index = 0; index < WeekData.Weeks.Count; index++)
            {
                if (WeekData.Weeks[index].ID == id)
                {
                    WeekData.Weeks.Remove(WeekData.Weeks[index]);
                }
            }
            return "Silme Başarılı";
        }
    }
}
