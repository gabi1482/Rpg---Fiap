using Microsoft.AspNetCore.Mvc;
using Rpg___Fiap.Models;

namespace Rpg___Fiap.Controllers
{

    [ApiController]
    [Route("/api/[controller]")]
    public class CharacterController : ControllerBase
    {
       
        public static Character Kinight = new Character(); 

        [HttpGet]
        public ActionResult<Character> get()
        {
            return Ok(Kinight);
        }
    }
}
