using System.Data;
using System.Diagnostics;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;


namespace Dammon.Controllers;

public class SaleController : Controller
{
    //add db
    private readonly Context _db;
    public SaleController(Context db)
    {
        _db = db;
    }
   
  
   
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult PishFactor()
    {

        //get all koll
        //ViewBag new select list 
         var groups = _db.Groups.ToList();
        var selectListItems = groups.Select(g => new SelectListItem
        {
            Value = g.Id.ToString(),
            Text = $"کد :{g.CodeGroup} * گروه : {g.Titile}"
        });

        ViewBag.GroupId = new SelectList(selectListItems, "Value", "Text");
       
        
        return View();
    }



    //ActKoll
    public IActionResult ActKoll()
    {
        
               return View();

    }
    

    
}
