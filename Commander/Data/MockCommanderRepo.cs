﻿using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        // this class acts has a mockup hard coded data for api
        public IEnumerable<Command> GetAllCommands()
        {

            var commands = new List<Command> { 
                
                new Command{ Id = 0, HowTo = "Rice", Line = "Pot and Stuffs", Platform = "Pot and Hot Water" },
                new Command{ Id = 1, HowTo = "Cut Bread", Line = "Get Knife", Platform = "Chooping Board" },
                new Command{ Id = 2, HowTo = "Tea", Line = "Place Tea bag in cup", Platform = "Cup" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil An Egg", Line = "Boil Water", Platform = "Kettle & Pan" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
