using CA_CRUD_Theaters.Abstracts;
using CA_CRUD_Theaters.Data;

namespace CA_CRUD_Theaters.Models
{
    internal class Categories : Cinema, ICRUD<Categories>
    {
        public override int ID { get; set; }
        public string Category { get; set; }

        public string Create(Categories model)
        {
            CategoryData.Categories.Add(model);
            return "Ekleme Başarılı";
        }

        public List<Categories> Read()
        {
            return CategoryData.Categories;
        }

        public string Update(Categories model)
        {
            for (int index = 0; index < CategoryData.Categories.Count; index++)
            {
                if (CategoryData.Categories[index].ID == model.ID)
                {
                    CategoryData.Categories[index].Category = model.Category;
                }
            }
            return "Güncelleme Başarılı";
        }

        public string Delete(int id)
        {
            for (int index = 0; index < CategoryData.Categories.Count; index++)
            {
                if (CategoryData.Categories[index].ID == id)
                {
                    CategoryData.Categories.Remove(CategoryData.Categories[index]);
                }
            }
            return "Silme Başarılı";
        }
    }
}
