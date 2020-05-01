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

  [ODataRoutePrefix("odata/Sortimat/ShiftHourReports")]
  [Route("mvc/odata/Sortimat/ShiftHourReports")]
  public partial class ShiftHourReportsController : ODataController
  {
    private Data.SortimatContext context;

    public ShiftHourReportsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/ShiftHourReports
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.ShiftHourReport> GetShiftHourReports()
    {
      var items = this.context.ShiftHourReports.AsQueryable<Models.Sortimat.ShiftHourReport>();
      this.OnShiftHourReportsRead(ref items);

      return items;
    }

    partial void OnShiftHourReportsRead(ref IQueryable<Models.Sortimat.ShiftHourReport> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<ShiftHourReport> GetShiftHourReport(int key)
    {
        var items = this.context.ShiftHourReports.Where(i=>i.RowID == key);
        this.OnShiftHourReportsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnShiftHourReportsGet(ref IQueryable<Models.Sortimat.ShiftHourReport> items);

    partial void OnShiftHourReportDeleted(Models.Sortimat.ShiftHourReport item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteShiftHourReport(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.ShiftHourReports
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnShiftHourReportDeleted(item);
            this.context.ShiftHourReports.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnShiftHourReportUpdated(Models.Sortimat.ShiftHourReport item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutShiftHourReport(int key, [FromBody]Models.Sortimat.ShiftHourReport newItem)
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

            this.OnShiftHourReportUpdated(newItem);
            this.context.ShiftHourReports.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.ShiftHourReports.Where(i => i.RowID == key);
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
    public IActionResult PatchShiftHourReport(int key, [FromBody]Delta<Models.Sortimat.ShiftHourReport> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.ShiftHourReports.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnShiftHourReportUpdated(item);
            this.context.ShiftHourReports.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.ShiftHourReports.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnShiftHourReportCreated(Models.Sortimat.ShiftHourReport item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.ShiftHourReport item)
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

            this.OnShiftHourReportCreated(item);
            this.context.ShiftHourReports.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/ShiftHourReports/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
