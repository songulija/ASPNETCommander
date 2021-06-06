using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    //creating MarkCommanderRepo class that implements that 
    //IComanderinterface. after class name you put interface
    //that you want to implement
    public class MockCommanderRepo : ICommanderRepo
    {
        //implementing ICommander interface methods
        //first is to get all command
        public IEnumerable<Command> GetAppCommands()
        {
            //creating list of Command object. Adding some command objects
            var commands = new List<Command>
            {
                new Command{Id = 1, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id = 2, HowTo="Cut bread", Line="Get a knife", Platform="Knige & Chopping board"},
                new Command{Id = 3, HowTo="Make cup of tea", Line="Place teabag in cup", Platform="Kettle & cup"}
            };
            return commands;
        }
        //second method to get command by id
        public Command GetCommandById(int id)
        {
            return new Command{Id = 0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
        }
    }
}