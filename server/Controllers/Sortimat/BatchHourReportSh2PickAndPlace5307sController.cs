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

  public partial class BatchHourReportSh2PickAndPlace5307sController : ODataController
  {
    private Data.SortimatContext context;

    public BatchHourReportSh2PickAndPlace5307sController(Data.SortimatContext context)
    {
      this.context = context;
    }
    [HttpGet]
    [ODataRoute("BatchHourReportSh2PickAndPlace5307sFunc()")]
    public IActionResult BatchHourReportSh2PickAndPlace5307s()
    {
        try
        {        
            SqlParameter[] @params =
            {
                new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
            };
            this.context.Database.ExecuteSqlRaw("EXEC @returnVal=[ETL].[BatchHourReport_SH2_PickAndPlace_5307]", @params);

            int result = Convert.ToInt32(@params[0].Value);

            this.OnBatchHourReportSh2PickAndPlace5307sInvoke(ref result);

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

    partial void OnBatchHourReportSh2PickAndPlace5307sInvoke(ref int result);
  }
}