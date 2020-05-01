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

  [ODataRoutePrefix("odata/Sortimat/Sh1Assembly5202Data")]
  [Route("mvc/odata/Sortimat/Sh1Assembly5202Data")]
  public partial class Sh1Assembly5202DataController : ODataController
  {
    private Data.SortimatContext context;

    public Sh1Assembly5202DataController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Sh1Assembly5202Data
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Sh1Assembly5202Datum> GetSh1Assembly5202Data()
    {
      var items = this.context.Sh1Assembly5202Data.AsQueryable<Models.Sortimat.Sh1Assembly5202Datum>();
      this.OnSh1Assembly5202DataRead(ref items);

      return items;
    }

    partial void OnSh1Assembly5202DataRead(ref IQueryable<Models.Sortimat.Sh1Assembly5202Datum> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{id}")]
    public SingleResult<Sh1Assembly5202Datum> GetSh1Assembly5202Datum(int key)
    {
        var items = this.context.Sh1Assembly5202Data.Where(i=>i.id == key);
        this.OnSh1Assembly5202DataGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnSh1Assembly5202DataGet(ref IQueryable<Models.Sortimat.Sh1Assembly5202Datum> items);

    partial void OnSh1Assembly5202DatumDeleted(Models.Sortimat.Sh1Assembly5202Datum item);

    [HttpDelete("{id}")]
    public IActionResult DeleteSh1Assembly5202Datum(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Sh1Assembly5202Data
                .Where(i => i.id == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnSh1Assembly5202DatumDeleted(item);
            this.context.Sh1Assembly5202Data.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1Assembly5202DatumUpdated(Models.Sortimat.Sh1Assembly5202Datum item);

    [HttpPut("{id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutSh1Assembly5202Datum(int key, [FromBody]Models.Sortimat.Sh1Assembly5202Datum newItem)
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

            this.OnSh1Assembly5202DatumUpdated(newItem);
            this.context.Sh1Assembly5202Data.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1Assembly5202Data.Where(i => i.id == key);
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
    public IActionResult PatchSh1Assembly5202Datum(int key, [FromBody]Delta<Models.Sortimat.Sh1Assembly5202Datum> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Sh1Assembly5202Data.Where(i => i.id == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnSh1Assembly5202DatumUpdated(item);
            this.context.Sh1Assembly5202Data.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Sh1Assembly5202Data.Where(i => i.id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnSh1Assembly5202DatumCreated(Models.Sortimat.Sh1Assembly5202Datum item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Sh1Assembly5202Datum item)
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

            this.OnSh1Assembly5202DatumCreated(item);
            this.context.Sh1Assembly5202Data.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Sh1Assembly5202Data/{item.id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
