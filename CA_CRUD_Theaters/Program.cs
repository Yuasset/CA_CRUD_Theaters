using CA_CRUD_Theaters.Models;

Categories categories = new Categories();

Categories categories1 = new Categories();
categories1.ID = 1;
categories1.Category = "Action";
categories.Create(categories1);

Categories categories2 = new Categories();
categories2.ID = 2;
categories2.Category = "Comedy";
categories.Create(categories2);

Categories categories3 = new Categories();
categories3.ID = 3;
categories3.Category = "Drama";
categories.Create(categories3);


//Listele
foreach (Categories category in categories.Read())
{
    Console.WriteLine(category.ID + " " + category.Category);
}
Console.WriteLine("**************************************");

//Sil
categories.Delete(1);

//Listele
foreach (Categories category in categories.Read())
{
    Console.WriteLine(category.ID + " " + category.Category);
}

Console.WriteLine("**************************************");

//Güncelle
categories.Update(new Categories { ID = 2, Category = "Honor" });

//Listele
foreach (Categories category in categories.Read())
{
    Console.WriteLine(category.ID + " " + category.Category);
}