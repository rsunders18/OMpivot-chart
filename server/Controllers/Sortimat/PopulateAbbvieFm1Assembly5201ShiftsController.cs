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

  public partial class PopulateAbbvieFm1Assembly5201ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public PopulateAbbvieFm1Assembly5201ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    [HttpGet]
    [ODataRoute("PopulateAbbvieFm1Assembly5201ShiftsFunc()")]
    public IActionResult PopulateAbbvieFm1Assembly5201Shifts()
    {
        try
        {        
            SqlParameter[] @params =
            {
                new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
            };
            this.context.Database.ExecuteSqlRaw("EXEC @returnVal=[ETL].[Populate_Abbvie_FM1_Assembly_5201_Shift]", @params);

            int result = Convert.ToInt32(@params[0].Value);

            this.OnPopulateAbbvieFm1Assembly5201ShiftsInvoke(ref result);

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

    partial void OnPopulateAbbvieFm1Assembly5201ShiftsInvoke(ref int result);
  }
}
