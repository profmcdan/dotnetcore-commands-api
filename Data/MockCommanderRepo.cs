using System;
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public MockCommanderRepo()
        {
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil water", Platform = "Kettle & Pen" },
                new Command { Id = 1, HowTo = "Sleep", Platform = "Matress" },
                new Command { Id = 2, HowTo = "Bathe", Platform = "Water" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil water", Platform = "Kettle & Pen" };
        }
    }
}
