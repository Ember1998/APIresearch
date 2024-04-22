using ApiManagmement.Model;

namespace ApiManagmement.Service.IServices
{
    public interface ITodoService
    {
        void Create(Todo todo);
        void Edit(Todo todo);
        Todo Detail(int id);
        void Delete(int id);
        string Todoasfd(string todo);
    }
}
