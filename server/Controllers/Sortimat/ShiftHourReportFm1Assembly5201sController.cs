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

  public partial class ShiftHourReportFm1Assembly5201sController : ODataController
  {
    private Data.SortimatContext context;

    public ShiftHourReportFm1Assembly5201sController(Data.SortimatContext context)
    {
      this.context = context;
    }
    [HttpGet]
    [ODataRoute("ShiftHourReportFm1Assembly5201sFunc()")]
    public IActionResult ShiftHourReportFm1Assembly5201s()
    {
        try
        {        
            SqlParameter[] @params =
            {
                new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
            };
            this.context.Database.ExecuteSqlRaw("EXEC @returnVal=[ETL].[ShiftHourReport_FM1_Assembly_5201]", @params);

            int result = Convert.ToInt32(@params[0].Value);

            this.OnShiftHourReportFm1Assembly5201sInvoke(ref result);

            return Ok(result);
        }
        catch(Exception ex)
        {
            return new ObjectResult(new { message = ex.Message})
            {
                StatusCode = 400
            };
        }
    }

    partial void OnShiftHourReportFm1Assembly5201sInvoke(ref int result);
  }
}
