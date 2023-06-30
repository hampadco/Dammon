using System.Data;
using System.Diagnostics;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;


namespace Dammon.Controllers;

public class HesabHaController : Controller
{


    private readonly Context _db;

    public HesabHaController(Context db)
    {
        _db = db;
    }
   

   
    public IActionResult Group()
    {
        ViewBag.Group = _db.Accounts
                .OrderBy(a => a.Id)
                .GroupBy(a => a.CodeGroup)
                .Select(g => g.FirstOrDefault())
                .ToList();
        return View();
    }

    //add Grout model Group
    [HttpPost]
    public IActionResult Group(Account group)
    {
        

            //check TitileGroup is exist
            var TitileGroup = _db.Accounts.FirstOrDefault(x => x.TitleGroup == group.TitleGroup);
            if (TitileGroup != null)
            {
                ViewData["error"] = "عنوان گروه تکراری است";
                return RedirectToAction("group");
            }
            //find final code group and add 1
            var finalcode = _db.Accounts.OrderByDescending(x => x.CodeGroup).FirstOrDefault();
            if (finalcode == null)
            {
                group.CodeGroup = 1;
            }
            else
            {
                group.CodeGroup = finalcode.CodeGroup + 1;
            } 

            //add titile
            group.TitleTotal = "-";
            group.TitleMoin = "-";
            group.Account_type = "-";

            _db.Accounts.Add(group);
            _db.SaveChanges();
            return RedirectToAction("Group");
        
        return View(group);
    }


//deletegroup
    public IActionResult DeleteGroup(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var group = _db.Accounts.Where(x => x.Id == id).FirstOrDefault();
        if (group == null)
        {
            return NotFound();
        }
        else
        {
            //check Titile is exist

            if (group.TitleTotal != "-")
            {
                 TempData["error"] = "عنوان گروه دارای حساب است";
                 return RedirectToAction("group");
            }
            else
            {
                
                  _db.Accounts.Remove(group);
                  _db.SaveChanges();
           
            }
            



          
        }
       return RedirectToAction("Group");
    }

    //edit group
    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
     
        return RedirectToAction("group");
    }
    
    //*************************************************************

   //kol
    public IActionResult Kol()
    {
       
        //ViewBag
        ViewBag.kol = _db.Accounts
                .OrderBy(a => a.Id)
                .GroupBy(a => a.CodeTotal)
                .Select(g => g.FirstOrDefault())
                .ToList();
        //ViewBag new select list 
         var groups = _db.Accounts
                .OrderBy(a => a.Id)
                .GroupBy(a => a.CodeGroup)
                .Select(g => g.FirstOrDefault())
                .ToList();
        var selectListItems = groups.Select(g => new SelectListItem
        {
            Value = g.Id.ToString(),
            Text = $"{g.CodeGroup} . {g.TitleGroup}"
        });

        ViewBag.GroupId = new SelectList(selectListItems, "Value", "Text");


        
        return View();
    }

    //add kol
    [HttpPost]
    public IActionResult Kol(Account kol)
    {

          //check TitileGroup is exist
            var TitileGroup = _db.Accounts.FirstOrDefault(x => x.TitleGroup == kol.TitleTotal);
            if (TitileGroup != null)
            {
                ViewData["error"] = "عنوان گروه تکراری است";
                return RedirectToAction("kol");
            }
            //find final code group and add 1
            var finalcode =  _db.Accounts
                .OrderBy(a => a.Id).Where(x=>x.CodeGroup==kol.CodeGroup)
                .GroupBy(a => a.CodeTotal)
                .Select(g => g.FirstOrDefault())
                .ToList().Count()+1;
            if (finalcode == null)
            {
                kol.CodeTotal =Int32.Parse(kol.CodeGroup.ToString()+"1");
            }
            else
            {
                kol.CodeTotal = Int32.Parse(kol.CodeGroup.ToString()+finalcode.ToString());
            } 

            //add titile

            kol.TitleGroup=_db.Accounts.Where(x=>x.CodeGroup==kol.CodeGroup).FirstOrDefault().TitleGroup;
            kol.TitleMoin = "-";
            kol.Account_type = "-";
            kol.Nature = "-";

            _db.Accounts.Add(kol);
            _db.SaveChanges();
            return RedirectToAction("kol");
        
      
    }

    //delete kol
    public IActionResult DeleteKol(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var kol = _db.Accounts.Where(x => x.Id == id).FirstOrDefault();
      
        if (kol == null)
        {
            return NotFound();
        }
        else
        {
            _db.Remove(kol);
            _db.SaveChanges();
           
        }
       return RedirectToAction("Kol");
    }


// *****************************************************  
    public IActionResult Moin()
    {
        ViewBag.Moin=_db.Moins.OrderByDescending(x=>x.Id).ToList();
        //ViewBag new select list 
        var kols = _db.Kols.ToList();
        var selectListItems = kols.Select(g => new SelectListItem
        {
            Value = g.Id.ToString(),
            Text = $"{g.Titile}-{g.CodeHesab}"
        });

        ViewBag.KolId = new SelectList(selectListItems, "Value", "Text");
        return View();
       
    }

    //add moin
    [HttpPost]
    public IActionResult Moin(Moin moin)
    {
        if (ModelState.IsValid)
        {
            _db.Moins.Add(moin);
            _db.SaveChanges();
            return RedirectToAction("Moin");
        }
        return View(moin);
    }

    //delete moin
    public IActionResult DeleteMoin(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var moin = _db.Moins.Find(id);
        if (moin == null)
        {
            return NotFound();
        }
        else
        {
            _db.Moins.Remove(moin);
            _db.SaveChanges();
           
        }
       return RedirectToAction("Moin");
    }

// ************************************************
    public IActionResult Tafsili()
    {
        ViewBag.Tafsili=_db.Tafsilis.OrderByDescending(x=>x.Id).ToList();
        //ViewBag new select list kodekol
        var kols = _db.Kols.ToList();
        var selectListItems = kols.Select(g => new SelectListItem
        {
            Value = g.Id.ToString(),
            Text = $"{g.Titile}-{g.CodeHesab}"
        });

        ViewBag.KolId = new SelectList(selectListItems, "Value", "Text");
       
        return View();
    }

    //add tafsili
    [HttpPost]
    public IActionResult Tafsili(Tafsili tafsili)
    {
        if (ModelState.IsValid)
        {
            _db.Tafsilis.Add(tafsili);
            _db.SaveChanges();
            return RedirectToAction("Tafsili");
        }
        return View(tafsili);
    }

    //delete tafsili
    public IActionResult DeleteTafsili(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var tafsili = _db.Tafsilis.Find(id);
        if (tafsili == null)
        {
            return NotFound();
        }
        else
        {
            _db.Tafsilis.Remove(tafsili);
            _db.SaveChanges();
           
        }
       return RedirectToAction("Tafsili");
    }

    //get data moin buy kodekol
    public IActionResult GetMoin(int id)
    {
        var moin = _db.Moins.Where(x => x.CodeKol == id).ToList();
        //return serilaze json

        return Json(new SelectList(moin, "Id", "Titile"));



        
    }

    
    

    
}
