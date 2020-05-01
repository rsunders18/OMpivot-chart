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

  [ODataRoutePrefix("odata/Sortimat/Fm1AssemblyReportHourShifts")]
  [Route("mvc/odata/Sortimat/Fm1AssemblyReportHourShifts")]
  public partial class Fm1AssemblyReportHourShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public Fm1AssemblyReportHourShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm1AssemblyReportHourShifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm1AssemblyReportHourShift> GetFm1AssemblyReportHourShifts()
    {
      var items = this.context.Fm1AssemblyReportHourShifts.AsQueryable<Models.Sortimat.Fm1AssemblyReportHourShift>();
      this.OnFm1AssemblyReportHourShiftsRead(ref items);

      return items;
    }

    partial void OnFm1AssemblyReportHourShiftsRead(ref IQueryable<Models.Sortimat.Fm1AssemblyReportHourShift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm1AssemblyReportHourShift> GetFm1AssemblyReportHourShift(int key)
    {
        var items = this.context.Fm1AssemblyReportHourShifts.Where(i=>i.RowID == key);
        this.OnFm1AssemblyReportHourShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm1AssemblyReportHourShiftsGet(ref IQueryable<Models.Sortimat.Fm1AssemblyReportHourShift> items);

    partial void OnFm1AssemblyReportHourShiftDeleted(Models.Sortimat.Fm1AssemblyReportHourShift item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm1AssemblyReportHourShift(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm1AssemblyReportHourShifts
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm1AssemblyReportHourShiftDeleted(item);
            this.context.Fm1AssemblyReportHourShifts.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1AssemblyReportHourShiftUpdated(Models.Sortimat.Fm1AssemblyReportHourShift item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm1AssemblyReportHourShift(int key, [FromBody]Models.Sortimat.Fm1AssemblyReportHourShift newItem)
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

            this.OnFm1AssemblyReportHourShiftUpdated(newItem);
            this.context.Fm1AssemblyReportHourShifts.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1AssemblyReportHourShifts.Where(i => i.RowID == key);
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
    public IActionResult PatchFm1AssemblyReportHourShift(int key, [FromBody]Delta<Models.Sortimat.Fm1AssemblyReportHourShift> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm1AssemblyReportHourShifts.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm1AssemblyReportHourShiftUpdated(item);
            this.context.Fm1AssemblyReportHourShifts.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1AssemblyReportHourShifts.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1AssemblyReportHourShiftCreated(Models.Sortimat.Fm1AssemblyReportHourShift item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm1AssemblyReportHourShift item)
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

            this.OnFm1AssemblyReportHourShiftCreated(item);
            this.context.Fm1AssemblyReportHourShifts.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm1AssemblyReportHourShifts/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
