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

  [ODataRoutePrefix("odata/Sortimat/Fm2Assembly5306Shifts")]
  [Route("mvc/odata/Sortimat/Fm2Assembly5306Shifts")]
  public partial class Fm2Assembly5306ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public Fm2Assembly5306ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm2Assembly5306Shifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm2Assembly5306Shift> GetFm2Assembly5306Shifts()
    {
      var items = this.context.Fm2Assembly5306Shifts.AsQueryable<Models.Sortimat.Fm2Assembly5306Shift>();
      this.OnFm2Assembly5306ShiftsRead(ref items);

      return items;
    }

    partial void OnFm2Assembly5306ShiftsRead(ref IQueryable<Models.Sortimat.Fm2Assembly5306Shift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm2Assembly5306Shift> GetFm2Assembly5306Shift(int key)
    {
        var items = this.context.Fm2Assembly5306Shifts.Where(i=>i.RowID == key);
        this.OnFm2Assembly5306ShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm2Assembly5306ShiftsGet(ref IQueryable<Models.Sortimat.Fm2Assembly5306Shift> items);

    partial void OnFm2Assembly5306ShiftDeleted(Models.Sortimat.Fm2Assembly5306Shift item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm2Assembly5306Shift(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm2Assembly5306Shifts
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm2Assembly5306ShiftDeleted(item);
            this.context.Fm2Assembly5306Shifts.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2Assembly5306ShiftUpdated(Models.Sortimat.Fm2Assembly5306Shift item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm2Assembly5306Shift(int key, [FromBody]Models.Sortimat.Fm2Assembly5306Shift newItem)
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

            this.OnFm2Assembly5306ShiftUpdated(newItem);
            this.context.Fm2Assembly5306Shifts.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2Assembly5306Shifts.Where(i => i.RowID == key);
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
    public IActionResult PatchFm2Assembly5306Shift(int key, [FromBody]Delta<Models.Sortimat.Fm2Assembly5306Shift> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm2Assembly5306Shifts.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm2Assembly5306ShiftUpdated(item);
            this.context.Fm2Assembly5306Shifts.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2Assembly5306Shifts.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2Assembly5306ShiftCreated(Models.Sortimat.Fm2Assembly5306Shift item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm2Assembly5306Shift item)
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

            this.OnFm2Assembly5306ShiftCreated(item);
            this.context.Fm2Assembly5306Shifts.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm2Assembly5306Shifts/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
