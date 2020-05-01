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

  [ODataRoutePrefix("odata/Sortimat/Fm1PickAndPlace5219PerShiftPerCycles")]
  [Route("mvc/odata/Sortimat/Fm1PickAndPlace5219PerShiftPerCycles")]
  public partial class Fm1PickAndPlace5219PerShiftPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public Fm1PickAndPlace5219PerShiftPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm1PickAndPlace5219PerShiftPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle> GetFm1PickAndPlace5219PerShiftPerCycles()
    {
      var items = this.context.Fm1PickAndPlace5219PerShiftPerCycles.AsQueryable<Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle>();
      this.OnFm1PickAndPlace5219PerShiftPerCyclesRead(ref items);

      return items;
    }

    partial void OnFm1PickAndPlace5219PerShiftPerCyclesRead(ref IQueryable<Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm1PickAndPlace5219PerShiftPerCycle> GetFm1PickAndPlace5219PerShiftPerCycle(int key)
    {
        var items = this.context.Fm1PickAndPlace5219PerShiftPerCycles.Where(i=>i.RowID == key);
        this.OnFm1PickAndPlace5219PerShiftPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm1PickAndPlace5219PerShiftPerCyclesGet(ref IQueryable<Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle> items);

    partial void OnFm1PickAndPlace5219PerShiftPerCycleDeleted(Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm1PickAndPlace5219PerShiftPerCycle(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm1PickAndPlace5219PerShiftPerCycles
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm1PickAndPlace5219PerShiftPerCycleDeleted(item);
            this.context.Fm1PickAndPlace5219PerShiftPerCycles.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1PickAndPlace5219PerShiftPerCycleUpdated(Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm1PickAndPlace5219PerShiftPerCycle(int key, [FromBody]Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle newItem)
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

            this.OnFm1PickAndPlace5219PerShiftPerCycleUpdated(newItem);
            this.context.Fm1PickAndPlace5219PerShiftPerCycles.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1PickAndPlace5219PerShiftPerCycles.Where(i => i.RowID == key);
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
    public IActionResult PatchFm1PickAndPlace5219PerShiftPerCycle(int key, [FromBody]Delta<Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm1PickAndPlace5219PerShiftPerCycles.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm1PickAndPlace5219PerShiftPerCycleUpdated(item);
            this.context.Fm1PickAndPlace5219PerShiftPerCycles.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1PickAndPlace5219PerShiftPerCycles.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1PickAndPlace5219PerShiftPerCycleCreated(Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle item)
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

            this.OnFm1PickAndPlace5219PerShiftPerCycleCreated(item);
            this.context.Fm1PickAndPlace5219PerShiftPerCycles.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm1PickAndPlace5219PerShiftPerCycles/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
