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

  [ODataRoutePrefix("odata/Sortimat/Fm2Assembly5306Data")]
  [Route("mvc/odata/Sortimat/Fm2Assembly5306Data")]
  public partial class Fm2Assembly5306DataController : ODataController
  {
    private Data.SortimatContext context;

    public Fm2Assembly5306DataController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm2Assembly5306Data
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm2Assembly5306Datum> GetFm2Assembly5306Data()
    {
      var items = this.context.Fm2Assembly5306Data.AsQueryable<Models.Sortimat.Fm2Assembly5306Datum>();
      this.OnFm2Assembly5306DataRead(ref items);

      return items;
    }

    partial void OnFm2Assembly5306DataRead(ref IQueryable<Models.Sortimat.Fm2Assembly5306Datum> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{id}")]
    public SingleResult<Fm2Assembly5306Datum> GetFm2Assembly5306Datum(int key)
    {
        var items = this.context.Fm2Assembly5306Data.Where(i=>i.id == key);
        this.OnFm2Assembly5306DataGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm2Assembly5306DataGet(ref IQueryable<Models.Sortimat.Fm2Assembly5306Datum> items);

    partial void OnFm2Assembly5306DatumDeleted(Models.Sortimat.Fm2Assembly5306Datum item);

    [HttpDelete("{id}")]
    public IActionResult DeleteFm2Assembly5306Datum(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm2Assembly5306Data
                .Where(i => i.id == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm2Assembly5306DatumDeleted(item);
            this.context.Fm2Assembly5306Data.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2Assembly5306DatumUpdated(Models.Sortimat.Fm2Assembly5306Datum item);

    [HttpPut("{id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm2Assembly5306Datum(int key, [FromBody]Models.Sortimat.Fm2Assembly5306Datum newItem)
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

            this.OnFm2Assembly5306DatumUpdated(newItem);
            this.context.Fm2Assembly5306Data.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2Assembly5306Data.Where(i => i.id == key);
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
    public IActionResult PatchFm2Assembly5306Datum(int key, [FromBody]Delta<Models.Sortimat.Fm2Assembly5306Datum> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm2Assembly5306Data.Where(i => i.id == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm2Assembly5306DatumUpdated(item);
            this.context.Fm2Assembly5306Data.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm2Assembly5306Data.Where(i => i.id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm2Assembly5306DatumCreated(Models.Sortimat.Fm2Assembly5306Datum item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm2Assembly5306Datum item)
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

            this.OnFm2Assembly5306DatumCreated(item);
            this.context.Fm2Assembly5306Data.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm2Assembly5306Data/{item.id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
