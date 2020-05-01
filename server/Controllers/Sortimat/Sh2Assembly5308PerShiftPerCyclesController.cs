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

  [ODataRoutePrefix("odata/Sortimat/Sh2Assembly5308PerShiftPerCycles")]
  [Route("mvc/odata/Sortimat/Sh2Assembly5308PerShiftPerCycles")]
  public partial class Sh2Assembly5308PerShiftPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public Sh2Assembly5308PerShiftPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh2Assembly5308PerShiftPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh2Assembly5308PerShiftPerCycle> GetSh2Assembly5308PerShiftPerCycles()
    {
      var items = this.context.Sh2Assembly5308PerShiftPerCycles.AsQueryable<Models.Sortimat.Sh2Assembly5308PerShiftPerCycle>();
      this.OnSh2Assembly5308PerShiftPerCyclesRead(ref items);

      return items;
    }

    partial void OnSh2Assembly5308PerShiftPerCyclesRead(ref IQueryable<Models.Sortimat.Sh2Assembly5308PerShiftPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Sh2Assembly5308PerShiftPerCycle> GetSh2Assembly5308PerShiftPerCycle(int key)
    {
        var items = this.context.Sh2Assembly5308PerShiftPerCycles.Where(i=>i.RowID == key);
        this.OnSh2Assembly5308PerShiftPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh2Assembly5308PerShiftPerCyclesGet(ref IQueryable<Models.Sortimat.Sh2Assembly5308PerShiftPerCycle> items);

    partial void OnSh2Assembly5308PerShiftPerCycleDeleted(Models.Sortimat.Sh2Assembly5308PerShiftPerCycle item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteSh2Assembly5308PerShiftPerCycle(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh2Assembly5308PerShiftPerCycles
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh2Assembly5308PerShiftPerCycleDeleted(item);
            this.context.Sh2Assembly5308PerShiftPerCycles.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh2Assembly5308PerShiftPerCycleUpdated(Models.Sortimat.Sh2Assembly5308PerShiftPerCycle item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh2Assembly5308PerShiftPerCycle(int key, [FromBody]Models.Sortimat.Sh2Assembly5308PerShiftPerCycle newItem)
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

            this.OnSh2Assembly5308PerShiftPerCycleUpdated(newItem);
            this.context.Sh2Assembly5308PerShiftPerCycles.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh2Assembly5308PerShiftPerCycles.Where(i => i.RowID == key);
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
    public IActionResult PatchSh2Assembly5308PerShiftPerCycle(int key, [FromBody]Delta<Models.Sortimat.Sh2Assembly5308PerShiftPerCycle> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh2Assembly5308PerShiftPerCycles.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh2Assembly5308PerShiftPerCycleUpdated(item);
            this.context.Sh2Assembly5308PerShiftPerCycles.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh2Assembly5308PerShiftPerCycles.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh2Assembly5308PerShiftPerCycleCreated(Models.Sortimat.Sh2Assembly5308PerShiftPerCycle item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh2Assembly5308PerShiftPerCycle item)
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

            this.OnSh2Assembly5308PerShiftPerCycleCreated(item);
            this.context.Sh2Assembly5308PerShiftPerCycles.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh2Assembly5308PerShiftPerCycles/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
