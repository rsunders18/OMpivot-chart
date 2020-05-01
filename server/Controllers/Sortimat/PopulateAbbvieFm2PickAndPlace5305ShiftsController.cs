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

  public partial class PopulateAbbvieFm2PickAndPlace5305ShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public PopulateAbbvieFm2PickAndPlace5305ShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    [HttpGet]
    [ODataRoute("PopulateAbbvieFm2PickAndPlace5305ShiftsFunc()")]
    public IActionResult PopulateAbbvieFm2PickAndPlace5305Shifts()
    {
        try
        {        
            SqlParameter[] @params =
            {
                new SqlParameter("@returnVal", SqlDbType.Int) {Direction = ParameterDirection.Output},
            };
            this.context.Database.ExecuteSqlRaw("EXEC @returnVal=[ETL].[Populate_Abbvie_FM2_PickAndPlace_5305_Shift]", @params);

            int result = Convert.ToInt32(@params[0].Value);

            this.OnPopulateAbbvieFm2PickAndPlace5305ShiftsInvoke(ref result);

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

    partial void OnPopulateAbbvieFm2PickAndPlace5305ShiftsInvoke(ref int result);
  }
}
