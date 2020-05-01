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

  [ODataRoutePrefix("odata/Sortimat/Machines")]
  [Route("mvc/odata/Sortimat/Machines")]
  public partial class MachinesController : ODataController
  {
    private Data.SortimatContext context;

    public MachinesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/Machines
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.Machine> GetMachines()
    {
      var items = this.context.Machines.AsQueryable<Models.Sortimat.Machine>();
      this.OnMachinesRead(ref items);

      return items;
    }

    partial void OnMachinesRead(ref IQueryable<Models.Sortimat.Machine> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{MachineID}")]
    public SingleResult<Machine> GetMachine(int key)
    {
        var items = this.context.Machines.Where(i=>i.MachineID == key);
        this.OnMachinesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnMachinesGet(ref IQueryable<Models.Sortimat.Machine> items);

    partial void OnMachineDeleted(Models.Sortimat.Machine item);

    [HttpDelete("{MachineID}")]
    public IActionResult DeleteMachine(int key)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var item = this.context.Machines
                .Where(i => i.MachineID == key)
                .FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            this.OnMachineDeleted(item);
            this.context.Machines.Remove(item);
            this.context.SaveChanges();

            return new NoContentResult();
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnMachineUpdated(Models.Sortimat.Machine item);

    [HttpPut("{MachineID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PutMachine(int key, [FromBody]Models.Sortimat.Machine newItem)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (newItem == null || (newItem.MachineID != key))
            {
                return BadRequest();
            }

            this.OnMachineUpdated(newItem);
            this.context.Machines.Update(newItem);
            this.context.SaveChanges();

            var itemToReturn = this.context.Machines.Where(i => i.MachineID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    [HttpPatch("{MachineID}")]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult PatchMachine(int key, [FromBody]Delta<Models.Sortimat.Machine> patch)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = this.context.Machines.Where(i => i.MachineID == key).FirstOrDefault();

            if (item == null)
            {
                ModelState.AddModelError("", "Item no longer available");
                return BadRequest(ModelState);
            }

            patch.Patch(item);

            this.OnMachineUpdated(item);
            this.context.Machines.Update(item);
            this.context.SaveChanges();

            var itemToReturn = this.context.Machines.Where(i => i.MachineID == key);
            return new ObjectResult(SingleResult.Create(itemToReturn));
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }

    partial void OnMachineCreated(Models.Sortimat.Machine item);

    [HttpPost]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    public IActionResult Post([FromBody] Models.Sortimat.Machine item)
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

            this.OnMachineCreated(item);
            this.context.Machines.Add(item);
            this.context.SaveChanges();

            return Created($"odata/Sortimat/Machines/{item.MachineID}", item);
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return BadRequest(ModelState);
        }
    }
  }
}
