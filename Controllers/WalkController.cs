using exam05.Data;
using exam05.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace exam05.Controllers
{
    [Route("api/{controller}")]
    public class WalkController : Controller
    {
        public exam05DbContext Context { get; set; }
        public WalkController(exam05DbContext context) 
        {
            Context = context;
        }

        public IActionResult GetAllWalk()
        {

            List<Walk> walks = Context.walks.ToList();
            return Ok(walks);
        }

        [Route("id:Guid")]
        public IActionResult GetWalk([FromRoute] Guid id)
        {

            var walks = Context.walks.Find(id);
            return Ok(walks);
        }
    }
}
