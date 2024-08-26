using CA_CRUD_Theaters.Abstracts;
using CA_CRUD_Theaters.Data;

namespace CA_CRUD_Theaters.Models
{
    internal class Saloons : Cinema, ICRUD<Saloons>
    {
        public override int ID { get; set; }
        public string Saloon { get; set; }
        public int Capacity { get; set; }

        public string Create(Saloons model)
        {
            SaloonData.Saloons.Add(model);
            return "Ekleme Başarılı";
        }

        public List<Saloons> Read()
        {
            return SaloonData.Saloons;
        }

        public string Update(Saloons model)
        {
            for (int index = 0; index < SaloonData.Saloons.Count; index++)
            {
                if (SaloonData.Saloons[index].ID == model.ID)
                {
                    SaloonData.Saloons[index].Saloon = model.Saloon;
                    SaloonData.Saloons[index].Capacity = model.Capacity;
                }
            }
            return "Güncelleme Başarılı";
        }

        public string Delete(int id)
        {
            for (int index = 0; index < SaloonData.Saloons.Count; index++)
            {
                if (SaloonData.Saloons[index].ID == id)
                {
                    SaloonData.Saloons.Remove(SaloonData.Saloons[index]);
                }
            }
            return "Silme Başarılı";
        }
    }
}
