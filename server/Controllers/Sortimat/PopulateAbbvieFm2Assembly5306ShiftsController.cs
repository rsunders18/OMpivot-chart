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

  public partial class PopulateAbbvieFm2Assembly5306ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public PopulateAbbvieFm2Assembly5306ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    [HttpGet]
    [ODataRoute("PopulateAbbvieFm2Assembly5306ShiftsFunc()")]
    public IActionResult PopulateAbbvieFm2Assembly5306Shifts()
    {
        try
        {        
            SqlParameter[] @params =
            {
                new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
            };
            this.context.Database.ExecuteSqlRaw("EXEC @returnVal=[ETL].[Populate_Abbvie_FM2_Assembly_5306_Shift]", @params);

            int result = Convert.ToInt32(@params[0].Value);

            this.OnPopulateAbbvieFm2Assembly5306ShiftsInvoke(ref result);

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

    partial void OnPopulateAbbvieFm2Assembly5306ShiftsInvoke(ref int result);
  }
}
