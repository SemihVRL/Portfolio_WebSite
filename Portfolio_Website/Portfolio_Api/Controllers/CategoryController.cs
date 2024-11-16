using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio_Api.DAL.ApiContext;
using Portfolio_Api.DAL.Entity;

namespace Portfolio_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            using var c = new Context();
            return Ok(c.Categorys.ToList());
        } 

        [HttpGet("{id}")]
        public IActionResult GetByIdCategory(int id)
        {
            using var c=new Context();
            var value = c.Categorys.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            using var c= new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }

        [HttpDelete] 
        public IActionResult DeleteCategory(int id)
        {
            using var c=new Context();
            var values=c.Categorys.Find(id);
            if (values==null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(values);
                c.SaveChanges();
                return NoContent();
            }
        }

        [HttpPut]
        public IActionResult UpdateCategory(Category p)
        {
            using var c=new Context();
            var value=c.Find<Category>(p.CategoryID);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName = p.CategoryName;
                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }
        }

    }
}
