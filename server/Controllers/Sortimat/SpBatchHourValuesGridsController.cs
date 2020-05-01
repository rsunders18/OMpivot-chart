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

  public partial class SpBatchHourValuesGridsController : ODataController
  {
    private Data.SortimatContext context;

    public SpBatchHourValuesGridsController(Data.SortimatContext context)
    {
      this.context = context;
    }

    [HttpGet]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [ODataRoute("SpBatchHourValuesGridsFunc(MAchineID={MAchineID},BatchID={BatchID},TagGroup={TagGroup},TagType={TagType})")]
    public IActionResult SpBatchHourValuesGridsFunc([FromODataUri] int? MAchineID, [FromODataUri] string BatchID, [FromODataUri] string TagGroup, [FromODataUri] string TagType)
    {
        try
        {
            this.OnSpBatchHourValuesGridsDefaultParams(ref MAchineID, ref BatchID, ref TagGroup, ref TagType);
            var items = this.context.SpBatchHourValuesGrids.FromSqlRaw("EXEC [App].[sp_BatchHourValuesGrid] @MAchineID={0}, @BatchID={1}, @TagGroup={2}, @TagType={3}", MAchineID, BatchID, TagGroup, TagType).AsNoTracking().ToList().AsQueryable();

            this.OnSpBatchHourValuesGridsInvoke(ref items);

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

    partial void OnSpBatchHourValuesGridsDefaultParams(ref int? MAchineID, ref string BatchID, ref string TagGroup, ref string TagType);

    partial void OnSpBatchHourValuesGridsInvoke(ref IQueryable<Models.Sortimat.SpBatchHourValuesGrid> items);
  }
}
