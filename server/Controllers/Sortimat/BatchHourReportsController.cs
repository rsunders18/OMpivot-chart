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

  [ODataRoutePrefix("odata/Sortimat/BatchHourReports")]
  [Route("mvc/odata/Sortimat/BatchHourReports")]
  public partial class BatchHourReportsController : ODataController
  {
    private Data.SortimatContext context;

    public BatchHourReportsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/BatchHourReports
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.BatchHourReport> GetBatchHourReports()
    {
      var items = this.context.BatchHourReports.AsQueryable<Models.Sortimat.BatchHourReport>();
      this.OnBatchHourReportsRead(ref items);

      return items;
    }

    partial void OnBatchHourReportsRead(ref IQueryable<Models.Sortimat.BatchHourReport> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<BatchHourReport> GetBatchHourReport(int key)
    {
        var items = this.context.BatchHourReports.Where(i=>i.RowID == key);
        this.OnBatchHourReportsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnBatchHourReportsGet(ref IQueryable<Models.Sortimat.BatchHourReport> items);

    partial void OnBatchHourReportDeleted(Models.Sortimat.BatchHourReport item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteBatchHourReport(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.BatchHourReports
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnBatchHourReportDeleted(item);
            this.context.BatchHourReports.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnBatchHourReportUpdated(Models.Sortimat.BatchHourReport item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutBatchHourReport(int key, [FromBody]Models.Sortimat.BatchHourReport newItem)
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

            this.OnBatchHourReportUpdated(newItem);
            this.context.BatchHourReports.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.BatchHourReports.Where(i => i.RowID == key);
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
    public IActionResult PatchBatchHourReport(int key, [FromBody]Delta<Models.Sortimat.BatchHourReport> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.BatchHourReports.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnBatchHourReportUpdated(item);
            this.context.BatchHourReports.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.BatchHourReports.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnBatchHourReportCreated(Models.Sortimat.BatchHourReport item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.BatchHourReport item)
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

            this.OnBatchHourReportCreated(item);
            this.context.BatchHourReports.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/BatchHourReports/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
