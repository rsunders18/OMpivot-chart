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

  [ODataRoutePrefix("odata/Sortimat/OmPadShPerShiftPerCycles")]
  [Route("mvc/odata/Sortimat/OmPadShPerShiftPerCycles")]
  public partial class OmPadShPerShiftPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public OmPadShPerShiftPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/OmPadShPerShiftPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.OmPadShPerShiftPerCycle> GetOmPadShPerShiftPerCycles()
    {
      var items = this.context.OmPadShPerShiftPerCycles.AsNoTracking().AsQueryable<Models.Sortimat.OmPadShPerShiftPerCycle>();
      this.OnOmPadShPerShiftPerCyclesRead(ref items);

      return items;
    }

    partial void OnOmPadShPerShiftPerCyclesRead(ref IQueryable<Models.Sortimat.OmPadShPerShiftPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{id}")]
    public SingleResult<OmPadShPerShiftPerCycle> GetOmPadShPerShiftPerCycle(int key)
    {
        var items = this.context.OmPadShPerShiftPerCycles.AsNoTracking().Where(i=>i.id == key);
        this.OnOmPadShPerShiftPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnOmPadShPerShiftPerCyclesGet(ref IQueryable<Models.Sortimat.OmPadShPerShiftPerCycle> items);

  }
}
