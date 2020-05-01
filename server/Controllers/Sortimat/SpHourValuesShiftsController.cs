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

  public partial class SpHourValuesShiftsController : ODataController
  {
    private Data.SortimatContext context;

    public SpHourValuesShiftsController(Data.SortimatContext context)
    {
      this.context = context;
    }

    [HttpGet]
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [ODataRoute("SpHourValuesShiftsFunc(MAchineID={MAchineID},BatchID={BatchID},Shift={Shift},TagGroup={TagGroup},TagType={TagType})")]
    public IActionResult SpHourValuesShiftsFunc([FromODataUri] int? MAchineID, [FromODataUri] string BatchID, [FromODataUri] string Shift, [FromODataUri] string TagGroup, [FromODataUri] string TagType)
    {
        try
        {
            this.OnSpHourValuesShiftsDefaultParams(ref MAchineID, ref BatchID, ref Shift, ref TagGroup, ref TagType);
            var items = this.context.SpHourValuesShifts.FromSqlRaw("EXEC [App].[sp_HourValuesShift] @MAchineID={0}, @BatchID={1}, @Shift={2}, @TagGroup={3}, @TagType={4}", MAchineID, BatchID, Shift, TagGroup, TagType).AsNoTracking().ToList().AsQueryable();

            this.OnSpHourValuesShiftsInvoke(ref items);

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

    partial void OnSpHourValuesShiftsDefaultParams(ref int? MAchineID, ref string BatchID, ref string Shift, ref string TagGroup, ref string TagType);

    partial void OnSpHourValuesShiftsInvoke(ref IQueryable<Models.Sortimat.SpHourValuesShift> items);
  }
}
