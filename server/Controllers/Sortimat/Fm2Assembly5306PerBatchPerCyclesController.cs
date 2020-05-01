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

  [ODataRoutePrefix("odata/Sortimat/Fm2Assembly5306PerBatchPerCycles")]
  [Route("mvc/odata/Sortimat/Fm2Assembly5306PerBatchPerCycles")]
  public partial class Fm2Assembly5306PerBatchPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public Fm2Assembly5306PerBatchPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm2Assembly5306PerBatchPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm2Assembly5306PerBatchPerCycle> GetFm2Assembly5306PerBatchPerCycles()
    {
      var items = this.context.Fm2Assembly5306PerBatchPerCycles.AsQueryable<Models.Sortimat.Fm2Assembly5306PerBatchPerCycle>();
      this.OnFm2Assembly5306PerBatchPerCyclesRead(ref items);

      return items;
    }

    partial void OnFm2Assembly5306PerBatchPerCyclesRead(ref IQueryable<Models.Sortimat.Fm2Assembly5306PerBatchPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm2Assembly5306PerBatchPerCycle> GetFm2Assembly5306PerBatchPerCycle(int key)
    {
        var items = this.context.Fm2Assembly5306PerBatchPerCycles.Where(i=>i.RowID == key);
        this.OnFm2Assembly5306PerBatchPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm2Assembly5306PerBatchPerCyclesGet(ref IQueryable<Models.Sortimat.Fm2Assembly5306PerBatchPerCycle> items);

    partial void OnFm2Assembly5306PerBatchPerCycleDeleted(Models.Sortimat.Fm2Assembly5306PerBatchPerCycle item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm2Assembly5306PerBatchPerCycle(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm2Assembly5306PerBatchPerCycles
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm2Assembly5306PerBatchPerCycleDeleted(item);
            this.context.Fm2Assembly5306PerBatchPerCycles.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2Assembly5306PerBatchPerCycleUpdated(Models.Sortimat.Fm2Assembly5306PerBatchPerCycle item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm2Assembly5306PerBatchPerCycle(int key, [FromBody]Models.Sortimat.Fm2Assembly5306PerBatchPerCycle newItem)
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

            this.OnFm2Assembly5306PerBatchPerCycleUpdated(newItem);
            this.context.Fm2Assembly5306PerBatchPerCycles.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2Assembly5306PerBatchPerCycles.Where(i => i.RowID == key);
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
    public IActionResult PatchFm2Assembly5306PerBatchPerCycle(int key, [FromBody]Delta<Models.Sortimat.Fm2Assembly5306PerBatchPerCycle> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm2Assembly5306PerBatchPerCycles.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm2Assembly5306PerBatchPerCycleUpdated(item);
            this.context.Fm2Assembly5306PerBatchPerCycles.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2Assembly5306PerBatchPerCycles.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2Assembly5306PerBatchPerCycleCreated(Models.Sortimat.Fm2Assembly5306PerBatchPerCycle item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm2Assembly5306PerBatchPerCycle item)
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

            this.OnFm2Assembly5306PerBatchPerCycleCreated(item);
            this.context.Fm2Assembly5306PerBatchPerCycles.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm2Assembly5306PerBatchPerCycles/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
