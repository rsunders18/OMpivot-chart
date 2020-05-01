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

  [ODataRoutePrefix("odata/Sortimat/VBacthReportHeaderRows")]
  [Route("mvc/odata/Sortimat/VBacthReportHeaderRows")]
  public partial class VBacthReportHeaderRowsController : ODataController
  {
    private Data.SortimatContext context;

    public VBacthReportHeaderRowsController(Data.SortimatContext context)
    {
      this.context = context;
    }
    // GET /odata/Sortimat/VBacthReportHeaderRows
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.Sortimat.VBacthReportHeaderRow> GetVBacthReportHeaderRows()
    {
      var items = this.context.VBacthReportHeaderRows.AsNoTracking().AsQueryable<Models.Sortimat.VBacthReportHeaderRow>();
      this.OnVBacthReportHeaderRowsRead(ref items);

      return items;
    }

    partial void OnVBacthReportHeaderRowsRead(ref IQueryable<Models.Sortimat.VBacthReportHeaderRow> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{RowID}")]
    public SingleResult<VBacthReportHeaderRow> GetVBacthReportHeaderRow(int key)
    {
        var items = this.context.VBacthReportHeaderRows.AsNoTracking().Where(i=>i.RowID == key);
        this.OnVBacthReportHeaderRowsGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnVBacthReportHeaderRowsGet(ref IQueryable<Models.Sortimat.VBacthReportHeaderRow> items);

  }
}
