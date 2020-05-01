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

  public partial class ChartDataController : ODataController
  {
    private Data.SortimatContext context;

    public ChartDataController(Data.SortimatContext context)
    {
      this.context = context;
    }

    [HttpGet]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [ODataRoute("ChartDataFunc(MachineID={MachineID},TagGroup={TagGroup},TagType={TagType})")]
    public IActionResult ChartDataFunc([FromODataUri] int? MachineID, [FromODataUri] string TagGroup, [FromODataUri] string TagType)
    {
        try
        {
            this.OnChartDataDefaultParams(ref MachineID, ref TagGroup, ref TagType);
            var items = this.context.ChartData.FromSqlRaw("EXEC [App].[ChartData] @MachineID={0}, @TagGroup={1}, @TagType={2}", MachineID, TagGroup, TagType).AsNoTracking().ToList().AsQueryable();

            this.OnChartDataInvoke(ref items);

            return Ok(items);
        }
        catch(Exception ex)
        {
            return new ObjectResult(new { message = ex.Message})
            {
                StatusCode = 400
            };
        }
    }

    partial void OnChartDataDefaultParams(ref int? MachineID, ref string TagGroup, ref string TagType);

    partial void OnChartDataInvoke(ref IQueryable<Models.Sortimat.ChartDatum> items);
  }
}
