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

  [ODataRoutePrefix("odata/Sortimat/Fm1Assembly5201Data")]
  [Route("mvc/odata/Sortimat/Fm1Assembly5201Data")]
  public partial class Fm1Assembly5201DataController : ODataController
  {
    private Data.SortimatContext context;

    public Fm1Assembly5201DataController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Fm1Assembly5201Data
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Fm1Assembly5201Datum> GetFm1Assembly5201Data()
    {
      var items = this.context.Fm1Assembly5201Data.AsQueryable<Models.Sortimat.Fm1Assembly5201Datum>();
      this.OnFm1Assembly5201DataRead(ref items);

      return items;
    }

    partial void OnFm1Assembly5201DataRead(ref IQueryable<Models.Sortimat.Fm1Assembly5201Datum> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{id}")]
    public SingleResult<Fm1Assembly5201Datum> GetFm1Assembly5201Datum(int key)
    {
        var items = this.context.Fm1Assembly5201Data.Where(i=>i.id == key);
        this.OnFm1Assembly5201DataGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnFm1Assembly5201DataGet(ref IQueryable<Models.Sortimat.Fm1Assembly5201Datum> items);

    partial void OnFm1Assembly5201DatumDeleted(Models.Sortimat.Fm1Assembly5201Datum item);

    [HttpDelete("{id}")]
    public IActionResult DeleteFm1Assembly5201Datum(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Fm1Assembly5201Data
                .Where(i => i.id == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnFm1Assembly5201DatumDeleted(item);
            this.context.Fm1Assembly5201Data.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1Assembly5201DatumUpdated(Models.Sortimat.Fm1Assembly5201Datum item);

    [HttpPut("{id}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutFm1Assembly5201Datum(int key, [FromBody]Models.Sortimat.Fm1Assembly5201Datum newItem)
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

            this.OnFm1Assembly5201DatumUpdated(newItem);
            this.context.Fm1Assembly5201Data.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1Assembly5201Data.Where(i => i.id == key);
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
    public IActionResult PatchFm1Assembly5201Datum(int key, [FromBody]Delta<Models.Sortimat.Fm1Assembly5201Datum> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Fm1Assembly5201Data.Where(i => i.id == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnFm1Assembly5201DatumUpdated(item);
            this.context.Fm1Assembly5201Data.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Fm1Assembly5201Data.Where(i => i.id == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnFm1Assembly5201DatumCreated(Models.Sortimat.Fm1Assembly5201Datum item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Fm1Assembly5201Datum item)
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

            this.OnFm1Assembly5201DatumCreated(item);
            this.context.Fm1Assembly5201Data.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Fm1Assembly5201Data/{item.id}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
