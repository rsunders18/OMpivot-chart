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

  [ODataRoutePrefix("odata/Sortimat/Sh1Assembly5202PerBatchPerCycles")]
  [Route("mvc/odata/Sortimat/Sh1Assembly5202PerBatchPerCycles")]
  public partial class Sh1Assembly5202PerBatchPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public Sh1Assembly5202PerBatchPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh1Assembly5202PerBatchPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh1Assembly5202PerBatchPerCycle> GetSh1Assembly5202PerBatchPerCycles()
    {
      var items = this.context.Sh1Assembly5202PerBatchPerCycles.AsQueryable<Models.Sortimat.Sh1Assembly5202PerBatchPerCycle>();
      this.OnSh1Assembly5202PerBatchPerCyclesRead(ref items);

      return items;
    }

    partial void OnSh1Assembly5202PerBatchPerCyclesRead(ref IQueryable<Models.Sortimat.Sh1Assembly5202PerBatchPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Sh1Assembly5202PerBatchPerCycle> GetSh1Assembly5202PerBatchPerCycle(int key)
    {
        var items = this.context.Sh1Assembly5202PerBatchPerCycles.Where(i=>i.RowID == key);
        this.OnSh1Assembly5202PerBatchPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh1Assembly5202PerBatchPerCyclesGet(ref IQueryable<Models.Sortimat.Sh1Assembly5202PerBatchPerCycle> items);

    partial void OnSh1Assembly5202PerBatchPerCycleDeleted(Models.Sortimat.Sh1Assembly5202PerBatchPerCycle item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteSh1Assembly5202PerBatchPerCycle(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh1Assembly5202PerBatchPerCycles
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh1Assembly5202PerBatchPerCycleDeleted(item);
            this.context.Sh1Assembly5202PerBatchPerCycles.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1Assembly5202PerBatchPerCycleUpdated(Models.Sortimat.Sh1Assembly5202PerBatchPerCycle item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh1Assembly5202PerBatchPerCycle(int key, [FromBody]Models.Sortimat.Sh1Assembly5202PerBatchPerCycle newItem)
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

            this.OnSh1Assembly5202PerBatchPerCycleUpdated(newItem);
            this.context.Sh1Assembly5202PerBatchPerCycles.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1Assembly5202PerBatchPerCycles.Where(i => i.RowID == key);
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
    public IActionResult PatchSh1Assembly5202PerBatchPerCycle(int key, [FromBody]Delta<Models.Sortimat.Sh1Assembly5202PerBatchPerCycle> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh1Assembly5202PerBatchPerCycles.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh1Assembly5202PerBatchPerCycleUpdated(item);
            this.context.Sh1Assembly5202PerBatchPerCycles.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1Assembly5202PerBatchPerCycles.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1Assembly5202PerBatchPerCycleCreated(Models.Sortimat.Sh1Assembly5202PerBatchPerCycle item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh1Assembly5202PerBatchPerCycle item)
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

            this.OnSh1Assembly5202PerBatchPerCycleCreated(item);
            this.context.Sh1Assembly5202PerBatchPerCycles.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh1Assembly5202PerBatchPerCycles/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
