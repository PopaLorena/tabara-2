using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Route("api/joc")]
    [ApiController]
    public class jocuriC : ControllerBase
    {
        private Context con;

        public jocuriC(Context context)
        {
            con = context;
        }

        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> CreateItem(jocuri joc)
        {
            con.Jocuri.Add(joc);
            con.SaveChanges();

            return Created("bravo",
                joc);
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> GetItemes()
        {
            var jocuri = con.Jocuri.ToList();

            return Ok(jocuri);
        }
    }
}
