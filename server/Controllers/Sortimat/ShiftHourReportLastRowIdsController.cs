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

  public partial class ShiftHourReportLastRowIdsController : ODataController
  {
    private Data.SortimatContext context;

    public ShiftHourReportLastRowIdsController(Data.SortimatContext context)
    {
      this.context = context;
    }

    [HttpGet]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [ODataRoute("ShiftHourReportLastRowIdsFunc(LastRowID={LastRowID})")]
    public IActionResult ShiftHourReportLastRowIdsFunc([FromODataUri] int? LastRowID)
    {
        try
        {
            this.OnShiftHourReportLastRowIdsDefaultParams(ref LastRowID);
            var items = this.context.ShiftHourReportLastRowIds.FromSqlRaw("EXEC [SSRS].[ShiftHourReportLastRowID] @LastRowID={0}", LastRowID).AsNoTracking().ToList().AsQueryable();

            this.OnShiftHourReportLastRowIdsInvoke(ref items);

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

    partial void OnShiftHourReportLastRowIdsDefaultParams(ref int? LastRowID);

    partial void OnShiftHourReportLastRowIdsInvoke(ref IQueryable<Models.Sortimat.ShiftHourReportLastRowId> items);
  }
}
