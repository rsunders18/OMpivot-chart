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

  public partial class ShiftReportDashTimersController : ODataController
  {
    private Data.SortimatContext context;

    public ShiftReportDashTimersController(Data.SortimatContext context)
    {
      this.context = context;
    }

    [HttpGet]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [ODataRoute("ShiftReportDashTimersFunc(MachineID={MachineID},BatchID={BatchID},Shift={Shift})")]
    public IActionResult ShiftReportDashTimersFunc([FromODataUri] int? MachineID, [FromODataUri] string BatchID, [FromODataUri] string Shift)
    {
        try
        {
            this.OnShiftReportDashTimersDefaultParams(ref MachineID, ref BatchID, ref Shift);
            var items = this.context.ShiftReportDashTimers.FromSqlRaw("EXEC [App].[ShiftReportDashTimers] @MachineID={0}, @BatchID={1}, @Shift={2}", MachineID, BatchID, Shift).AsNoTracking().ToList().AsQueryable();

            this.OnShiftReportDashTimersInvoke(ref items);

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

    partial void OnShiftReportDashTimersDefaultParams(ref int? MachineID, ref string BatchID, ref string Shift);

    partial void OnShiftReportDashTimersInvoke(ref IQueryable<Models.Sortimat.ShiftReportDashTimer> items);
  }
}
