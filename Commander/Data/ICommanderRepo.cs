using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        // you define the operations of a method that are available via this interface
        // method signature to get all command resources / objects
        IEnumerable<Command> GetAppCommands();

        // return a single command back to the user based on an Id that they're going to provide
        Command GetCommandById(int id);


    }
}
