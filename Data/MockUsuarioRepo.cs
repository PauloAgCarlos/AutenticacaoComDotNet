using System.Collections.Generic;
using Commander.Models;
using Commander.Data;
using System;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                 new Command { Id = 0, HowTo = "HowTo", Line="Linha", Platform="Plataforma"},
                 new Command { Id = 1, HowTo = "HowTo 1", Line="Linha 1", Platform="Plataforma 1"},
                 new Command { Id = 2, HowTo = "HowTo2", Line="Linha 2", Platform="Plataforma 2"} 

            };

            return commands;
        }

        
    

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "HowTo", Line="Linha", Platform="Plataforma"}; 
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public bool SavesChanges()
        {
           throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}