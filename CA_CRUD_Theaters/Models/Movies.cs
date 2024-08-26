using CA_CRUD_Theaters.Abstracts;
using CA_CRUD_Theaters.Data;

namespace CA_CRUD_Theaters.Models
{
    internal class Movies : Cinema, ICRUD<Movies>
    {
        public override int ID { get; set; }
        public string Movie { get; set; }
        public string Destcription { get; set; }
        public int Duration { get; set; }

        public string Create(Movies model)
        {
            MovieData.Movies.Add(model);
            return "Ekleme Başarılı";
        }

        public List<Movies> Read()
        {
            return MovieData.Movies;
        }

        public string Update(Movies model)
        {
            for (int index = 0; index < MovieData.Movies.Count; index++)
            {
                if (MovieData.Movies[index].ID == model.ID)
                {
                    MovieData.Movies[index].Movie = model.Movie;
                    MovieData.Movies[index].Destcription = model.Destcription;
                    MovieData.Movies[index].Duration = model.Duration;
                }
            }
            return "Güncelleme Başarılı";
        }

        public string Delete(int id)
        {
            for (int index = 0; index < MovieData.Movies.Count; index++)
            {
                if (MovieData.Movies[index].ID == id)
                {
                    MovieData.Movies.Remove(MovieData.Movies[index]);
                }
            }
            return "Silme Başarılı";
        }
    }
}
