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

  public partial class PopulateAbbvieSh2PickAndPlace5307ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public PopulateAbbvieSh2PickAndPlace5307ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    [HttpGet]
    [ODataRoute("PopulateAbbvieSh2PickAndPlace5307ShiftsFunc()")]
    public IActionResult PopulateAbbvieSh2PickAndPlace5307Shifts()
    {
        try
        {        
            SqlParameter[] @params =
            {
                new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
            };
            this.context.Database.ExecuteSqlRaw("EXEC @returnVal=[ETL].[Populate_Abbvie_SH2_PickAndPlace_5307_Shift]", @params);

            int result = Convert.ToInt32(@params[0].Value);

            this.OnPopulateAbbvieSh2PickAndPlace5307ShiftsInvoke(ref result);

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

    partial void OnPopulateAbbvieSh2PickAndPlace5307ShiftsInvoke(ref int result);
  }
}
