using server.Data;
using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace server.Services
{
    public class CommandService : ICommandService
    {
        private readonly DatabaseContext _context;

        public CommandService(DatabaseContext context)
        {
            _context = context;
        }

        //! Data manipulations
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Create(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Add(cmd);
        }

        public void Delete(Command cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Commands.Remove(cmd);
        }

        public IList<Command> GetAll()
        {
            return _context.Commands.ToList();
        }

        public Command GetOne(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}