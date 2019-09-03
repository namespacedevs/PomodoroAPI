using System.Collections.Generic;

namespace PomodoroCommon
{
    public interface IRepository<T>
    {
        T GetById(int id);
        ICollection<T> GetAll();
        void Remove(int id);
        void Update(T modifiedEntity);
        void Add(T newEntity);
    }
}