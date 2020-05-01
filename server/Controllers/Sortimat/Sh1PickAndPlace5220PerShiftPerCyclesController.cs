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

  [ODataRoutePrefix("odata/Sortimat/Sh1PickAndPlace5220PerShiftPerCycles")]
  [Route("mvc/odata/Sortimat/Sh1PickAndPlace5220PerShiftPerCycles")]
  public partial class Sh1PickAndPlace5220PerShiftPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public Sh1PickAndPlace5220PerShiftPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh1PickAndPlace5220PerShiftPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle> GetSh1PickAndPlace5220PerShiftPerCycles()
    {
      var items = this.context.Sh1PickAndPlace5220PerShiftPerCycles.AsQueryable<Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle>();
      this.OnSh1PickAndPlace5220PerShiftPerCyclesRead(ref items);

      return items;
    }

    partial void OnSh1PickAndPlace5220PerShiftPerCyclesRead(ref IQueryable<Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Sh1PickAndPlace5220PerShiftPerCycle> GetSh1PickAndPlace5220PerShiftPerCycle(int key)
    {
        var items = this.context.Sh1PickAndPlace5220PerShiftPerCycles.Where(i=>i.RowID == key);
        this.OnSh1PickAndPlace5220PerShiftPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh1PickAndPlace5220PerShiftPerCyclesGet(ref IQueryable<Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle> items);

    partial void OnSh1PickAndPlace5220PerShiftPerCycleDeleted(Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteSh1PickAndPlace5220PerShiftPerCycle(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh1PickAndPlace5220PerShiftPerCycles
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh1PickAndPlace5220PerShiftPerCycleDeleted(item);
            this.context.Sh1PickAndPlace5220PerShiftPerCycles.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1PickAndPlace5220PerShiftPerCycleUpdated(Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh1PickAndPlace5220PerShiftPerCycle(int key, [FromBody]Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle newItem)
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

            this.OnSh1PickAndPlace5220PerShiftPerCycleUpdated(newItem);
            this.context.Sh1PickAndPlace5220PerShiftPerCycles.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1PickAndPlace5220PerShiftPerCycles.Where(i => i.RowID == key);
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
    public IActionResult PatchSh1PickAndPlace5220PerShiftPerCycle(int key, [FromBody]Delta<Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh1PickAndPlace5220PerShiftPerCycles.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh1PickAndPlace5220PerShiftPerCycleUpdated(item);
            this.context.Sh1PickAndPlace5220PerShiftPerCycles.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1PickAndPlace5220PerShiftPerCycles.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1PickAndPlace5220PerShiftPerCycleCreated(Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle item)
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

            this.OnSh1PickAndPlace5220PerShiftPerCycleCreated(item);
            this.context.Sh1PickAndPlace5220PerShiftPerCycles.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh1PickAndPlace5220PerShiftPerCycles/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
