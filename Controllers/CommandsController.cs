using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Commander.Models;
using Commander.Data;

namespace Commander.Controllers
{
    // api/commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        //GET api/commnds
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);

        }

        // GET api/commnds/:id
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}