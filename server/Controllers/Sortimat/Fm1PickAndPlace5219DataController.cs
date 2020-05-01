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

  [ODataRoutePrefix("odata/Sortimat/Fm1PickAndPlace5219Data")]
  [Route("mvc/odata/Sortimat/Fm1PickAndPlace5219Data")]
  public partial class Fm1PickAndPlace5219DataController : ODataController
  {
    private Data.SortimatContext context;

    public Fm1PickAndPlace5219DataController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm1PickAndPlace5219Data
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm1PickAndPlace5219Datum> GetFm1PickAndPlace5219Data()
    {
      var items = this.context.Fm1PickAndPlace5219Data.AsQueryable<Models.Sortimat.Fm1PickAndPlace5219Datum>();
      this.OnFm1PickAndPlace5219DataRead(ref items);

      return items;
    }

    partial void OnFm1PickAndPlace5219DataRead(ref IQueryable<Models.Sortimat.Fm1PickAndPlace5219Datum> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{id}")]
    public SingleResult<Fm1PickAndPlace5219Datum> GetFm1PickAndPlace5219Datum(int key)
    {
        var items = this.context.Fm1PickAndPlace5219Data.Where(i=>i.id == key);
        this.OnFm1PickAndPlace5219DataGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm1PickAndPlace5219DataGet(ref IQueryable<Models.Sortimat.Fm1PickAndPlace5219Datum> items);

    partial void OnFm1PickAndPlace5219DatumDeleted(Models.Sortimat.Fm1PickAndPlace5219Datum item);

    [HttpDelete("{id}")]
    public IActionResult DeleteFm1PickAndPlace5219Datum(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm1PickAndPlace5219Data
                .Where(i => i.id == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm1PickAndPlace5219DatumDeleted(item);
            this.context.Fm1PickAndPlace5219Data.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1PickAndPlace5219DatumUpdated(Models.Sortimat.Fm1PickAndPlace5219Datum item);

    [HttpPut("{id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm1PickAndPlace5219Datum(int key, [FromBody]Models.Sortimat.Fm1PickAndPlace5219Datum newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.id != key))
            {
                return BadRequest();
            }

            this.OnFm1PickAndPlace5219DatumUpdated(newItem);
            this.context.Fm1PickAndPlace5219Data.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1PickAndPlace5219Data.Where(i => i.id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchFm1PickAndPlace5219Datum(int key, [FromBody]Delta<Models.Sortimat.Fm1PickAndPlace5219Datum> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm1PickAndPlace5219Data.Where(i => i.id == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm1PickAndPlace5219DatumUpdated(item);
            this.context.Fm1PickAndPlace5219Data.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1PickAndPlace5219Data.Where(i => i.id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1PickAndPlace5219DatumCreated(Models.Sortimat.Fm1PickAndPlace5219Datum item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm1PickAndPlace5219Datum item)
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

            this.OnFm1PickAndPlace5219DatumCreated(item);
            this.context.Fm1PickAndPlace5219Data.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm1PickAndPlace5219Data/{item.id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
