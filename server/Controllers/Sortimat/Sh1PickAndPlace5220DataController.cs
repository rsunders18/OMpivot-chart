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

  [ODataRoutePrefix("odata/Sortimat/Sh1PickAndPlace5220Data")]
  [Route("mvc/odata/Sortimat/Sh1PickAndPlace5220Data")]
  public partial class Sh1PickAndPlace5220DataController : ODataController
  {
    private Data.SortimatContext context;

    public Sh1PickAndPlace5220DataController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh1PickAndPlace5220Data
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh1PickAndPlace5220Datum> GetSh1PickAndPlace5220Data()
    {
      var items = this.context.Sh1PickAndPlace5220Data.AsQueryable<Models.Sortimat.Sh1PickAndPlace5220Datum>();
      this.OnSh1PickAndPlace5220DataRead(ref items);

      return items;
    }

    partial void OnSh1PickAndPlace5220DataRead(ref IQueryable<Models.Sortimat.Sh1PickAndPlace5220Datum> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{id}")]
    public SingleResult<Sh1PickAndPlace5220Datum> GetSh1PickAndPlace5220Datum(int key)
    {
        var items = this.context.Sh1PickAndPlace5220Data.Where(i=>i.id == key);
        this.OnSh1PickAndPlace5220DataGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh1PickAndPlace5220DataGet(ref IQueryable<Models.Sortimat.Sh1PickAndPlace5220Datum> items);

    partial void OnSh1PickAndPlace5220DatumDeleted(Models.Sortimat.Sh1PickAndPlace5220Datum item);

    [HttpDelete("{id}")]
    public IActionResult DeleteSh1PickAndPlace5220Datum(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh1PickAndPlace5220Data
                .Where(i => i.id == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh1PickAndPlace5220DatumDeleted(item);
            this.context.Sh1PickAndPlace5220Data.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1PickAndPlace5220DatumUpdated(Models.Sortimat.Sh1PickAndPlace5220Datum item);

    [HttpPut("{id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh1PickAndPlace5220Datum(int key, [FromBody]Models.Sortimat.Sh1PickAndPlace5220Datum newItem)
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

            this.OnSh1PickAndPlace5220DatumUpdated(newItem);
            this.context.Sh1PickAndPlace5220Data.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1PickAndPlace5220Data.Where(i => i.id == key);
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
    public IActionResult PatchSh1PickAndPlace5220Datum(int key, [FromBody]Delta<Models.Sortimat.Sh1PickAndPlace5220Datum> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh1PickAndPlace5220Data.Where(i => i.id == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh1PickAndPlace5220DatumUpdated(item);
            this.context.Sh1PickAndPlace5220Data.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1PickAndPlace5220Data.Where(i => i.id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1PickAndPlace5220DatumCreated(Models.Sortimat.Sh1PickAndPlace5220Datum item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh1PickAndPlace5220Datum item)
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

            this.OnSh1PickAndPlace5220DatumCreated(item);
            this.context.Sh1PickAndPlace5220Data.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh1PickAndPlace5220Data/{item.id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
