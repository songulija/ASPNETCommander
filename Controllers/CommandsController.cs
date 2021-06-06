using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    //creating a CommandsController class. Which inherits from
    //ControllerBase. Which is base class from MVC. We can inherit
    //from Controller but it then need view support
    //this class will be ApiController and we define Route to this
    //Commands controller. Its base route of our CommandsController
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        //we need to create constructor in order for that dependency to be injected
        //whenever our application asks for ICommanderRepo
        //give them MockCommanderRepo which is implementation we set it in Startup.cs
        public CommandsController(ICommanderRepo repository)
        {
            //whatever is injected via dependency injection system into "repository"
            //we want to assign it to _repository
            _repository = repository;
        }

        //creating MockCommanderRepo object which is implementation of ICommanderRepo
        //private readonly MockCommanderRepo repository = new MockCommanderRepo();
        

        //GetAllCommands returns back IEnumerable(like collection of Command objects)
        //When making GET request to /api/commands route
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            //return commandItems with code 200 success 
            return Ok(commandItems);
        }

        //next ActionResult returns Command object. Have to provide id
        //When making GET request to /api/commands/{id} route
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            //this id comes from our route
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }


    }
}