namespace RISK_Task3.Interfaces
{
    public interface IGenerics<T> where T : IReport, new()
    {
        void Add(T report);

        void Delete(int id);

        IEnumerable<T> GetAll();

        void Update(int id, T report);
    }
}
