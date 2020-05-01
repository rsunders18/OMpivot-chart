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

  [ODataRoutePrefix("odata/Sortimat/Sh2PickAndPlace5307Shifts")]
  [Route("mvc/odata/Sortimat/Sh2PickAndPlace5307Shifts")]
  public partial class Sh2PickAndPlace5307ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public Sh2PickAndPlace5307ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh2PickAndPlace5307Shifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh2PickAndPlace5307Shift> GetSh2PickAndPlace5307Shifts()
    {
      var items = this.context.Sh2PickAndPlace5307Shifts.AsQueryable<Models.Sortimat.Sh2PickAndPlace5307Shift>();
      this.OnSh2PickAndPlace5307ShiftsRead(ref items);

      return items;
    }

    partial void OnSh2PickAndPlace5307ShiftsRead(ref IQueryable<Models.Sortimat.Sh2PickAndPlace5307Shift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Sh2PickAndPlace5307Shift> GetSh2PickAndPlace5307Shift(int key)
    {
        var items = this.context.Sh2PickAndPlace5307Shifts.Where(i=>i.RowID == key);
        this.OnSh2PickAndPlace5307ShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh2PickAndPlace5307ShiftsGet(ref IQueryable<Models.Sortimat.Sh2PickAndPlace5307Shift> items);

    partial void OnSh2PickAndPlace5307ShiftDeleted(Models.Sortimat.Sh2PickAndPlace5307Shift item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteSh2PickAndPlace5307Shift(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh2PickAndPlace5307Shifts
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh2PickAndPlace5307ShiftDeleted(item);
            this.context.Sh2PickAndPlace5307Shifts.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh2PickAndPlace5307ShiftUpdated(Models.Sortimat.Sh2PickAndPlace5307Shift item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh2PickAndPlace5307Shift(int key, [FromBody]Models.Sortimat.Sh2PickAndPlace5307Shift newItem)
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

            this.OnSh2PickAndPlace5307ShiftUpdated(newItem);
            this.context.Sh2PickAndPlace5307Shifts.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh2PickAndPlace5307Shifts.Where(i => i.RowID == key);
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
    public IActionResult PatchSh2PickAndPlace5307Shift(int key, [FromBody]Delta<Models.Sortimat.Sh2PickAndPlace5307Shift> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh2PickAndPlace5307Shifts.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh2PickAndPlace5307ShiftUpdated(item);
            this.context.Sh2PickAndPlace5307Shifts.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh2PickAndPlace5307Shifts.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh2PickAndPlace5307ShiftCreated(Models.Sortimat.Sh2PickAndPlace5307Shift item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh2PickAndPlace5307Shift item)
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

            this.OnSh2PickAndPlace5307ShiftCreated(item);
            this.context.Sh2PickAndPlace5307Shifts.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh2PickAndPlace5307Shifts/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
