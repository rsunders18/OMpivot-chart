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

  [ODataRoutePrefix("odata/Sortimat/Sh2PickAndPlace5307Data")]
  [Route("mvc/odata/Sortimat/Sh2PickAndPlace5307Data")]
  public partial class Sh2PickAndPlace5307DataController : ODataController
  {
    private Data.SortimatContext context;

    public Sh2PickAndPlace5307DataController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh2PickAndPlace5307Data
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh2PickAndPlace5307Datum> GetSh2PickAndPlace5307Data()
    {
      var items = this.context.Sh2PickAndPlace5307Data.AsQueryable<Models.Sortimat.Sh2PickAndPlace5307Datum>();
      this.OnSh2PickAndPlace5307DataRead(ref items);

      return items;
    }

    partial void OnSh2PickAndPlace5307DataRead(ref IQueryable<Models.Sortimat.Sh2PickAndPlace5307Datum> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{id}")]
    public SingleResult<Sh2PickAndPlace5307Datum> GetSh2PickAndPlace5307Datum(int key)
    {
        var items = this.context.Sh2PickAndPlace5307Data.Where(i=>i.id == key);
        this.OnSh2PickAndPlace5307DataGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh2PickAndPlace5307DataGet(ref IQueryable<Models.Sortimat.Sh2PickAndPlace5307Datum> items);

    partial void OnSh2PickAndPlace5307DatumDeleted(Models.Sortimat.Sh2PickAndPlace5307Datum item);

    [HttpDelete("{id}")]
    public IActionResult DeleteSh2PickAndPlace5307Datum(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh2PickAndPlace5307Data
                .Where(i => i.id == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh2PickAndPlace5307DatumDeleted(item);
            this.context.Sh2PickAndPlace5307Data.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh2PickAndPlace5307DatumUpdated(Models.Sortimat.Sh2PickAndPlace5307Datum item);

    [HttpPut("{id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh2PickAndPlace5307Datum(int key, [FromBody]Models.Sortimat.Sh2PickAndPlace5307Datum newItem)
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

            this.OnSh2PickAndPlace5307DatumUpdated(newItem);
            this.context.Sh2PickAndPlace5307Data.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh2PickAndPlace5307Data.Where(i => i.id == key);
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
    public IActionResult PatchSh2PickAndPlace5307Datum(int key, [FromBody]Delta<Models.Sortimat.Sh2PickAndPlace5307Datum> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh2PickAndPlace5307Data.Where(i => i.id == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh2PickAndPlace5307DatumUpdated(item);
            this.context.Sh2PickAndPlace5307Data.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh2PickAndPlace5307Data.Where(i => i.id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh2PickAndPlace5307DatumCreated(Models.Sortimat.Sh2PickAndPlace5307Datum item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh2PickAndPlace5307Datum item)
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

            this.OnSh2PickAndPlace5307DatumCreated(item);
            this.context.Sh2PickAndPlace5307Data.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh2PickAndPlace5307Data/{item.id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
