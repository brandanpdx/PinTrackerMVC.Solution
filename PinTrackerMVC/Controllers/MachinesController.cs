using Microsoft.AspNetCore.Mvc;
using PinTrackerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PinTrackerMVC.Controllers
{
  public class MachinesController : Controller
  {
  
    public ActionResult Index()
    {
      
      var allMachines = Machine.GetMachine();
      List<Machine> sortedMachineList = allMachines.OrderBy(mach => mach.name).ToList();
      // List<Machine> thisMachine = allMachines.Where(mach => mach.name == "Monster Bash").ToList();
      return View(sortedMachineList);
    }

      // Incomplete code for PinTrackerAPI.Solution

    // public ActionResult Search(string searchByMachine)
    // {
    //   var searchMachine = Machine.SearchByName();
    //   List<Machine> thisMachine = searchMachine.ToList();

    //   return View(searchMachine);
    // }
  }
}