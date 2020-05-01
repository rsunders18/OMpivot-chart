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

  [ODataRoutePrefix("odata/Sortimat/DailyProductionShifts")]
  [Route("mvc/odata/Sortimat/DailyProductionShifts")]
  public partial class DailyProductionShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public DailyProductionShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/DailyProductionShifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.DailyProductionShift> GetDailyProductionShifts()
    {
      var items = this.context.DailyProductionShifts.AsNoTracking().AsQueryable<Models.Sortimat.DailyProductionShift>();
      this.OnDailyProductionShiftsRead(ref items);

      return items;
    }

    partial void OnDailyProductionShiftsRead(ref IQueryable<Models.Sortimat.DailyProductionShift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Machine}")]
    public SingleResult<DailyProductionShift> GetDailyProductionShift(string key)
    {
        var items = this.context.DailyProductionShifts.AsNoTracking().Where(i=>i.Machine == key);
        this.OnDailyProductionShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnDailyProductionShiftsGet(ref IQueryable<Models.Sortimat.DailyProductionShift> items);

  }
}
