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

  [ODataRoutePrefix("odata/Sortimat/VChartData")]
  [Route("mvc/odata/Sortimat/VChartData")]
  public partial class VChartDataController : ODataController
  {
    private Data.SortimatContext context;

    public VChartDataController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/VChartData
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.VChartDatum> GetVChartData()
    {
      var items = this.context.VChartData.AsNoTracking().AsQueryable<Models.Sortimat.VChartDatum>();
      this.OnVChartDataRead(ref items);

      return items;
    }

    partial void OnVChartDataRead(ref IQueryable<Models.Sortimat.VChartDatum> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<VChartDatum> GetVChartDatum(int key)
    {
        var items = this.context.VChartData.AsNoTracking().Where(i=>i.RowID == key);
        this.OnVChartDataGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnVChartDataGet(ref IQueryable<Models.Sortimat.VChartDatum> items);

  }
}
