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

  [ODataRoutePrefix("odata/Sortimat/Sh1Assembly5202Shifts")]
  [Route("mvc/odata/Sortimat/Sh1Assembly5202Shifts")]
  public partial class Sh1Assembly5202ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public Sh1Assembly5202ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh1Assembly5202Shifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh1Assembly5202Shift> GetSh1Assembly5202Shifts()
    {
      var items = this.context.Sh1Assembly5202Shifts.AsQueryable<Models.Sortimat.Sh1Assembly5202Shift>();
      this.OnSh1Assembly5202ShiftsRead(ref items);

      return items;
    }

    partial void OnSh1Assembly5202ShiftsRead(ref IQueryable<Models.Sortimat.Sh1Assembly5202Shift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Sh1Assembly5202Shift> GetSh1Assembly5202Shift(int key)
    {
        var items = this.context.Sh1Assembly5202Shifts.Where(i=>i.RowID == key);
        this.OnSh1Assembly5202ShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh1Assembly5202ShiftsGet(ref IQueryable<Models.Sortimat.Sh1Assembly5202Shift> items);

    partial void OnSh1Assembly5202ShiftDeleted(Models.Sortimat.Sh1Assembly5202Shift item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteSh1Assembly5202Shift(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh1Assembly5202Shifts
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh1Assembly5202ShiftDeleted(item);
            this.context.Sh1Assembly5202Shifts.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1Assembly5202ShiftUpdated(Models.Sortimat.Sh1Assembly5202Shift item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh1Assembly5202Shift(int key, [FromBody]Models.Sortimat.Sh1Assembly5202Shift newItem)
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

            this.OnSh1Assembly5202ShiftUpdated(newItem);
            this.context.Sh1Assembly5202Shifts.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1Assembly5202Shifts.Where(i => i.RowID == key);
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
    public IActionResult PatchSh1Assembly5202Shift(int key, [FromBody]Delta<Models.Sortimat.Sh1Assembly5202Shift> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh1Assembly5202Shifts.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh1Assembly5202ShiftUpdated(item);
            this.context.Sh1Assembly5202Shifts.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1Assembly5202Shifts.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1Assembly5202ShiftCreated(Models.Sortimat.Sh1Assembly5202Shift item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh1Assembly5202Shift item)
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

            this.OnSh1Assembly5202ShiftCreated(item);
            this.context.Sh1Assembly5202Shifts.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh1Assembly5202Shifts/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
