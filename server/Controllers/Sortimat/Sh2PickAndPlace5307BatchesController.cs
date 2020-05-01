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

  [ODataRoutePrefix("odata/Sortimat/Sh2PickAndPlace5307Batches")]
  [Route("mvc/odata/Sortimat/Sh2PickAndPlace5307Batches")]
  public partial class Sh2PickAndPlace5307BatchesController : ODataController
  {
    private Data.SortimatContext context;

    public Sh2PickAndPlace5307BatchesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh2PickAndPlace5307Batches
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh2PickAndPlace5307Batch> GetSh2PickAndPlace5307Batches()
    {
      var items = this.context.Sh2PickAndPlace5307Batches.AsQueryable<Models.Sortimat.Sh2PickAndPlace5307Batch>();
      this.OnSh2PickAndPlace5307BatchesRead(ref items);

      return items;
    }

    partial void OnSh2PickAndPlace5307BatchesRead(ref IQueryable<Models.Sortimat.Sh2PickAndPlace5307Batch> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Sh2PickAndPlace5307Batch> GetSh2PickAndPlace5307Batch(int key)
    {
        var items = this.context.Sh2PickAndPlace5307Batches.Where(i=>i.RowID == key);
        this.OnSh2PickAndPlace5307BatchesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh2PickAndPlace5307BatchesGet(ref IQueryable<Models.Sortimat.Sh2PickAndPlace5307Batch> items);

    partial void OnSh2PickAndPlace5307BatchDeleted(Models.Sortimat.Sh2PickAndPlace5307Batch item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteSh2PickAndPlace5307Batch(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh2PickAndPlace5307Batches
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh2PickAndPlace5307BatchDeleted(item);
            this.context.Sh2PickAndPlace5307Batches.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh2PickAndPlace5307BatchUpdated(Models.Sortimat.Sh2PickAndPlace5307Batch item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh2PickAndPlace5307Batch(int key, [FromBody]Models.Sortimat.Sh2PickAndPlace5307Batch newItem)
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

            this.OnSh2PickAndPlace5307BatchUpdated(newItem);
            this.context.Sh2PickAndPlace5307Batches.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh2PickAndPlace5307Batches.Where(i => i.RowID == key);
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
    public IActionResult PatchSh2PickAndPlace5307Batch(int key, [FromBody]Delta<Models.Sortimat.Sh2PickAndPlace5307Batch> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh2PickAndPlace5307Batches.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh2PickAndPlace5307BatchUpdated(item);
            this.context.Sh2PickAndPlace5307Batches.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh2PickAndPlace5307Batches.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh2PickAndPlace5307BatchCreated(Models.Sortimat.Sh2PickAndPlace5307Batch item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh2PickAndPlace5307Batch item)
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

            this.OnSh2PickAndPlace5307BatchCreated(item);
            this.context.Sh2PickAndPlace5307Batches.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh2PickAndPlace5307Batches/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
