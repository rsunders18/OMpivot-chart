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

  public partial class PopulateFm1AssemblyReportHourShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public PopulateFm1AssemblyReportHourShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    [HttpGet]
    [ODataRoute("PopulateFm1AssemblyReportHourShiftsFunc()")]
    public IActionResult PopulateFm1AssemblyReportHourShifts()
    {
        try
        {        
            SqlParameter[] @params =
            {
                new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
            };
            this.context.Database.ExecuteSqlRaw("EXEC @returnVal=[ETL].[Populate_FM1_Assembly_ReportHour_Shift]", @params);

            int result = Convert.ToInt32(@params[0].Value);

            this.OnPopulateFm1AssemblyReportHourShiftsInvoke(ref result);

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

    partial void OnPopulateFm1AssemblyReportHourShiftsInvoke(ref int result);
  }
}
