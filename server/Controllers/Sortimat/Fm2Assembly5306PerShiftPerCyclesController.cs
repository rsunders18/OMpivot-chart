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

  [ODataRoutePrefix("odata/Sortimat/Fm2Assembly5306PerShiftPerCycles")]
  [Route("mvc/odata/Sortimat/Fm2Assembly5306PerShiftPerCycles")]
  public partial class Fm2Assembly5306PerShiftPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public Fm2Assembly5306PerShiftPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm2Assembly5306PerShiftPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm2Assembly5306PerShiftPerCycle> GetFm2Assembly5306PerShiftPerCycles()
    {
      var items = this.context.Fm2Assembly5306PerShiftPerCycles.AsQueryable<Models.Sortimat.Fm2Assembly5306PerShiftPerCycle>();
      this.OnFm2Assembly5306PerShiftPerCyclesRead(ref items);

      return items;
    }

    partial void OnFm2Assembly5306PerShiftPerCyclesRead(ref IQueryable<Models.Sortimat.Fm2Assembly5306PerShiftPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm2Assembly5306PerShiftPerCycle> GetFm2Assembly5306PerShiftPerCycle(int key)
    {
        var items = this.context.Fm2Assembly5306PerShiftPerCycles.Where(i=>i.RowID == key);
        this.OnFm2Assembly5306PerShiftPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm2Assembly5306PerShiftPerCyclesGet(ref IQueryable<Models.Sortimat.Fm2Assembly5306PerShiftPerCycle> items);

    partial void OnFm2Assembly5306PerShiftPerCycleDeleted(Models.Sortimat.Fm2Assembly5306PerShiftPerCycle item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm2Assembly5306PerShiftPerCycle(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm2Assembly5306PerShiftPerCycles
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm2Assembly5306PerShiftPerCycleDeleted(item);
            this.context.Fm2Assembly5306PerShiftPerCycles.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2Assembly5306PerShiftPerCycleUpdated(Models.Sortimat.Fm2Assembly5306PerShiftPerCycle item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm2Assembly5306PerShiftPerCycle(int key, [FromBody]Models.Sortimat.Fm2Assembly5306PerShiftPerCycle newItem)
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

            this.OnFm2Assembly5306PerShiftPerCycleUpdated(newItem);
            this.context.Fm2Assembly5306PerShiftPerCycles.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2Assembly5306PerShiftPerCycles.Where(i => i.RowID == key);
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
    public IActionResult PatchFm2Assembly5306PerShiftPerCycle(int key, [FromBody]Delta<Models.Sortimat.Fm2Assembly5306PerShiftPerCycle> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm2Assembly5306PerShiftPerCycles.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm2Assembly5306PerShiftPerCycleUpdated(item);
            this.context.Fm2Assembly5306PerShiftPerCycles.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2Assembly5306PerShiftPerCycles.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2Assembly5306PerShiftPerCycleCreated(Models.Sortimat.Fm2Assembly5306PerShiftPerCycle item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm2Assembly5306PerShiftPerCycle item)
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

            this.OnFm2Assembly5306PerShiftPerCycleCreated(item);
            this.context.Fm2Assembly5306PerShiftPerCycles.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm2Assembly5306PerShiftPerCycles/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
