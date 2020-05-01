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

  [ODataRoutePrefix("odata/Sortimat/Sh1PickAndPlace5220PerBatchPerCycles")]
  [Route("mvc/odata/Sortimat/Sh1PickAndPlace5220PerBatchPerCycles")]
  public partial class Sh1PickAndPlace5220PerBatchPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public Sh1PickAndPlace5220PerBatchPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh1PickAndPlace5220PerBatchPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle> GetSh1PickAndPlace5220PerBatchPerCycles()
    {
      var items = this.context.Sh1PickAndPlace5220PerBatchPerCycles.AsQueryable<Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle>();
      this.OnSh1PickAndPlace5220PerBatchPerCyclesRead(ref items);

      return items;
    }

    partial void OnSh1PickAndPlace5220PerBatchPerCyclesRead(ref IQueryable<Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Sh1PickAndPlace5220PerBatchPerCycle> GetSh1PickAndPlace5220PerBatchPerCycle(int key)
    {
        var items = this.context.Sh1PickAndPlace5220PerBatchPerCycles.Where(i=>i.RowID == key);
        this.OnSh1PickAndPlace5220PerBatchPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh1PickAndPlace5220PerBatchPerCyclesGet(ref IQueryable<Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle> items);

    partial void OnSh1PickAndPlace5220PerBatchPerCycleDeleted(Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteSh1PickAndPlace5220PerBatchPerCycle(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh1PickAndPlace5220PerBatchPerCycles
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh1PickAndPlace5220PerBatchPerCycleDeleted(item);
            this.context.Sh1PickAndPlace5220PerBatchPerCycles.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1PickAndPlace5220PerBatchPerCycleUpdated(Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh1PickAndPlace5220PerBatchPerCycle(int key, [FromBody]Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle newItem)
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

            this.OnSh1PickAndPlace5220PerBatchPerCycleUpdated(newItem);
            this.context.Sh1PickAndPlace5220PerBatchPerCycles.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1PickAndPlace5220PerBatchPerCycles.Where(i => i.RowID == key);
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
    public IActionResult PatchSh1PickAndPlace5220PerBatchPerCycle(int key, [FromBody]Delta<Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh1PickAndPlace5220PerBatchPerCycles.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh1PickAndPlace5220PerBatchPerCycleUpdated(item);
            this.context.Sh1PickAndPlace5220PerBatchPerCycles.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1PickAndPlace5220PerBatchPerCycles.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1PickAndPlace5220PerBatchPerCycleCreated(Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle item)
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

            this.OnSh1PickAndPlace5220PerBatchPerCycleCreated(item);
            this.context.Sh1PickAndPlace5220PerBatchPerCycles.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh1PickAndPlace5220PerBatchPerCycles/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
