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

  [ODataRoutePrefix("odata/Sortimat/Fm2PickAndPlace5305Data")]
  [Route("mvc/odata/Sortimat/Fm2PickAndPlace5305Data")]
  public partial class Fm2PickAndPlace5305DataController : ODataController
  {
    private Data.SortimatContext context;

    public Fm2PickAndPlace5305DataController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm2PickAndPlace5305Data
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm2PickAndPlace5305Datum> GetFm2PickAndPlace5305Data()
    {
      var items = this.context.Fm2PickAndPlace5305Data.AsQueryable<Models.Sortimat.Fm2PickAndPlace5305Datum>();
      this.OnFm2PickAndPlace5305DataRead(ref items);

      return items;
    }

    partial void OnFm2PickAndPlace5305DataRead(ref IQueryable<Models.Sortimat.Fm2PickAndPlace5305Datum> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{id}")]
    public SingleResult<Fm2PickAndPlace5305Datum> GetFm2PickAndPlace5305Datum(int key)
    {
        var items = this.context.Fm2PickAndPlace5305Data.Where(i=>i.id == key);
        this.OnFm2PickAndPlace5305DataGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm2PickAndPlace5305DataGet(ref IQueryable<Models.Sortimat.Fm2PickAndPlace5305Datum> items);

    partial void OnFm2PickAndPlace5305DatumDeleted(Models.Sortimat.Fm2PickAndPlace5305Datum item);

    [HttpDelete("{id}")]
    public IActionResult DeleteFm2PickAndPlace5305Datum(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm2PickAndPlace5305Data
                .Where(i => i.id == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm2PickAndPlace5305DatumDeleted(item);
            this.context.Fm2PickAndPlace5305Data.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2PickAndPlace5305DatumUpdated(Models.Sortimat.Fm2PickAndPlace5305Datum item);

    [HttpPut("{id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm2PickAndPlace5305Datum(int key, [FromBody]Models.Sortimat.Fm2PickAndPlace5305Datum newItem)
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

            this.OnFm2PickAndPlace5305DatumUpdated(newItem);
            this.context.Fm2PickAndPlace5305Data.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2PickAndPlace5305Data.Where(i => i.id == key);
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
    public IActionResult PatchFm2PickAndPlace5305Datum(int key, [FromBody]Delta<Models.Sortimat.Fm2PickAndPlace5305Datum> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm2PickAndPlace5305Data.Where(i => i.id == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm2PickAndPlace5305DatumUpdated(item);
            this.context.Fm2PickAndPlace5305Data.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2PickAndPlace5305Data.Where(i => i.id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2PickAndPlace5305DatumCreated(Models.Sortimat.Fm2PickAndPlace5305Datum item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm2PickAndPlace5305Datum item)
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

            this.OnFm2PickAndPlace5305DatumCreated(item);
            this.context.Fm2PickAndPlace5305Data.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm2PickAndPlace5305Data/{item.id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
