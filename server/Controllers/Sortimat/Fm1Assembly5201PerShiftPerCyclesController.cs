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

  [ODataRoutePrefix("odata/Sortimat/Fm1Assembly5201PerShiftPerCycles")]
  [Route("mvc/odata/Sortimat/Fm1Assembly5201PerShiftPerCycles")]
  public partial class Fm1Assembly5201PerShiftPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public Fm1Assembly5201PerShiftPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm1Assembly5201PerShiftPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm1Assembly5201PerShiftPerCycle> GetFm1Assembly5201PerShiftPerCycles()
    {
      var items = this.context.Fm1Assembly5201PerShiftPerCycles.AsQueryable<Models.Sortimat.Fm1Assembly5201PerShiftPerCycle>();
      this.OnFm1Assembly5201PerShiftPerCyclesRead(ref items);

      return items;
    }

    partial void OnFm1Assembly5201PerShiftPerCyclesRead(ref IQueryable<Models.Sortimat.Fm1Assembly5201PerShiftPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm1Assembly5201PerShiftPerCycle> GetFm1Assembly5201PerShiftPerCycle(int key)
    {
        var items = this.context.Fm1Assembly5201PerShiftPerCycles.Where(i=>i.RowID == key);
        this.OnFm1Assembly5201PerShiftPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm1Assembly5201PerShiftPerCyclesGet(ref IQueryable<Models.Sortimat.Fm1Assembly5201PerShiftPerCycle> items);

    partial void OnFm1Assembly5201PerShiftPerCycleDeleted(Models.Sortimat.Fm1Assembly5201PerShiftPerCycle item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm1Assembly5201PerShiftPerCycle(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm1Assembly5201PerShiftPerCycles
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm1Assembly5201PerShiftPerCycleDeleted(item);
            this.context.Fm1Assembly5201PerShiftPerCycles.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1Assembly5201PerShiftPerCycleUpdated(Models.Sortimat.Fm1Assembly5201PerShiftPerCycle item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm1Assembly5201PerShiftPerCycle(int key, [FromBody]Models.Sortimat.Fm1Assembly5201PerShiftPerCycle newItem)
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

            this.OnFm1Assembly5201PerShiftPerCycleUpdated(newItem);
            this.context.Fm1Assembly5201PerShiftPerCycles.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1Assembly5201PerShiftPerCycles.Where(i => i.RowID == key);
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
    public IActionResult PatchFm1Assembly5201PerShiftPerCycle(int key, [FromBody]Delta<Models.Sortimat.Fm1Assembly5201PerShiftPerCycle> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm1Assembly5201PerShiftPerCycles.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm1Assembly5201PerShiftPerCycleUpdated(item);
            this.context.Fm1Assembly5201PerShiftPerCycles.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1Assembly5201PerShiftPerCycles.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1Assembly5201PerShiftPerCycleCreated(Models.Sortimat.Fm1Assembly5201PerShiftPerCycle item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm1Assembly5201PerShiftPerCycle item)
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

            this.OnFm1Assembly5201PerShiftPerCycleCreated(item);
            this.context.Fm1Assembly5201PerShiftPerCycles.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm1Assembly5201PerShiftPerCycles/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
