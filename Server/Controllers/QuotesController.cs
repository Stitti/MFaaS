using MFaaS.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MFaaS.Server.Controllers
{
    [Route("api/quotes")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(LibaryContext.Instance.Quotations);
        }

        [HttpGet]
        [Route("random")]
        public IActionResult GetRandom()
        {
            Random random = new Random();
            int index = random.Next(LibaryContext.Instance.Quotations.Count - 1);
            return Ok(LibaryContext.Instance.Quotations[index]);
        }

        [HttpGet]
        [Route("random/{count}")]
        public IActionResult GetMultipleRandom(int count)
        {
            List<Quotation> quotations = new List<Quotation>();
            Random random = new Random();
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                index = random.Next(LibaryContext.Instance.Quotations.Count - 1);
                quotations.Add(LibaryContext.Instance.Quotations[index]);
            }

            return Ok(quotations);
        }

        [HttpGet]
        [Route("actor/{actor}")]
        public IActionResult GetByActor(string actor)
        {
            IEnumerable<Quotation> quotations = LibaryContext.Instance.Quotations.Where(x => x.Actor.ToLower().Equals(actor.ToLower()));
            if (quotations == null || quotations.Count() == 0)
                return Ok("Found no quotes");

            return Ok(quotations);
        }

        [HttpGet]
        [Route("actor/query/{query}")]
        public IActionResult GetByActorQuery(string query)
        {
            IEnumerable<Quotation> quotations = LibaryContext.Instance.Quotations.Where(x => x.Actor.ToLower().Contains(query.ToLower()));
            if (quotations == null || quotations.Count() == 0)
                return Ok("Found no quotes");

            return Ok(quotations);
        }

        [HttpGet]
        [Route("query/{query}")]
        public IActionResult GetByQuery(string query)
        {
            IEnumerable<Quotation> quotations = LibaryContext.Instance.Quotations.Where(x => x.Quote.ToLower().Contains(query.ToLower()));
            if (quotations == null || quotations.Count() == 0)
                return Ok("Found no quotes");

            return Ok(quotations);
        }
    }
}
