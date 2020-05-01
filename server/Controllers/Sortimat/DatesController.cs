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

  [ODataRoutePrefix("odata/Sortimat/Dates")]
  [Route("mvc/odata/Sortimat/Dates")]
  public partial class DatesController : ODataController
  {
    private Data.SortimatContext context;

    public DatesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Dates
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Date> GetDates()
    {
      var items = this.context.Dates.AsQueryable<Models.Sortimat.Date>();
      this.OnDatesRead(ref items);

      return items;
    }

    partial void OnDatesRead(ref IQueryable<Models.Sortimat.Date> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Date1}")]
    public SingleResult<Date> GetDate(DateTime key)
    {
        var items = this.context.Dates.Where(i=>i.Date1 == key);
        this.OnDatesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnDatesGet(ref IQueryable<Models.Sortimat.Date> items);

    partial void OnDateDeleted(Models.Sortimat.Date item);

    [HttpDelete("{Date1}")]
    public IActionResult DeleteDate(DateTime key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Dates
                .Where(i => i.Date1 == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnDateDeleted(item);
            this.context.Dates.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnDateUpdated(Models.Sortimat.Date item);

    [HttpPut("{Date1}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutDate(DateTime key, [FromBody]Models.Sortimat.Date newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.Date1 != key))
            {
                return BadRequest();
            }

            this.OnDateUpdated(newItem);
            this.context.Dates.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Dates.Where(i => i.Date1 == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{Date1}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchDate(DateTime key, [FromBody]Delta<Models.Sortimat.Date> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Dates.Where(i => i.Date1 == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnDateUpdated(item);
            this.context.Dates.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Dates.Where(i => i.Date1 == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnDateCreated(Models.Sortimat.Date item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Date item)
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

            this.OnDateCreated(item);
            this.context.Dates.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Dates/{item.Date1}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
