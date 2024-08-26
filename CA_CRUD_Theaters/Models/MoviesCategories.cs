using CA_CRUD_Theaters.Abstracts;
using CA_CRUD_Theaters.Data;

namespace CA_CRUD_Theaters.Models
{
    internal class MoviesCategories : Cinema, ICRUD<MoviesCategories>
    {
        public override int ID { get; set; }
        public int CategoryID { get; set; }

        public string Create(MoviesCategories model)
        {
            MovieCategoryData.MovieCatagories.Add(model);
            return "Ekleme Başarılı";
        }

        public List<MoviesCategories> Read()
        {
            return MovieCategoryData.MovieCatagories;
        }

        public string Update(MoviesCategories model)
        {
            for (int index = 0; index < MovieCategoryData.MovieCatagories.Count; index++)
            {
                if (MovieCategoryData.MovieCatagories[index].ID == model.ID)
                {
                    MovieCategoryData.MovieCatagories[index].CategoryID = model.CategoryID;
                }
            }
            return "Güncelleme Başarılı";
        }

        public string Delete(int id)
        {
            for (int index = 0; index < MovieCategoryData.MovieCatagories.Count; index++)
            {
                if (MovieCategoryData.MovieCatagories[index].ID == id)
                {
                    MovieCategoryData.MovieCatagories.Remove(MovieCategoryData.MovieCatagories[index]);
                }
            }
            return "Silme Başarılı";
        }
    }
}
