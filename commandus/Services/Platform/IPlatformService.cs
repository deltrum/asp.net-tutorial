using System.Collections.Generic;
using server.Models;

namespace server.Services
{
    public interface IPlatformService
    {
        bool SaveChanges();

        void Create(Platform platform);

        void Delete(Platform platform);

        IList<Platform> GetAll();

        Platform GetOne(int Id);
    }
}