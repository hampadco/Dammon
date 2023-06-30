using System.Data;
using System.Diagnostics;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;


namespace Dammon.Controllers;

public class anbarmeController:Controller
{

    private readonly Context _db;

    public anbarmeController(Context db)
    {

        _db = db;
        
    }


    //anbar
    public IActionResult anbar()
    {
        ViewBag.anbar = _db.Anbars.OrderByDescending(x=>x.Id).ToList();
        return View();
    }

    //add anbar
    [HttpPost]
    public IActionResult addanbar(anbar anbar)
    {
        _db.Anbars.Add(anbar);
        _db.SaveChanges();
        return RedirectToAction("anbar");
    }

    //delete anbar
    public IActionResult deleteanbar(int id)
    {
        var anbar = _db.Anbars.Find(id);
        _db.Anbars.Remove(anbar);
        _db.SaveChanges();
        return RedirectToAction("anbar");
    }

// *****************************************************************
//boresh
    public IActionResult boresh()
    {
        ViewBag.boresh = _db.Boreshs.OrderByDescending(x=>x.Id).ToList();
        return View();
    }

    //add boresh
    [HttpPost]
    public IActionResult addboresh(boresh boresh)
    {
        _db.Boreshs.Add(boresh);
        _db.SaveChanges();
        return RedirectToAction("boresh");
    }

    //delete boresh
    public IActionResult deleteboresh(int id)
    {
        var boresh = _db.Boreshs.Find(id);
        _db.Boreshs.Remove(boresh);
        _db.SaveChanges();
        return RedirectToAction("boresh");
    }

// *****************************************************************
//radif
    public IActionResult radif()
    {
        ViewBag.radif = _db.Radifs.OrderByDescending(x=>x.Id).ToList();
        return View();
    }

    //add radif
    [HttpPost]
    public IActionResult addradif(radif radif)
    {
        _db.Radifs.Add(radif);
        _db.SaveChanges();
        return RedirectToAction("radif");
    }

    //delete radif
    public IActionResult deleteradif(int id)
    {
        var radif = _db.Radifs.Find(id);
        _db.Radifs.Remove(radif);
        _db.SaveChanges();
        return RedirectToAction("radif");
    }

    // *****************************************************************
    //mablagh
    public IActionResult mablagh()
    {
        ViewBag.mablagh = _db.Mablaghs.OrderByDescending(x=>x.Id).ToList();
        return View();
    }

    //add mablagh
    [HttpPost]
    public IActionResult addmablagh(mablagh mablagh)
    {
        _db.Mablaghs.Add(mablagh);
        _db.SaveChanges();
        return RedirectToAction("mablagh");
    }

    //delete mablagh
    public IActionResult deletemablagh(int id)
    {
        var mablagh = _db.Mablaghs.Find(id);
        _db.Mablaghs.Remove(mablagh);
        _db.SaveChanges();
        return RedirectToAction("mablagh");
    }


    // *****************************************************************
    //groh
    public IActionResult groh()
    {
        ViewBag.groh = _db.Grohs.OrderByDescending(x=>x.Id).ToList();
        return View();
    }

    //add groh
    [HttpPost]
    public IActionResult addgroh(groh groh)
    {
        _db.Grohs.Add(groh);
        _db.SaveChanges();
        return RedirectToAction("groh");
    }

    //delete groh
    public IActionResult deletegroh(int id)
    {
        var groh = _db.Grohs.Find(id);
        _db.Grohs.Remove(groh);
        _db.SaveChanges();
        return RedirectToAction("groh");
    }

// *****************************************************************

//sangabzar
public IActionResult sangabzar()
    {
        ViewBag.sangabzar = _db.Sangabzars.OrderByDescending(x=>x.Id).ToList();
        return View();
    }

    //add groh
    [HttpPost]
    public IActionResult addsangabzar(sangabzar sangabzar)
    {
        _db.Sangabzars.Add(sangabzar);
        _db.SaveChanges();
        return RedirectToAction("sangabzar");
    }

    //delete groh
    public IActionResult deletesangabzar(int id)
    {
        var sangabzar = _db.Sangabzars.Find(id);
        _db.Sangabzars.Remove(sangabzar);
        _db.SaveChanges();
        return RedirectToAction("sangabzar");
    }

    // *****************************************************************
    //dessang
    public IActionResult dessang()
    {
        ViewBag.dessang = _db.Dessages.OrderByDescending(x=>x.Id).ToList();
        return View();
    }

    //add dessang
    [HttpPost]
    public IActionResult adddessang(dessang dessang)
    {
        _db.Dessages.Add(dessang);
        _db.SaveChanges();
        return RedirectToAction("dessang");
    }

    //delete dessang

    public IActionResult deletedessang(int id)
    {
        var dessang = _db.Dessages.Find(id);
        _db.Dessages.Remove(dessang);
        _db.SaveChanges();
        return RedirectToAction("dessang");
    }

    // *****************************************************************
    //degree
    public IActionResult degree()
    {
        ViewBag.degree = _db.Degrees.OrderByDescending(x=>x.Id).ToList();
        return View();
    }

    //add degree
    [HttpPost]
    public IActionResult adddegree(degree degree)
    {
        _db.Degrees.Add(degree);
        _db.SaveChanges();
        return RedirectToAction("degree");
    }

    //delete degree
    public IActionResult deletedegree(int id)
    {
        var degree = _db.Degrees.Find(id);
        _db.Degrees.Remove(degree);
        _db.SaveChanges();
        return RedirectToAction("degree");
    }

    // *****************************************************************
    //quality
    public IActionResult quality()
    {
        ViewBag.quality = _db.Qualities.OrderByDescending(x=>x.Id).ToList();
        return View();
    }

    //add quality
    [HttpPost]

    public IActionResult addquality(quality quality)
    {
        _db.Qualities.Add(quality);
        _db.SaveChanges();
        return RedirectToAction("quality");
    }

    //delete quality

    public IActionResult deletequality(int id)
    {
        var quality = _db.Qualities.Find(id);
        _db.Qualities.Remove(quality);
        _db.SaveChanges();
        return RedirectToAction("quality");
    }
    

    





         



    
    
    
    




}