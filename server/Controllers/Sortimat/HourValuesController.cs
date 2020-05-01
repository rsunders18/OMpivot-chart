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

  [ODataRoutePrefix("odata/Sortimat/HourValues")]
  [Route("mvc/odata/Sortimat/HourValues")]
  public partial class HourValuesController : ODataController
  {
    private Data.SortimatContext context;

    public HourValuesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/HourValues
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.HourValue> GetHourValues()
    {
      var items = this.context.HourValues.AsQueryable<Models.Sortimat.HourValue>();
      this.OnHourValuesRead(ref items);

      return items;
    }

    partial void OnHourValuesRead(ref IQueryable<Models.Sortimat.HourValue> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<HourValue> GetHourValue(int key)
    {
        var items = this.context.HourValues.Where(i=>i.RowID == key);
        this.OnHourValuesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnHourValuesGet(ref IQueryable<Models.Sortimat.HourValue> items);

    partial void OnHourValueDeleted(Models.Sortimat.HourValue item);

    [HttpDelete("{RowID}")]
    public IActionResult DeleteHourValue(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.HourValues
                .Where(i => i.RowID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnHourValueDeleted(item);
            this.context.HourValues.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnHourValueUpdated(Models.Sortimat.HourValue item);

    [HttpPut("{RowID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutHourValue(int key, [FromBody]Models.Sortimat.HourValue newItem)
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

            this.OnHourValueUpdated(newItem);
            this.context.HourValues.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.HourValues.Where(i => i.RowID == key);
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
    public IActionResult PatchHourValue(int key, [FromBody]Delta<Models.Sortimat.HourValue> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.HourValues.Where(i => i.RowID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnHourValueUpdated(item);
            this.context.HourValues.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.HourValues.Where(i => i.RowID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnHourValueCreated(Models.Sortimat.HourValue item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.HourValue item)
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

            this.OnHourValueCreated(item);
            this.context.HourValues.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/HourValues/{item.RowID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
