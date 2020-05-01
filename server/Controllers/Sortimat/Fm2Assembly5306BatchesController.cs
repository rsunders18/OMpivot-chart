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

  [ODataRoutePrefix("odata/Sortimat/Fm2Assembly5306Batches")]
  [Route("mvc/odata/Sortimat/Fm2Assembly5306Batches")]
  public partial class Fm2Assembly5306BatchesController : ODataController
  {
    private Data.SortimatContext context;

    public Fm2Assembly5306BatchesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm2Assembly5306Batches
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm2Assembly5306Batch> GetFm2Assembly5306Batches()
    {
      var items = this.context.Fm2Assembly5306Batches.AsQueryable<Models.Sortimat.Fm2Assembly5306Batch>();
      this.OnFm2Assembly5306BatchesRead(ref items);

      return items;
    }

    partial void OnFm2Assembly5306BatchesRead(ref IQueryable<Models.Sortimat.Fm2Assembly5306Batch> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm2Assembly5306Batch> GetFm2Assembly5306Batch(int key)
    {
        var items = this.context.Fm2Assembly5306Batches.Where(i=>i.RowID == key);
        this.OnFm2Assembly5306BatchesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm2Assembly5306BatchesGet(ref IQueryable<Models.Sortimat.Fm2Assembly5306Batch> items);

    partial void OnFm2Assembly5306BatchDeleted(Models.Sortimat.Fm2Assembly5306Batch item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm2Assembly5306Batch(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm2Assembly5306Batches
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm2Assembly5306BatchDeleted(item);
            this.context.Fm2Assembly5306Batches.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2Assembly5306BatchUpdated(Models.Sortimat.Fm2Assembly5306Batch item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm2Assembly5306Batch(int key, [FromBody]Models.Sortimat.Fm2Assembly5306Batch newItem)
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

            this.OnFm2Assembly5306BatchUpdated(newItem);
            this.context.Fm2Assembly5306Batches.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2Assembly5306Batches.Where(i => i.RowID == key);
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
    public IActionResult PatchFm2Assembly5306Batch(int key, [FromBody]Delta<Models.Sortimat.Fm2Assembly5306Batch> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm2Assembly5306Batches.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm2Assembly5306BatchUpdated(item);
            this.context.Fm2Assembly5306Batches.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2Assembly5306Batches.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2Assembly5306BatchCreated(Models.Sortimat.Fm2Assembly5306Batch item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm2Assembly5306Batch item)
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

            this.OnFm2Assembly5306BatchCreated(item);
            this.context.Fm2Assembly5306Batches.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm2Assembly5306Batches/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
