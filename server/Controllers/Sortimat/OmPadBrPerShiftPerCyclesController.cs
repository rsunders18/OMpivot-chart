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

  [ODataRoutePrefix("odata/Sortimat/OmPadBrPerShiftPerCycles")]
  [Route("mvc/odata/Sortimat/OmPadBrPerShiftPerCycles")]
  public partial class OmPadBrPerShiftPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public OmPadBrPerShiftPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/OmPadBrPerShiftPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.OmPadBrPerShiftPerCycle> GetOmPadBrPerShiftPerCycles()
    {
      var items = this.context.OmPadBrPerShiftPerCycles.AsNoTracking().AsQueryable<Models.Sortimat.OmPadBrPerShiftPerCycle>();
      this.OnOmPadBrPerShiftPerCyclesRead(ref items);

      return items;
    }

    partial void OnOmPadBrPerShiftPerCyclesRead(ref IQueryable<Models.Sortimat.OmPadBrPerShiftPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{id}")]
    public SingleResult<OmPadBrPerShiftPerCycle> GetOmPadBrPerShiftPerCycle(int key)
    {
        var items = this.context.OmPadBrPerShiftPerCycles.AsNoTracking().Where(i=>i.id == key);
        this.OnOmPadBrPerShiftPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnOmPadBrPerShiftPerCyclesGet(ref IQueryable<Models.Sortimat.OmPadBrPerShiftPerCycle> items);

  }
}
