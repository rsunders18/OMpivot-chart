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

  [ODataRoutePrefix("odata/Sortimat/Sh1PickAndPlace5220Shifts")]
  [Route("mvc/odata/Sortimat/Sh1PickAndPlace5220Shifts")]
  public partial class Sh1PickAndPlace5220ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public Sh1PickAndPlace5220ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh1PickAndPlace5220Shifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh1PickAndPlace5220Shift> GetSh1PickAndPlace5220Shifts()
    {
      var items = this.context.Sh1PickAndPlace5220Shifts.AsQueryable<Models.Sortimat.Sh1PickAndPlace5220Shift>();
      this.OnSh1PickAndPlace5220ShiftsRead(ref items);

      return items;
    }

    partial void OnSh1PickAndPlace5220ShiftsRead(ref IQueryable<Models.Sortimat.Sh1PickAndPlace5220Shift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Sh1PickAndPlace5220Shift> GetSh1PickAndPlace5220Shift(int key)
    {
        var items = this.context.Sh1PickAndPlace5220Shifts.Where(i=>i.RowID == key);
        this.OnSh1PickAndPlace5220ShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh1PickAndPlace5220ShiftsGet(ref IQueryable<Models.Sortimat.Sh1PickAndPlace5220Shift> items);

    partial void OnSh1PickAndPlace5220ShiftDeleted(Models.Sortimat.Sh1PickAndPlace5220Shift item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteSh1PickAndPlace5220Shift(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh1PickAndPlace5220Shifts
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh1PickAndPlace5220ShiftDeleted(item);
            this.context.Sh1PickAndPlace5220Shifts.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1PickAndPlace5220ShiftUpdated(Models.Sortimat.Sh1PickAndPlace5220Shift item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh1PickAndPlace5220Shift(int key, [FromBody]Models.Sortimat.Sh1PickAndPlace5220Shift newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.RowID != key))
            {
                return BadRequest();
            }

            this.OnSh1PickAndPlace5220ShiftUpdated(newItem);
            this.context.Sh1PickAndPlace5220Shifts.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1PickAndPlace5220Shifts.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchSh1PickAndPlace5220Shift(int key, [FromBody]Delta<Models.Sortimat.Sh1PickAndPlace5220Shift> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh1PickAndPlace5220Shifts.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh1PickAndPlace5220ShiftUpdated(item);
            this.context.Sh1PickAndPlace5220Shifts.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1PickAndPlace5220Shifts.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1PickAndPlace5220ShiftCreated(Models.Sortimat.Sh1PickAndPlace5220Shift item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh1PickAndPlace5220Shift item)
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

            this.OnSh1PickAndPlace5220ShiftCreated(item);
            this.context.Sh1PickAndPlace5220Shifts.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh1PickAndPlace5220Shifts/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
