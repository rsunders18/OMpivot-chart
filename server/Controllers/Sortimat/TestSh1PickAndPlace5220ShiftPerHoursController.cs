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

  [ODataRoutePrefix("odata/Sortimat/TestSh1PickAndPlace5220ShiftPerHours")]
  [Route("mvc/odata/Sortimat/TestSh1PickAndPlace5220ShiftPerHours")]
  public partial class TestSh1PickAndPlace5220ShiftPerHoursController : ODataController
  {
    private Data.SortimatContext context;

    public TestSh1PickAndPlace5220ShiftPerHoursController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/TestSh1PickAndPlace5220ShiftPerHours
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.TestSh1PickAndPlace5220ShiftPerHour> GetTestSh1PickAndPlace5220ShiftPerHours()
    {
      var items = this.context.TestSh1PickAndPlace5220ShiftPerHours.AsNoTracking().AsQueryable<Models.Sortimat.TestSh1PickAndPlace5220ShiftPerHour>();
      this.OnTestSh1PickAndPlace5220ShiftPerHoursRead(ref items);

      return items;
    }

    partial void OnTestSh1PickAndPlace5220ShiftPerHoursRead(ref IQueryable<Models.Sortimat.TestSh1PickAndPlace5220ShiftPerHour> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RecordedOnDate}")]
    public SingleResult<TestSh1PickAndPlace5220ShiftPerHour> GetTestSh1PickAndPlace5220ShiftPerHour(DateTime? key)
    {
        var items = this.context.TestSh1PickAndPlace5220ShiftPerHours.AsNoTracking().Where(i=>i.RecordedOnDate == key);
        this.OnTestSh1PickAndPlace5220ShiftPerHoursGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnTestSh1PickAndPlace5220ShiftPerHoursGet(ref IQueryable<Models.Sortimat.TestSh1PickAndPlace5220ShiftPerHour> items);

  }
}
