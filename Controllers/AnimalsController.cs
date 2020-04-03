using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;
      public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/Animals
    [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get()
    {
      return  _db.Animals.ToList();
    }

    // GET api/Animals/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "value";
    }

    // POST api/Animals
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/Animals/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Animals/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
