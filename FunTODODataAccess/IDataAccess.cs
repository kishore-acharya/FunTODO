namespace FunTODODataAccess
{
    public interface IDataAccess<T>
    {
        T GetByUsername(string iD);
        T GetByID(int iD);
    }
}
