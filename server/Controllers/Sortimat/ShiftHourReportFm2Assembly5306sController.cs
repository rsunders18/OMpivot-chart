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

  public partial class ShiftHourReportFm2Assembly5306sController : ODataController
  {
    private Data.SortimatContext context;

    public ShiftHourReportFm2Assembly5306sController(Data.SortimatContext context)
    {
      this.context = context;
    }
    [HttpGet]
    [ODataRoute("ShiftHourReportFm2Assembly5306sFunc()")]
    public IActionResult ShiftHourReportFm2Assembly5306s()
    {
        try
        {        
            SqlParameter[] @params =
            {
                new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
            };
            this.context.Database.ExecuteSqlRaw("EXEC @returnVal=[ETL].[ShiftHourReport_FM2_Assembly_5306]", @params);

            int result = Convert.ToInt32(@params[0].Value);

            this.OnShiftHourReportFm2Assembly5306sInvoke(ref result);

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

    partial void OnShiftHourReportFm2Assembly5306sInvoke(ref int result);
  }
}
