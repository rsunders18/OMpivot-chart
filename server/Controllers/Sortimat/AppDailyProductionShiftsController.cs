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

  [ODataRoutePrefix("odata/Sortimat/AppDailyProductionShifts")]
  [Route("mvc/odata/Sortimat/AppDailyProductionShifts")]
  public partial class AppDailyProductionShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public AppDailyProductionShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/AppDailyProductionShifts
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.AppDailyProductionShift> GetAppDailyProductionShifts()
    {
      var items = this.context.AppDailyProductionShifts.AsNoTracking().AsQueryable<Models.Sortimat.AppDailyProductionShift>();
      this.OnAppDailyProductionShiftsRead(ref items);

      return items;
    }

    partial void OnAppDailyProductionShiftsRead(ref IQueryable<Models.Sortimat.AppDailyProductionShift> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{Date}")]
    public SingleResult<AppDailyProductionShift> GetAppDailyProductionShift(DateTime key)
    {
        var items = this.context.AppDailyProductionShifts.AsNoTracking().Where(i=>i.Date == key);
        this.OnAppDailyProductionShiftsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnAppDailyProductionShiftsGet(ref IQueryable<Models.Sortimat.AppDailyProductionShift> items);

  }
}
