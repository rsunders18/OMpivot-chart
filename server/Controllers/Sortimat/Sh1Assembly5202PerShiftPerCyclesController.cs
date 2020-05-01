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

  [ODataRoutePrefix("odata/Sortimat/Sh1Assembly5202PerShiftPerCycles")]
  [Route("mvc/odata/Sortimat/Sh1Assembly5202PerShiftPerCycles")]
  public partial class Sh1Assembly5202PerShiftPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public Sh1Assembly5202PerShiftPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh1Assembly5202PerShiftPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh1Assembly5202PerShiftPerCycle> GetSh1Assembly5202PerShiftPerCycles()
    {
      var items = this.context.Sh1Assembly5202PerShiftPerCycles.AsQueryable<Models.Sortimat.Sh1Assembly5202PerShiftPerCycle>();
      this.OnSh1Assembly5202PerShiftPerCyclesRead(ref items);

      return items;
    }

    partial void OnSh1Assembly5202PerShiftPerCyclesRead(ref IQueryable<Models.Sortimat.Sh1Assembly5202PerShiftPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Sh1Assembly5202PerShiftPerCycle> GetSh1Assembly5202PerShiftPerCycle(int key)
    {
        var items = this.context.Sh1Assembly5202PerShiftPerCycles.Where(i=>i.RowID == key);
        this.OnSh1Assembly5202PerShiftPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh1Assembly5202PerShiftPerCyclesGet(ref IQueryable<Models.Sortimat.Sh1Assembly5202PerShiftPerCycle> items);

    partial void OnSh1Assembly5202PerShiftPerCycleDeleted(Models.Sortimat.Sh1Assembly5202PerShiftPerCycle item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteSh1Assembly5202PerShiftPerCycle(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh1Assembly5202PerShiftPerCycles
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh1Assembly5202PerShiftPerCycleDeleted(item);
            this.context.Sh1Assembly5202PerShiftPerCycles.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1Assembly5202PerShiftPerCycleUpdated(Models.Sortimat.Sh1Assembly5202PerShiftPerCycle item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh1Assembly5202PerShiftPerCycle(int key, [FromBody]Models.Sortimat.Sh1Assembly5202PerShiftPerCycle newItem)
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

            this.OnSh1Assembly5202PerShiftPerCycleUpdated(newItem);
            this.context.Sh1Assembly5202PerShiftPerCycles.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1Assembly5202PerShiftPerCycles.Where(i => i.RowID == key);
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
    public IActionResult PatchSh1Assembly5202PerShiftPerCycle(int key, [FromBody]Delta<Models.Sortimat.Sh1Assembly5202PerShiftPerCycle> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh1Assembly5202PerShiftPerCycles.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh1Assembly5202PerShiftPerCycleUpdated(item);
            this.context.Sh1Assembly5202PerShiftPerCycles.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1Assembly5202PerShiftPerCycles.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1Assembly5202PerShiftPerCycleCreated(Models.Sortimat.Sh1Assembly5202PerShiftPerCycle item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh1Assembly5202PerShiftPerCycle item)
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

            this.OnSh1Assembly5202PerShiftPerCycleCreated(item);
            this.context.Sh1Assembly5202PerShiftPerCycles.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh1Assembly5202PerShiftPerCycles/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
