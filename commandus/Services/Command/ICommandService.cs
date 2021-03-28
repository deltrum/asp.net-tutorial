using System.Collections.Generic;
using server.Models;

namespace server.Services
{
    public interface ICommandService
    {
        bool SaveChanges();

        void Create(Command cmd);

        void Delete(Command cmd);

        IList<Command> GetAll();

        Command GetOne(int Id);
    }
}