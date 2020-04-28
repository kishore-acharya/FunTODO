namespace FunTODORepository.Entities
{
    public interface IEntityListRepository<IEntityList>
    {
        IEntityList GetByUserID(string ID);
    }
}