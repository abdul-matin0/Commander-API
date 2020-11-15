using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Controllers
{
    // api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        // constructor for dependency injection
        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }

        // -- used dependency injection instead of this line
        // private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        // action result endpoint which would relate to getting all resources
        // responds to GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);
        }

        // action result returns a single resource
        // GET api/commands/5 - a get request that would respond to this uri
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }

    }
}
