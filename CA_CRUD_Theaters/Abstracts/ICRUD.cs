namespace CA_CRUD_Theaters.Abstracts
{
    internal interface ICRUD<T>
    {
        string Create(T model);
        List<T> Read();
        string Update(T model);
        string Delete(int id);
    }
}
