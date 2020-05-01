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

  public partial class ShiftHourReportSh1Assembly5202sController : ODataController
  {
    private Data.SortimatContext context;

    public ShiftHourReportSh1Assembly5202sController(Data.SortimatContext context)
    {
      this.context = context;
    }
    [HttpGet]
    [ODataRoute("ShiftHourReportSh1Assembly5202sFunc()")]
    public IActionResult ShiftHourReportSh1Assembly5202s()
    {
        try
        {        
            SqlParameter[] @params =
            {
                new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
            };
            this.context.Database.ExecuteSqlRaw("EXEC @returnVal=[ETL].[ShiftHourReport_SH1_Assembly_5202]", @params);

            int result = Convert.ToInt32(@params[0].Value);

            this.OnShiftHourReportSh1Assembly5202sInvoke(ref result);

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

    partial void OnShiftHourReportSh1Assembly5202sInvoke(ref int result);
  }
}
