using aspdotnetcoreex.Models;

namespace aspdotnetcoreex.Interfaces
{
    public interface IEmployee
    {
        // my definitions only
        // first for example, im going to create a new definition

        public List<TEmployee> Create(TEmployee employee);

        public string Delete(int id);

        public List<TEmployee> update(TEmployee employee);

        public List<TEmployee> getAllEmployees();


    }
}
