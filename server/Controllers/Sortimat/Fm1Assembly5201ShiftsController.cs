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

  [ODataRoutePrefix("odata/Sortimat/Fm1Assembly5201Shifts")]
  [Route("mvc/odata/Sortimat/Fm1Assembly5201Shifts")]
  public partial class Fm1Assembly5201ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public Fm1Assembly5201ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm1Assembly5201Shifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm1Assembly5201Shift> GetFm1Assembly5201Shifts()
    {
      var items = this.context.Fm1Assembly5201Shifts.AsQueryable<Models.Sortimat.Fm1Assembly5201Shift>();
      this.OnFm1Assembly5201ShiftsRead(ref items);

      return items;
    }

    partial void OnFm1Assembly5201ShiftsRead(ref IQueryable<Models.Sortimat.Fm1Assembly5201Shift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm1Assembly5201Shift> GetFm1Assembly5201Shift(int key)
    {
        var items = this.context.Fm1Assembly5201Shifts.Where(i=>i.RowID == key);
        this.OnFm1Assembly5201ShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm1Assembly5201ShiftsGet(ref IQueryable<Models.Sortimat.Fm1Assembly5201Shift> items);

    partial void OnFm1Assembly5201ShiftDeleted(Models.Sortimat.Fm1Assembly5201Shift item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm1Assembly5201Shift(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm1Assembly5201Shifts
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm1Assembly5201ShiftDeleted(item);
            this.context.Fm1Assembly5201Shifts.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1Assembly5201ShiftUpdated(Models.Sortimat.Fm1Assembly5201Shift item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm1Assembly5201Shift(int key, [FromBody]Models.Sortimat.Fm1Assembly5201Shift newItem)
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

            this.OnFm1Assembly5201ShiftUpdated(newItem);
            this.context.Fm1Assembly5201Shifts.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1Assembly5201Shifts.Where(i => i.RowID == key);
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
    public IActionResult PatchFm1Assembly5201Shift(int key, [FromBody]Delta<Models.Sortimat.Fm1Assembly5201Shift> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm1Assembly5201Shifts.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm1Assembly5201ShiftUpdated(item);
            this.context.Fm1Assembly5201Shifts.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1Assembly5201Shifts.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1Assembly5201ShiftCreated(Models.Sortimat.Fm1Assembly5201Shift item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm1Assembly5201Shift item)
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

            this.OnFm1Assembly5201ShiftCreated(item);
            this.context.Fm1Assembly5201Shifts.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm1Assembly5201Shifts/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
