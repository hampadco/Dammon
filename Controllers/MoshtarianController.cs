using System.Data;
using System.Diagnostics;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;


namespace Dammon.Controllers;

public class MoshtarianController : Controller
{
   
  private readonly string _connectionString = "Server=.;Database=test2;Integrated Security=True;TrustServerCertificate=True";

   
    public IActionResult Add()
    {
        return View();
    }

    public IActionResult PishFactor()
    {
       
        
        return View();
    }




    
}
