using System;
using System.Net;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNet.OData.Query;



namespace DataAnalysis.Controllers.Sortimat
{
  using Models;
  using Data;
  using Models.Sortimat;

  [ODataRoutePrefix("odata/Sortimat/Shifts")]
  [Route("mvc/odata/Sortimat/Shifts")]
  public partial class ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Shifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Shift> GetShifts()
    {
      var items = this.context.Shifts.AsQueryable<Models.Sortimat.Shift>();
      this.OnShiftsRead(ref items);

      return items;
    }

    partial void OnShiftsRead(ref IQueryable<Models.Sortimat.Shift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{ShiftID}")]
    public SingleResult<Shift> GetShift(int key)
    {
        var items = this.context.Shifts.Where(i=>i.ShiftID == key);
        this.OnShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnShiftsGet(ref IQueryable<Models.Sortimat.Shift> items);

    partial void OnShiftDeleted(Models.Sortimat.Shift item);

    [HttpDelete("{ShiftID}")]
    public IActionResult DeleteShift(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Shifts
                .Where(i => i.ShiftID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnShiftDeleted(item);
            this.context.Shifts.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnShiftUpdated(Models.Sortimat.Shift item);

    [HttpPut("{ShiftID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutShift(int key, [FromBody]Models.Sortimat.Shift newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.ShiftID != key))
            {
                return BadRequest();
            }

            this.OnShiftUpdated(newItem);
            this.context.Shifts.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Shifts.Where(i => i.ShiftID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{ShiftID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchShift(int key, [FromBody]Delta<Models.Sortimat.Shift> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Shifts.Where(i => i.ShiftID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnShiftUpdated(item);
            this.context.Shifts.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Shifts.Where(i => i.ShiftID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnShiftCreated(Models.Sortimat.Shift item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Shift item)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (item == null)
            {
                return BadRequest();
            }

            this.OnShiftCreated(item);
            this.context.Shifts.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Shifts/{item.ShiftID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
