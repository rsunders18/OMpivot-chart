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

  [ODataRoutePrefix("odata/Sortimat/Fm1PickAndPlace5219Batches")]
  [Route("mvc/odata/Sortimat/Fm1PickAndPlace5219Batches")]
  public partial class Fm1PickAndPlace5219BatchesController : ODataController
  {
    private Data.SortimatContext context;

    public Fm1PickAndPlace5219BatchesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm1PickAndPlace5219Batches
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm1PickAndPlace5219Batch> GetFm1PickAndPlace5219Batches()
    {
      var items = this.context.Fm1PickAndPlace5219Batches.AsQueryable<Models.Sortimat.Fm1PickAndPlace5219Batch>();
      this.OnFm1PickAndPlace5219BatchesRead(ref items);

      return items;
    }

    partial void OnFm1PickAndPlace5219BatchesRead(ref IQueryable<Models.Sortimat.Fm1PickAndPlace5219Batch> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<Fm1PickAndPlace5219Batch> GetFm1PickAndPlace5219Batch(int key)
    {
        var items = this.context.Fm1PickAndPlace5219Batches.Where(i=>i.RowID == key);
        this.OnFm1PickAndPlace5219BatchesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm1PickAndPlace5219BatchesGet(ref IQueryable<Models.Sortimat.Fm1PickAndPlace5219Batch> items);

    partial void OnFm1PickAndPlace5219BatchDeleted(Models.Sortimat.Fm1PickAndPlace5219Batch item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteFm1PickAndPlace5219Batch(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm1PickAndPlace5219Batches
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm1PickAndPlace5219BatchDeleted(item);
            this.context.Fm1PickAndPlace5219Batches.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1PickAndPlace5219BatchUpdated(Models.Sortimat.Fm1PickAndPlace5219Batch item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm1PickAndPlace5219Batch(int key, [FromBody]Models.Sortimat.Fm1PickAndPlace5219Batch newItem)
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

            this.OnFm1PickAndPlace5219BatchUpdated(newItem);
            this.context.Fm1PickAndPlace5219Batches.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1PickAndPlace5219Batches.Where(i => i.RowID == key);
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
    public IActionResult PatchFm1PickAndPlace5219Batch(int key, [FromBody]Delta<Models.Sortimat.Fm1PickAndPlace5219Batch> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm1PickAndPlace5219Batches.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm1PickAndPlace5219BatchUpdated(item);
            this.context.Fm1PickAndPlace5219Batches.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1PickAndPlace5219Batches.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1PickAndPlace5219BatchCreated(Models.Sortimat.Fm1PickAndPlace5219Batch item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm1PickAndPlace5219Batch item)
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

            this.OnFm1PickAndPlace5219BatchCreated(item);
            this.context.Fm1PickAndPlace5219Batches.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm1PickAndPlace5219Batches/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
