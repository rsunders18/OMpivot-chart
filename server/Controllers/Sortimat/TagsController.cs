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

  [ODataRoutePrefix("odata/Sortimat/Tags")]
  [Route("mvc/odata/Sortimat/Tags")]
  public partial class TagsController : ODataController
  {
    private Data.SortimatContext context;

    public TagsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Tags
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Tag> GetTags()
    {
      var items = this.context.Tags.AsQueryable<Models.Sortimat.Tag>();
      this.OnTagsRead(ref items);

      return items;
    }

    partial void OnTagsRead(ref IQueryable<Models.Sortimat.Tag> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{TagID}")]
    public SingleResult<Tag> GetTag(int key)
    {
        var items = this.context.Tags.Where(i=>i.TagID == key);
        this.OnTagsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnTagsGet(ref IQueryable<Models.Sortimat.Tag> items);

    partial void OnTagDeleted(Models.Sortimat.Tag item);

    [HttpDelete("{TagID}")]
    public IActionResult DeleteTag(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Tags
                .Where(i => i.TagID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnTagDeleted(item);
            this.context.Tags.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnTagUpdated(Models.Sortimat.Tag item);

    [HttpPut("{TagID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutTag(int key, [FromBody]Models.Sortimat.Tag newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.TagID != key))
            {
                return BadRequest();
            }

            this.OnTagUpdated(newItem);
            this.context.Tags.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Tags.Where(i => i.TagID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{TagID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchTag(int key, [FromBody]Delta<Models.Sortimat.Tag> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Tags.Where(i => i.TagID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnTagUpdated(item);
            this.context.Tags.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Tags.Where(i => i.TagID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnTagCreated(Models.Sortimat.Tag item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Tag item)
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

            this.OnTagCreated(item);
            this.context.Tags.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Tags/{item.TagID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
