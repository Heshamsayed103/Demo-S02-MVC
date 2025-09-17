using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication_03.Controllers
{
    // MVC Controller
    public class MovieController : Controller
    {
        private RedirectResult redirectToActioResult;

        // Actions : Public non-Static Method
        // Actions : Have Special Return Types 
        // ActionResult
        //public string GetMovie(int id)
        //{
        //    return $"Get Movie With Id : {id}";
        //}


        //public string AddMovie(int id)
        //{
        //    return $"Add Movie With Id : {id}";
        //}


        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult
        //    {
        //        Content = $"Get Movie With Id: {id}",
        //        ContentType = "object/pdf",
        //        StatusCode = 200
        //    };

        //    return contentResult;
        //}

        //public RedirectResult GetMovie(int id)
        //{
        //    var redirectResult = new RedirectResult("https://www.google.com/");

        //    return redirectResult;
        //}

        //public RedirectResult GetMovie(int id)
        //{
        //    var redirectToActionResult = new RedirectToActionResult("AddMovie", "Movie", new { id = 133 });

        //    return redirectToActioResult;
        //}

        //public ContentResult GetMovie(int id)
        //{
        //    if (id == 1)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie With Id: {id}", ContentType = "text/html" };
        //        return Content ($"Get Movie With Id: {id}", "text/html");
        //    }
        //    else if (id == 2)
        //    {
        //        return Content($"Get Movie With Id: {id}", "text/html");
        //        //return new ContentResult() { Content = $"Get Movie With Id: {id}", ContentType = "object/html" };
        //    }
        //    else if (id == 3)
        //    {
        //        //return new RedirectResult(url: "https://www.google.com/");
        //        return Redirect("https://www.google.com/");
        //    }
        //    else
        //    {
        //        //return new RedirectToActionResult(actionName: "AddMovie", controllerName: "Movie", new { id = 133 });
        //        return new RedirectToAction("AddMovie","Movie",new {id = 133});
        //    }

        // Actions Parameter Binding 
        // 1. Form 
        // 2. Segment 
        // 3. Query Params 
        // 4. Files
        
        return Content($"Get Movie With Id: {id}", "text/html");
        public IActionResult GetMovie (Movie Movie)
        {
            return Content($"Get Movie With Id : {Movie.id} , Name : {Movie.Name}");
        
        }



        public string AddMovie(int id)
        {
            return $"Add Movie With Id : {id}";
        }
    }
}
