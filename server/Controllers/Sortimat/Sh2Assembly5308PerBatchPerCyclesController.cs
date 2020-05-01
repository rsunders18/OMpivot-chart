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

  [ODataRoutePrefix("odata/Sortimat/Sh2Assembly5308PerBatchPerCycles")]
  [Route("mvc/odata/Sortimat/Sh2Assembly5308PerBatchPerCycles")]
  public partial class Sh2Assembly5308PerBatchPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public Sh2Assembly5308PerBatchPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh2Assembly5308PerBatchPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh2Assembly5308PerBatchPerCycle> GetSh2Assembly5308PerBatchPerCycles()
    {
      var items = this.context.Sh2Assembly5308PerBatchPerCycles.AsQueryable<Models.Sortimat.Sh2Assembly5308PerBatchPerCycle>();
      this.OnSh2Assembly5308PerBatchPerCyclesRead(ref items);

      return items;
    }

    partial void OnSh2Assembly5308PerBatchPerCyclesRead(ref IQueryable<Models.Sortimat.Sh2Assembly5308PerBatchPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Sh2Assembly5308PerBatchPerCycle> GetSh2Assembly5308PerBatchPerCycle(int key)
    {
        var items = this.context.Sh2Assembly5308PerBatchPerCycles.Where(i=>i.RowID == key);
        this.OnSh2Assembly5308PerBatchPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh2Assembly5308PerBatchPerCyclesGet(ref IQueryable<Models.Sortimat.Sh2Assembly5308PerBatchPerCycle> items);

    partial void OnSh2Assembly5308PerBatchPerCycleDeleted(Models.Sortimat.Sh2Assembly5308PerBatchPerCycle item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteSh2Assembly5308PerBatchPerCycle(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh2Assembly5308PerBatchPerCycles
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh2Assembly5308PerBatchPerCycleDeleted(item);
            this.context.Sh2Assembly5308PerBatchPerCycles.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh2Assembly5308PerBatchPerCycleUpdated(Models.Sortimat.Sh2Assembly5308PerBatchPerCycle item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh2Assembly5308PerBatchPerCycle(int key, [FromBody]Models.Sortimat.Sh2Assembly5308PerBatchPerCycle newItem)
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

            this.OnSh2Assembly5308PerBatchPerCycleUpdated(newItem);
            this.context.Sh2Assembly5308PerBatchPerCycles.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh2Assembly5308PerBatchPerCycles.Where(i => i.RowID == key);
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
    public IActionResult PatchSh2Assembly5308PerBatchPerCycle(int key, [FromBody]Delta<Models.Sortimat.Sh2Assembly5308PerBatchPerCycle> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh2Assembly5308PerBatchPerCycles.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh2Assembly5308PerBatchPerCycleUpdated(item);
            this.context.Sh2Assembly5308PerBatchPerCycles.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh2Assembly5308PerBatchPerCycles.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh2Assembly5308PerBatchPerCycleCreated(Models.Sortimat.Sh2Assembly5308PerBatchPerCycle item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh2Assembly5308PerBatchPerCycle item)
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

            this.OnSh2Assembly5308PerBatchPerCycleCreated(item);
            this.context.Sh2Assembly5308PerBatchPerCycles.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh2Assembly5308PerBatchPerCycles/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
