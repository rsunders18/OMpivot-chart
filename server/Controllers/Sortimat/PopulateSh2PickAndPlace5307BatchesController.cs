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

  public partial class PopulateSh2PickAndPlace5307BatchesController : ODataController
  {
    private Data.SortimatContext context;

    public PopulateSh2PickAndPlace5307BatchesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    [HttpGet]
    [ODataRoute("PopulateSh2PickAndPlace5307BatchesFunc()")]
    public IActionResult PopulateSh2PickAndPlace5307Batches()
    {
        try
        {        
            SqlParameter[] @params =
            {
                new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
            };
            this.context.Database.ExecuteSqlRaw("EXEC @returnVal=[ETL].[Populate_SH2_PickAndPlace_5307_Batch]", @params);

            int result = Convert.ToInt32(@params[0].Value);

            this.OnPopulateSh2PickAndPlace5307BatchesInvoke(ref result);

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

    partial void OnPopulateSh2PickAndPlace5307BatchesInvoke(ref int result);
  }
}
