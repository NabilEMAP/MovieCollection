using Microsoft.AspNetCore.Mvc;
using MovieCollection.DAL.Contexts;
using MovieCollection.DAL.Models;

namespace MovieCollection.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public abstract class APIv1Controller : ControllerBase
    {

    }
}
