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

  [ODataRoutePrefix("odata/Sortimat/Fm1Assembly5201Batches")]
  [Route("mvc/odata/Sortimat/Fm1Assembly5201Batches")]
  public partial class Fm1Assembly5201BatchesController : ODataController
  {
    private Data.SortimatContext context;

    public Fm1Assembly5201BatchesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm1Assembly5201Batches
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm1Assembly5201Batch> GetFm1Assembly5201Batches()
    {
      var items = this.context.Fm1Assembly5201Batches.AsQueryable<Models.Sortimat.Fm1Assembly5201Batch>();
      this.OnFm1Assembly5201BatchesRead(ref items);

      return items;
    }

    partial void OnFm1Assembly5201BatchesRead(ref IQueryable<Models.Sortimat.Fm1Assembly5201Batch> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm1Assembly5201Batch> GetFm1Assembly5201Batch(int key)
    {
        var items = this.context.Fm1Assembly5201Batches.Where(i=>i.RowID == key);
        this.OnFm1Assembly5201BatchesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm1Assembly5201BatchesGet(ref IQueryable<Models.Sortimat.Fm1Assembly5201Batch> items);

    partial void OnFm1Assembly5201BatchDeleted(Models.Sortimat.Fm1Assembly5201Batch item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm1Assembly5201Batch(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm1Assembly5201Batches
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm1Assembly5201BatchDeleted(item);
            this.context.Fm1Assembly5201Batches.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1Assembly5201BatchUpdated(Models.Sortimat.Fm1Assembly5201Batch item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm1Assembly5201Batch(int key, [FromBody]Models.Sortimat.Fm1Assembly5201Batch newItem)
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

            this.OnFm1Assembly5201BatchUpdated(newItem);
            this.context.Fm1Assembly5201Batches.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1Assembly5201Batches.Where(i => i.RowID == key);
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
    public IActionResult PatchFm1Assembly5201Batch(int key, [FromBody]Delta<Models.Sortimat.Fm1Assembly5201Batch> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm1Assembly5201Batches.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm1Assembly5201BatchUpdated(item);
            this.context.Fm1Assembly5201Batches.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1Assembly5201Batches.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1Assembly5201BatchCreated(Models.Sortimat.Fm1Assembly5201Batch item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm1Assembly5201Batch item)
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

            this.OnFm1Assembly5201BatchCreated(item);
            this.context.Fm1Assembly5201Batches.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm1Assembly5201Batches/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
