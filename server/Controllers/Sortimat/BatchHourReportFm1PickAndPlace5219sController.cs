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

  public partial class BatchHourReportFm1PickAndPlace5219sController : ODataController
  {
    private Data.SortimatContext context;

    public BatchHourReportFm1PickAndPlace5219sController(Data.SortimatContext context)
    {
      this.context = context;
    }
    [HttpGet]
    [ODataRoute("BatchHourReportFm1PickAndPlace5219sFunc()")]
    public IActionResult BatchHourReportFm1PickAndPlace5219s()
    {
        try
        {        
            SqlParameter[] @params =
            {
                new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
            };
            this.context.Database.ExecuteSqlRaw("EXEC @returnVal=[ETL].[BatchHourReport_FM1_PickAndPlace_5219]", @params);

            int result = Convert.ToInt32(@params[0].Value);

            this.OnBatchHourReportFm1PickAndPlace5219sInvoke(ref result);

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

    partial void OnBatchHourReportFm1PickAndPlace5219sInvoke(ref int result);
  }
}
