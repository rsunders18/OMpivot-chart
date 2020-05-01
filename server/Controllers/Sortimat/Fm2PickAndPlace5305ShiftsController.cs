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

  [ODataRoutePrefix("odata/Sortimat/Fm2PickAndPlace5305Shifts")]
  [Route("mvc/odata/Sortimat/Fm2PickAndPlace5305Shifts")]
  public partial class Fm2PickAndPlace5305ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public Fm2PickAndPlace5305ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm2PickAndPlace5305Shifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm2PickAndPlace5305Shift> GetFm2PickAndPlace5305Shifts()
    {
      var items = this.context.Fm2PickAndPlace5305Shifts.AsQueryable<Models.Sortimat.Fm2PickAndPlace5305Shift>();
      this.OnFm2PickAndPlace5305ShiftsRead(ref items);

      return items;
    }

    partial void OnFm2PickAndPlace5305ShiftsRead(ref IQueryable<Models.Sortimat.Fm2PickAndPlace5305Shift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm2PickAndPlace5305Shift> GetFm2PickAndPlace5305Shift(int key)
    {
        var items = this.context.Fm2PickAndPlace5305Shifts.Where(i=>i.RowID == key);
        this.OnFm2PickAndPlace5305ShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm2PickAndPlace5305ShiftsGet(ref IQueryable<Models.Sortimat.Fm2PickAndPlace5305Shift> items);

    partial void OnFm2PickAndPlace5305ShiftDeleted(Models.Sortimat.Fm2PickAndPlace5305Shift item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm2PickAndPlace5305Shift(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm2PickAndPlace5305Shifts
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm2PickAndPlace5305ShiftDeleted(item);
            this.context.Fm2PickAndPlace5305Shifts.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2PickAndPlace5305ShiftUpdated(Models.Sortimat.Fm2PickAndPlace5305Shift item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm2PickAndPlace5305Shift(int key, [FromBody]Models.Sortimat.Fm2PickAndPlace5305Shift newItem)
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

            this.OnFm2PickAndPlace5305ShiftUpdated(newItem);
            this.context.Fm2PickAndPlace5305Shifts.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2PickAndPlace5305Shifts.Where(i => i.RowID == key);
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
    public IActionResult PatchFm2PickAndPlace5305Shift(int key, [FromBody]Delta<Models.Sortimat.Fm2PickAndPlace5305Shift> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm2PickAndPlace5305Shifts.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm2PickAndPlace5305ShiftUpdated(item);
            this.context.Fm2PickAndPlace5305Shifts.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2PickAndPlace5305Shifts.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2PickAndPlace5305ShiftCreated(Models.Sortimat.Fm2PickAndPlace5305Shift item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm2PickAndPlace5305Shift item)
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

            this.OnFm2PickAndPlace5305ShiftCreated(item);
            this.context.Fm2PickAndPlace5305Shifts.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm2PickAndPlace5305Shifts/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
