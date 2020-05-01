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

  [ODataRoutePrefix("odata/Sortimat/Sh2Assembly5308Shifts")]
  [Route("mvc/odata/Sortimat/Sh2Assembly5308Shifts")]
  public partial class Sh2Assembly5308ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public Sh2Assembly5308ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh2Assembly5308Shifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh2Assembly5308Shift> GetSh2Assembly5308Shifts()
    {
      var items = this.context.Sh2Assembly5308Shifts.AsQueryable<Models.Sortimat.Sh2Assembly5308Shift>();
      this.OnSh2Assembly5308ShiftsRead(ref items);

      return items;
    }

    partial void OnSh2Assembly5308ShiftsRead(ref IQueryable<Models.Sortimat.Sh2Assembly5308Shift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Sh2Assembly5308Shift> GetSh2Assembly5308Shift(int key)
    {
        var items = this.context.Sh2Assembly5308Shifts.Where(i=>i.RowID == key);
        this.OnSh2Assembly5308ShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh2Assembly5308ShiftsGet(ref IQueryable<Models.Sortimat.Sh2Assembly5308Shift> items);

    partial void OnSh2Assembly5308ShiftDeleted(Models.Sortimat.Sh2Assembly5308Shift item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteSh2Assembly5308Shift(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh2Assembly5308Shifts
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh2Assembly5308ShiftDeleted(item);
            this.context.Sh2Assembly5308Shifts.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh2Assembly5308ShiftUpdated(Models.Sortimat.Sh2Assembly5308Shift item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh2Assembly5308Shift(int key, [FromBody]Models.Sortimat.Sh2Assembly5308Shift newItem)
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

            this.OnSh2Assembly5308ShiftUpdated(newItem);
            this.context.Sh2Assembly5308Shifts.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh2Assembly5308Shifts.Where(i => i.RowID == key);
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
    public IActionResult PatchSh2Assembly5308Shift(int key, [FromBody]Delta<Models.Sortimat.Sh2Assembly5308Shift> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh2Assembly5308Shifts.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh2Assembly5308ShiftUpdated(item);
            this.context.Sh2Assembly5308Shifts.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh2Assembly5308Shifts.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh2Assembly5308ShiftCreated(Models.Sortimat.Sh2Assembly5308Shift item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh2Assembly5308Shift item)
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

            this.OnSh2Assembly5308ShiftCreated(item);
            this.context.Sh2Assembly5308Shifts.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh2Assembly5308Shifts/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
