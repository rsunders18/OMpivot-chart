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

  [ODataRoutePrefix("odata/Sortimat/Sh1Assembly5202Batches")]
  [Route("mvc/odata/Sortimat/Sh1Assembly5202Batches")]
  public partial class Sh1Assembly5202BatchesController : ODataController
  {
    private Data.SortimatContext context;

    public Sh1Assembly5202BatchesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh1Assembly5202Batches
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh1Assembly5202Batch> GetSh1Assembly5202Batches()
    {
      var items = this.context.Sh1Assembly5202Batches.AsQueryable<Models.Sortimat.Sh1Assembly5202Batch>();
      this.OnSh1Assembly5202BatchesRead(ref items);

      return items;
    }

    partial void OnSh1Assembly5202BatchesRead(ref IQueryable<Models.Sortimat.Sh1Assembly5202Batch> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Sh1Assembly5202Batch> GetSh1Assembly5202Batch(int key)
    {
        var items = this.context.Sh1Assembly5202Batches.Where(i=>i.RowID == key);
        this.OnSh1Assembly5202BatchesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh1Assembly5202BatchesGet(ref IQueryable<Models.Sortimat.Sh1Assembly5202Batch> items);

    partial void OnSh1Assembly5202BatchDeleted(Models.Sortimat.Sh1Assembly5202Batch item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteSh1Assembly5202Batch(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh1Assembly5202Batches
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh1Assembly5202BatchDeleted(item);
            this.context.Sh1Assembly5202Batches.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1Assembly5202BatchUpdated(Models.Sortimat.Sh1Assembly5202Batch item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh1Assembly5202Batch(int key, [FromBody]Models.Sortimat.Sh1Assembly5202Batch newItem)
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

            this.OnSh1Assembly5202BatchUpdated(newItem);
            this.context.Sh1Assembly5202Batches.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1Assembly5202Batches.Where(i => i.RowID == key);
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
    public IActionResult PatchSh1Assembly5202Batch(int key, [FromBody]Delta<Models.Sortimat.Sh1Assembly5202Batch> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh1Assembly5202Batches.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh1Assembly5202BatchUpdated(item);
            this.context.Sh1Assembly5202Batches.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1Assembly5202Batches.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1Assembly5202BatchCreated(Models.Sortimat.Sh1Assembly5202Batch item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh1Assembly5202Batch item)
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

            this.OnSh1Assembly5202BatchCreated(item);
            this.context.Sh1Assembly5202Batches.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh1Assembly5202Batches/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
