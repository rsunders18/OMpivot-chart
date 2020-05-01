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

  public partial class PopulateSh2Assembly5308BatchesController : ODataController
  {
    private Data.SortimatContext context;

    public PopulateSh2Assembly5308BatchesController(Data.SortimatContext context)
    {
      this.context = context;
    }
    [HttpGet]
    [ODataRoute("PopulateSh2Assembly5308BatchesFunc()")]
    public IActionResult PopulateSh2Assembly5308Batches()
    {
        try
        {        
            SqlParameter[] @params =
            {
                new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
            };
            this.context.Database.ExecuteSqlRaw("EXEC @returnVal=[ETL].[Populate_SH2_Assembly_5308_Batch]", @params);

            int result = Convert.ToInt32(@params[0].Value);

            this.OnPopulateSh2Assembly5308BatchesInvoke(ref result);

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

    partial void OnPopulateSh2Assembly5308BatchesInvoke(ref int result);
  }
}
