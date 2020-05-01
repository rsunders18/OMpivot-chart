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

  public partial class SpShiftHourValuesGridsController : ODataController
  {
    private Data.SortimatContext context;

    public SpShiftHourValuesGridsController(Data.SortimatContext context)
    {
      this.context = context;
    }

    [HttpGet]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [ODataRoute("SpShiftHourValuesGridsFunc(MAchineID={MAchineID},BatchID={BatchID},Shift={Shift},TagType={TagType})")]
    public IActionResult SpShiftHourValuesGridsFunc([FromODataUri] int? MAchineID, [FromODataUri] string BatchID, [FromODataUri] string Shift, [FromODataUri] string TagType)
    {
        try
        {
            this.OnSpShiftHourValuesGridsDefaultParams(ref MAchineID, ref BatchID, ref Shift, ref TagType);
            var items = this.context.SpShiftHourValuesGrids.FromSqlRaw("EXEC [App].[sp_ShiftHourValuesGrid] @MAchineID={0}, @BatchID={1}, @Shift={2}, @TagType={3}", MAchineID, BatchID, Shift, TagType).AsNoTracking().ToList().AsQueryable();

            this.OnSpShiftHourValuesGridsInvoke(ref items);

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

    partial void OnSpShiftHourValuesGridsDefaultParams(ref int? MAchineID, ref string BatchID, ref string Shift, ref string TagType);

    partial void OnSpShiftHourValuesGridsInvoke(ref IQueryable<Models.Sortimat.SpShiftHourValuesGrid> items);
  }
}
