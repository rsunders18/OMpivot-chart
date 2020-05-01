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

  public partial class SpShiftReportDashesController : ODataController
  {
    private Data.SortimatContext context;

    public SpShiftReportDashesController(Data.SortimatContext context)
    {
      this.context = context;
    }

    [HttpGet]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [ODataRoute("SpShiftReportDashesFunc()")]
    public IActionResult SpShiftReportDashes()
    {
        try
        {
            var items = this.context.SpShiftReportDashes.FromSqlRaw("EXEC [App].[sp_ShiftReportDash]").AsNoTracking().ToList().AsQueryable();

            this.OnSpShiftReportDashesInvoke(ref items);

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

    partial void OnSpShiftReportDashesInvoke(ref IQueryable<Models.Sortimat.SpShiftReportDash> items);
  }
}
