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

  [ODataRoutePrefix("odata/Sortimat/OmPadLpcPerShiftPerCycles")]
  [Route("mvc/odata/Sortimat/OmPadLpcPerShiftPerCycles")]
  public partial class OmPadLpcPerShiftPerCyclesController : ODataController
  {
    private Data.SortimatContext context;

    public OmPadLpcPerShiftPerCyclesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/OmPadLpcPerShiftPerCycles
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.OmPadLpcPerShiftPerCycle> GetOmPadLpcPerShiftPerCycles()
    {
      var items = this.context.OmPadLpcPerShiftPerCycles.AsNoTracking().AsQueryable<Models.Sortimat.OmPadLpcPerShiftPerCycle>();
      this.OnOmPadLpcPerShiftPerCyclesRead(ref items);

      return items;
    }

    partial void OnOmPadLpcPerShiftPerCyclesRead(ref IQueryable<Models.Sortimat.OmPadLpcPerShiftPerCycle> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{id}")]
    public SingleResult<OmPadLpcPerShiftPerCycle> GetOmPadLpcPerShiftPerCycle(int key)
    {
        var items = this.context.OmPadLpcPerShiftPerCycles.AsNoTracking().Where(i=>i.id == key);
        this.OnOmPadLpcPerShiftPerCyclesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnOmPadLpcPerShiftPerCyclesGet(ref IQueryable<Models.Sortimat.OmPadLpcPerShiftPerCycle> items);

  }
}
