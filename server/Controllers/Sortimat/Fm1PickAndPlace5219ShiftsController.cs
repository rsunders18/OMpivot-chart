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

  [ODataRoutePrefix("odata/Sortimat/Fm1PickAndPlace5219Shifts")]
  [Route("mvc/odata/Sortimat/Fm1PickAndPlace5219Shifts")]
  public partial class Fm1PickAndPlace5219ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public Fm1PickAndPlace5219ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm1PickAndPlace5219Shifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm1PickAndPlace5219Shift> GetFm1PickAndPlace5219Shifts()
    {
      var items = this.context.Fm1PickAndPlace5219Shifts.AsQueryable<Models.Sortimat.Fm1PickAndPlace5219Shift>();
      this.OnFm1PickAndPlace5219ShiftsRead(ref items);

      return items;
    }

    partial void OnFm1PickAndPlace5219ShiftsRead(ref IQueryable<Models.Sortimat.Fm1PickAndPlace5219Shift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm1PickAndPlace5219Shift> GetFm1PickAndPlace5219Shift(int key)
    {
        var items = this.context.Fm1PickAndPlace5219Shifts.Where(i=>i.RowID == key);
        this.OnFm1PickAndPlace5219ShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm1PickAndPlace5219ShiftsGet(ref IQueryable<Models.Sortimat.Fm1PickAndPlace5219Shift> items);

    partial void OnFm1PickAndPlace5219ShiftDeleted(Models.Sortimat.Fm1PickAndPlace5219Shift item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm1PickAndPlace5219Shift(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm1PickAndPlace5219Shifts
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm1PickAndPlace5219ShiftDeleted(item);
            this.context.Fm1PickAndPlace5219Shifts.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1PickAndPlace5219ShiftUpdated(Models.Sortimat.Fm1PickAndPlace5219Shift item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm1PickAndPlace5219Shift(int key, [FromBody]Models.Sortimat.Fm1PickAndPlace5219Shift newItem)
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

            this.OnFm1PickAndPlace5219ShiftUpdated(newItem);
            this.context.Fm1PickAndPlace5219Shifts.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1PickAndPlace5219Shifts.Where(i => i.RowID == key);
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
    public IActionResult PatchFm1PickAndPlace5219Shift(int key, [FromBody]Delta<Models.Sortimat.Fm1PickAndPlace5219Shift> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm1PickAndPlace5219Shifts.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm1PickAndPlace5219ShiftUpdated(item);
            this.context.Fm1PickAndPlace5219Shifts.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1PickAndPlace5219Shifts.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1PickAndPlace5219ShiftCreated(Models.Sortimat.Fm1PickAndPlace5219Shift item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm1PickAndPlace5219Shift item)
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

            this.OnFm1PickAndPlace5219ShiftCreated(item);
            this.context.Fm1PickAndPlace5219Shifts.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm1PickAndPlace5219Shifts/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
