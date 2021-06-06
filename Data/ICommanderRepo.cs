using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    //creating an Interface. And all interface is i just 
    //list of the method signatures that you going to provide
    //to consumer of this interface
    public interface ICommanderRepo
    {
        //REST api has typically create,read,update,delete operations

        //get all command objects/resources. To define that you have
        //to use IEnumerable as return type
        IEnumerable<Command> GetAppCommands();
        //second will be return command object based on provided
        //id of command
        Command GetCommandById(int id);
        
    }
}