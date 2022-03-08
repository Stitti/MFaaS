using MFaaS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MFaaS.Controllers
{
    [Route("api/actors")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(LibaryContext.Instance.Actors);
        }

        [HttpGet]
        [Route("name/{name}")]
        public IActionResult GetByName(string name)
        {
            Actor actor = LibaryContext.Instance.Actors.FirstOrDefault(x => x.Name.ToLower().Equals(name.ToLower()));
            if (actor == null)
                return Ok("Found no actor");

            return Ok(actor);
        }

        [HttpGet]
        [Route("gender/{gender}")]
        public IActionResult GetByGender(string gender)
        {
            IEnumerable<Actor> actors = LibaryContext.Instance.Actors.Where(x => x.Gender.ToLower().Equals(gender.ToLower()));
            if (actors == null || actors.Count() == 0)
                return Ok("Found no actors");

            return Ok(actors);
        }

        [HttpGet]
        [Route("query/{query}")]
        public IActionResult GetByQuery(string query)
        {
            IEnumerable<Actor> actors = LibaryContext.Instance.Actors.Where(x => x.Name.ToLower().Contains(query.ToLower()));
            if (actors == null || actors.Count() == 0)
                return Ok("Found no actors");

            return Ok(actors);
        }
    }
}
