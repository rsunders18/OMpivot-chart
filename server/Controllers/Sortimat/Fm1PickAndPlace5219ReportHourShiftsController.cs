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

  [ODataRoutePrefix("odata/Sortimat/Fm1PickAndPlace5219ReportHourShifts")]
  [Route("mvc/odata/Sortimat/Fm1PickAndPlace5219ReportHourShifts")]
  public partial class Fm1PickAndPlace5219ReportHourShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public Fm1PickAndPlace5219ReportHourShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm1PickAndPlace5219ReportHourShifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm1PickAndPlace5219ReportHourShift> GetFm1PickAndPlace5219ReportHourShifts()
    {
      var items = this.context.Fm1PickAndPlace5219ReportHourShifts.AsQueryable<Models.Sortimat.Fm1PickAndPlace5219ReportHourShift>();
      this.OnFm1PickAndPlace5219ReportHourShiftsRead(ref items);

      return items;
    }

    partial void OnFm1PickAndPlace5219ReportHourShiftsRead(ref IQueryable<Models.Sortimat.Fm1PickAndPlace5219ReportHourShift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm1PickAndPlace5219ReportHourShift> GetFm1PickAndPlace5219ReportHourShift(int key)
    {
        var items = this.context.Fm1PickAndPlace5219ReportHourShifts.Where(i=>i.RowID == key);
        this.OnFm1PickAndPlace5219ReportHourShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm1PickAndPlace5219ReportHourShiftsGet(ref IQueryable<Models.Sortimat.Fm1PickAndPlace5219ReportHourShift> items);

    partial void OnFm1PickAndPlace5219ReportHourShiftDeleted(Models.Sortimat.Fm1PickAndPlace5219ReportHourShift item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm1PickAndPlace5219ReportHourShift(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm1PickAndPlace5219ReportHourShifts
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm1PickAndPlace5219ReportHourShiftDeleted(item);
            this.context.Fm1PickAndPlace5219ReportHourShifts.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1PickAndPlace5219ReportHourShiftUpdated(Models.Sortimat.Fm1PickAndPlace5219ReportHourShift item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm1PickAndPlace5219ReportHourShift(int key, [FromBody]Models.Sortimat.Fm1PickAndPlace5219ReportHourShift newItem)
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

            this.OnFm1PickAndPlace5219ReportHourShiftUpdated(newItem);
            this.context.Fm1PickAndPlace5219ReportHourShifts.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1PickAndPlace5219ReportHourShifts.Where(i => i.RowID == key);
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
    public IActionResult PatchFm1PickAndPlace5219ReportHourShift(int key, [FromBody]Delta<Models.Sortimat.Fm1PickAndPlace5219ReportHourShift> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm1PickAndPlace5219ReportHourShifts.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm1PickAndPlace5219ReportHourShiftUpdated(item);
            this.context.Fm1PickAndPlace5219ReportHourShifts.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1PickAndPlace5219ReportHourShifts.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1PickAndPlace5219ReportHourShiftCreated(Models.Sortimat.Fm1PickAndPlace5219ReportHourShift item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm1PickAndPlace5219ReportHourShift item)
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

            this.OnFm1PickAndPlace5219ReportHourShiftCreated(item);
            this.context.Fm1PickAndPlace5219ReportHourShifts.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm1PickAndPlace5219ReportHourShifts/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
