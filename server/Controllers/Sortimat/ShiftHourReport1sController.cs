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

  public partial class ShiftHourReport1sController : ODataController
  {
    private Data.SortimatContext context;

    public ShiftHourReport1sController(Data.SortimatContext context)
    {
      this.context = context;
    }

    [HttpGet]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [ODataRoute("ShiftHourReport1sFunc(BatchID={BatchID},MachineID={MachineID},Shift={Shift})")]
    public IActionResult ShiftHourReport1sFunc([FromODataUri] string BatchID, [FromODataUri] int? MachineID, [FromODataUri] string Shift)
    {
        try
        {
            this.OnShiftHourReport1sDefaultParams(ref BatchID, ref MachineID, ref Shift);
            var items = this.context.ShiftHourReport1s.FromSqlRaw("EXEC [SSRS].[ShiftHourReport] @BatchID={0}, @MachineID={1}, @Shift={2}", BatchID, MachineID, Shift).AsNoTracking().ToList().AsQueryable();

            this.OnShiftHourReport1sInvoke(ref items);

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

    partial void OnShiftHourReport1sDefaultParams(ref string BatchID, ref int? MachineID, ref string Shift);

    partial void OnShiftHourReport1sInvoke(ref IQueryable<Models.Sortimat.ShiftHourReport1> items);
  }
}
