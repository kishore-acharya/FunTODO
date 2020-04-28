namespace FunTODODataAccess
{
    public interface IDataAccess<T>
    {
        T GetByUserID(string iD);
        T GetByID(int iD);
    }
}
