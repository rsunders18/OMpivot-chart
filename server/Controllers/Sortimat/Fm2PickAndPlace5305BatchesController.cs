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

  [ODataRoutePrefix("odata/Sortimat/Fm2PickAndPlace5305Batches")]
  [Route("mvc/odata/Sortimat/Fm2PickAndPlace5305Batches")]
  public partial class Fm2PickAndPlace5305BatchesController : ODataController
  {
    private Data.SortimatContext context;

    public Fm2PickAndPlace5305BatchesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm2PickAndPlace5305Batches
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm2PickAndPlace5305Batch> GetFm2PickAndPlace5305Batches()
    {
      var items = this.context.Fm2PickAndPlace5305Batches.AsQueryable<Models.Sortimat.Fm2PickAndPlace5305Batch>();
      this.OnFm2PickAndPlace5305BatchesRead(ref items);

      return items;
    }

    partial void OnFm2PickAndPlace5305BatchesRead(ref IQueryable<Models.Sortimat.Fm2PickAndPlace5305Batch> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm2PickAndPlace5305Batch> GetFm2PickAndPlace5305Batch(int key)
    {
        var items = this.context.Fm2PickAndPlace5305Batches.Where(i=>i.RowID == key);
        this.OnFm2PickAndPlace5305BatchesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm2PickAndPlace5305BatchesGet(ref IQueryable<Models.Sortimat.Fm2PickAndPlace5305Batch> items);

    partial void OnFm2PickAndPlace5305BatchDeleted(Models.Sortimat.Fm2PickAndPlace5305Batch item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm2PickAndPlace5305Batch(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm2PickAndPlace5305Batches
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm2PickAndPlace5305BatchDeleted(item);
            this.context.Fm2PickAndPlace5305Batches.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2PickAndPlace5305BatchUpdated(Models.Sortimat.Fm2PickAndPlace5305Batch item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm2PickAndPlace5305Batch(int key, [FromBody]Models.Sortimat.Fm2PickAndPlace5305Batch newItem)
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

            this.OnFm2PickAndPlace5305BatchUpdated(newItem);
            this.context.Fm2PickAndPlace5305Batches.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2PickAndPlace5305Batches.Where(i => i.RowID == key);
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
    public IActionResult PatchFm2PickAndPlace5305Batch(int key, [FromBody]Delta<Models.Sortimat.Fm2PickAndPlace5305Batch> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm2PickAndPlace5305Batches.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm2PickAndPlace5305BatchUpdated(item);
            this.context.Fm2PickAndPlace5305Batches.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2PickAndPlace5305Batches.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2PickAndPlace5305BatchCreated(Models.Sortimat.Fm2PickAndPlace5305Batch item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm2PickAndPlace5305Batch item)
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

            this.OnFm2PickAndPlace5305BatchCreated(item);
            this.context.Fm2PickAndPlace5305Batches.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm2PickAndPlace5305Batches/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
