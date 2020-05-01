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
  using Models;
  using Data;
  using Models.Sortimat;

  public partial class SpHourValuesController : ODataController
  {
    private Data.SortimatContext context;

    public SpHourValuesController(Data.SortimatContext context)
    {
      this.context = context;
    }

    [HttpGet]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [ODataRoute("SpHourValuesFunc(MAchineID={MAchineID},BatchID={BatchID},TagGroup={TagGroup},TagType={TagType})")]
    public IActionResult SpHourValuesFunc([FromODataUri] int? MAchineID, [FromODataUri] string BatchID, [FromODataUri] string TagGroup, [FromODataUri] string TagType)
    {
        try
        {
            this.OnSpHourValuesDefaultParams(ref MAchineID, ref BatchID, ref TagGroup, ref TagType);
            var items = this.context.SpHourValues.FromSqlRaw("EXEC [App].[sp_HourValues] @MAchineID={0}, @BatchID={1}, @TagGroup={2}, @TagType={3}", MAchineID, BatchID, TagGroup, TagType).AsNoTracking().ToList().AsQueryable();

            this.OnSpHourValuesInvoke(ref items);

            return Ok(items);
        }
        catch(Exception ex)
        {
            return new ObjectResult(new { message = ex.Message})
            {
                StatusCode = 400
            };
        }
    }

    partial void OnSpHourValuesDefaultParams(ref int? MAchineID, ref string BatchID, ref string TagGroup, ref string TagType);

    partial void OnSpHourValuesInvoke(ref IQueryable<Models.Sortimat.SpHourValue> items);
  }
}
