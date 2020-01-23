using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsEmpty.Models;

namespace WebFormsEmpty.Interfaces
{
    public interface IMultyService<T> where T : class
    {
        List<T> getAll_1();
        IEnumerable<T> getAll_2();
        void Add(T item);
        T getById(int Id);
        IEnumerable<T> getByName(string Name);
        void Update_1(T item);
        void Update_2(int Id, T item);
        void Update_3(T item);
        void Delete(int Id);
    }
}
