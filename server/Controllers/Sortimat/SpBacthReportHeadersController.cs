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

  public partial class SpBacthReportHeadersController : ODataController
  {
    private Data.SortimatContext context;

    public SpBacthReportHeadersController(Data.SortimatContext context)
    {
      this.context = context;
    }

    [HttpGet]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [ODataRoute("SpBacthReportHeadersFunc(MachineID={MachineID},BatchID={BatchID})")]
    public IActionResult SpBacthReportHeadersFunc([FromODataUri] int? MachineID, [FromODataUri] string BatchID)
    {
        try
        {
            this.OnSpBacthReportHeadersDefaultParams(ref MachineID, ref BatchID);
            var items = this.context.SpBacthReportHeaders.FromSqlRaw("EXEC [App].[sp_BacthReportHeader] @MachineID={0}, @BatchID={1}", MachineID, BatchID).AsNoTracking().ToList().AsQueryable();

            this.OnSpBacthReportHeadersInvoke(ref items);

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

    partial void OnSpBacthReportHeadersDefaultParams(ref int? MachineID, ref string BatchID);

    partial void OnSpBacthReportHeadersInvoke(ref IQueryable<Models.Sortimat.SpBacthReportHeader> items);
  }
}
