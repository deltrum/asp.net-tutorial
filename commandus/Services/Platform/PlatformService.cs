using server.Data;
using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace server.Services
{
    public class PlatformService : IPlatformService
    {
        private readonly DatabaseContext _context;

        public PlatformService(DatabaseContext context)
        {
            _context = context;
        }

        //! Data manipulations
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Create(Platform platform)
        {
            if (platform == null)
            {
                throw new ArgumentNullException(nameof(platform));
            }

            _context.Platforms.Add(platform);
        }

        public void Delete(Platform platform)
        {
            if (platform == null)
            {
                throw new ArgumentNullException(nameof(platform));
            }

            _context.Platforms.Remove(platform);
        }

        public IList<Platform> GetAll()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetOne(int id)
        {
            return _context.Platforms.FirstOrDefault(p => p.Id == id);
        }
    }
}