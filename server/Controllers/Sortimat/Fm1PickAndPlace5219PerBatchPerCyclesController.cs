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

  [ODataRoutePrefix("odata/Sortimat/Fm1PickAndPlace5219PerBatchPerCycles")]
  [Route("mvc/odata/Sortimat/Fm1PickAndPlace5219PerBatchPerCycles")]
  public partial class Fm1PickAndPlace5219PerBatchPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public Fm1PickAndPlace5219PerBatchPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm1PickAndPlace5219PerBatchPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle> GetFm1PickAndPlace5219PerBatchPerCycles()
    {
      var items = this.context.Fm1PickAndPlace5219PerBatchPerCycles.AsQueryable<Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle>();
      this.OnFm1PickAndPlace5219PerBatchPerCyclesRead(ref items);

      return items;
    }

    partial void OnFm1PickAndPlace5219PerBatchPerCyclesRead(ref IQueryable<Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm1PickAndPlace5219PerBatchPerCycle> GetFm1PickAndPlace5219PerBatchPerCycle(int key)
    {
        var items = this.context.Fm1PickAndPlace5219PerBatchPerCycles.Where(i=>i.RowID == key);
        this.OnFm1PickAndPlace5219PerBatchPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm1PickAndPlace5219PerBatchPerCyclesGet(ref IQueryable<Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle> items);

    partial void OnFm1PickAndPlace5219PerBatchPerCycleDeleted(Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm1PickAndPlace5219PerBatchPerCycle(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm1PickAndPlace5219PerBatchPerCycles
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm1PickAndPlace5219PerBatchPerCycleDeleted(item);
            this.context.Fm1PickAndPlace5219PerBatchPerCycles.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1PickAndPlace5219PerBatchPerCycleUpdated(Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm1PickAndPlace5219PerBatchPerCycle(int key, [FromBody]Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle newItem)
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

            this.OnFm1PickAndPlace5219PerBatchPerCycleUpdated(newItem);
            this.context.Fm1PickAndPlace5219PerBatchPerCycles.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1PickAndPlace5219PerBatchPerCycles.Where(i => i.RowID == key);
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
    public IActionResult PatchFm1PickAndPlace5219PerBatchPerCycle(int key, [FromBody]Delta<Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm1PickAndPlace5219PerBatchPerCycles.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm1PickAndPlace5219PerBatchPerCycleUpdated(item);
            this.context.Fm1PickAndPlace5219PerBatchPerCycles.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1PickAndPlace5219PerBatchPerCycles.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1PickAndPlace5219PerBatchPerCycleCreated(Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle item)
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

            this.OnFm1PickAndPlace5219PerBatchPerCycleCreated(item);
            this.context.Fm1PickAndPlace5219PerBatchPerCycles.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm1PickAndPlace5219PerBatchPerCycles/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
