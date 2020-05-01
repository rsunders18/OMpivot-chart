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

  [ODataRoutePrefix("odata/Sortimat/Fm2PickAndPlace5305PerShiftPerCycles")]
  [Route("mvc/odata/Sortimat/Fm2PickAndPlace5305PerShiftPerCycles")]
  public partial class Fm2PickAndPlace5305PerShiftPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public Fm2PickAndPlace5305PerShiftPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm2PickAndPlace5305PerShiftPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle> GetFm2PickAndPlace5305PerShiftPerCycles()
    {
      var items = this.context.Fm2PickAndPlace5305PerShiftPerCycles.AsQueryable<Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle>();
      this.OnFm2PickAndPlace5305PerShiftPerCyclesRead(ref items);

      return items;
    }

    partial void OnFm2PickAndPlace5305PerShiftPerCyclesRead(ref IQueryable<Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm2PickAndPlace5305PerShiftPerCycle> GetFm2PickAndPlace5305PerShiftPerCycle(int key)
    {
        var items = this.context.Fm2PickAndPlace5305PerShiftPerCycles.Where(i=>i.RowID == key);
        this.OnFm2PickAndPlace5305PerShiftPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm2PickAndPlace5305PerShiftPerCyclesGet(ref IQueryable<Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle> items);

    partial void OnFm2PickAndPlace5305PerShiftPerCycleDeleted(Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm2PickAndPlace5305PerShiftPerCycle(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm2PickAndPlace5305PerShiftPerCycles
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm2PickAndPlace5305PerShiftPerCycleDeleted(item);
            this.context.Fm2PickAndPlace5305PerShiftPerCycles.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2PickAndPlace5305PerShiftPerCycleUpdated(Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm2PickAndPlace5305PerShiftPerCycle(int key, [FromBody]Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle newItem)
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

            this.OnFm2PickAndPlace5305PerShiftPerCycleUpdated(newItem);
            this.context.Fm2PickAndPlace5305PerShiftPerCycles.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2PickAndPlace5305PerShiftPerCycles.Where(i => i.RowID == key);
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
    public IActionResult PatchFm2PickAndPlace5305PerShiftPerCycle(int key, [FromBody]Delta<Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm2PickAndPlace5305PerShiftPerCycles.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm2PickAndPlace5305PerShiftPerCycleUpdated(item);
            this.context.Fm2PickAndPlace5305PerShiftPerCycles.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2PickAndPlace5305PerShiftPerCycles.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2PickAndPlace5305PerShiftPerCycleCreated(Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle item)
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

            this.OnFm2PickAndPlace5305PerShiftPerCycleCreated(item);
            this.context.Fm2PickAndPlace5305PerShiftPerCycles.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm2PickAndPlace5305PerShiftPerCycles/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
