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

  public partial class ShiftReportDashTotalGodBadsController : ODataController
  {
    private Data.SortimatContext context;

    public ShiftReportDashTotalGodBadsController(Data.SortimatContext context)
    {
      this.context = context;
    }

    [HttpGet]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [ODataRoute("ShiftReportDashTotalGodBadsFunc(MachineID={MachineID},BatchID={BatchID},Shift={Shift})")]
    public IActionResult ShiftReportDashTotalGodBadsFunc([FromODataUri] int? MachineID, [FromODataUri] string BatchID, [FromODataUri] string Shift)
    {
        try
        {
            this.OnShiftReportDashTotalGodBadsDefaultParams(ref MachineID, ref BatchID, ref Shift);
            var items = this.context.ShiftReportDashTotalGodBads.FromSqlRaw("EXEC [App].[ShiftReportDashTotalGodBad] @MachineID={0}, @BatchID={1}, @Shift={2}", MachineID, BatchID, Shift).AsNoTracking().ToList().AsQueryable();

            this.OnShiftReportDashTotalGodBadsInvoke(ref items);

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

    partial void OnShiftReportDashTotalGodBadsDefaultParams(ref int? MachineID, ref string BatchID, ref string Shift);

    partial void OnShiftReportDashTotalGodBadsInvoke(ref IQueryable<Models.Sortimat.ShiftReportDashTotalGodBad> items);
  }
}
