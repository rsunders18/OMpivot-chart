using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Builder;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Hosting;

using DataAnalysis.Data;

namespace DataAnalysis
{
  public partial class Startup
  {
    public Startup(IConfiguration configuration, IWebHostEnvironment env)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    partial void OnConfigureServices(IServiceCollection services);

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddOptions();
      services.AddLogging(logging =>
      {
          logging.AddConsole();
          logging.AddDebug();
      });

      services.AddCors(options =>
      {
          options.AddPolicy(
              "AllowAny",
              x =>
              {
                  x.AllowAnyHeader()
                  .AllowAnyMethod()
                  .SetIsOriginAllowed(isOriginAllowed: _ => true)
                  .AllowCredentials();
              });
      });
      services.AddMvc(options =>
      {
          options.EnableEndpointRouting = false;

          options.OutputFormatters.Add(new DataAnalysis.Data.XlsDataContractSerializerOutputFormatter());
          options.FormatterMappings.SetMediaTypeMappingForFormat("xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

          options.OutputFormatters.Add(new DataAnalysis.Data.CsvDataContractSerializerOutputFormatter());
          options.FormatterMappings.SetMediaTypeMappingForFormat("csv", "text/csv");
      }).AddNewtonsoftJson();

      services.AddAuthorization();
      services.AddOData();
      services.AddODataQueryFilter();
      services.AddHttpContextAccessor();


      services.AddDbContext<DataAnalysis.Data.SortimatContext>(options =>
      {
        options.UseSqlServer(Configuration.GetConnectionString("SortimatConnection"));
      });

      OnConfigureServices(services);
    }

    partial void OnConfigure(IApplicationBuilder app);
    partial void OnConfigure(IApplicationBuilder app, IWebHostEnvironment env);
    partial void OnConfigureOData(ODataConventionModelBuilder builder);

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {

      IServiceProvider provider = app.ApplicationServices.GetRequiredService<IServiceProvider>();
      app.UseCors("AllowAny");
      app.Use(async (context, next) => {
          if (context.Request.Path.Value == "/__ssrsreport" || context.Request.Path.Value == "/ssrsproxy") {
            await next();
            return;
          }
          await next();
          if ((context.Response.StatusCode == 404 || context.Response.StatusCode == 401) && !Path.HasExtension(context.Request.Path.Value)) {
              context.Request.Path = "/index.html";
              await next();
          }
      });

      app.UseDefaultFiles();
      app.UseStaticFiles();

      app.UseDeveloperExceptionPage();

      app.UseMvc(builder =>
      {
          builder.Count().Filter().OrderBy().Expand().Select().MaxTop(null).SetTimeZoneInfo(TimeZoneInfo.Utc);

          if (env.EnvironmentName == "Development")
          {
              builder.MapRoute(name: "default",
                template: "{controller}/{action}/{id?}",
                defaults: new { controller = "Home", action = "Index" }
              );
          }

          var oDataBuilder = new ODataConventionModelBuilder(provider);

          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.AppDailyProductionShift>("AppDailyProductionShifts");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.BatchHourReport>("BatchHourReports");

          var batchHourReportFm1Assembly5201S = oDataBuilder.Function("BatchHourReportFm1Assembly5201sFunc");
          batchHourReportFm1Assembly5201S.Returns(typeof(int));

          var batchHourReportFm1PickAndPlace5219S = oDataBuilder.Function("BatchHourReportFm1PickAndPlace5219sFunc");
          batchHourReportFm1PickAndPlace5219S.Returns(typeof(int));

          var batchHourReportFm2Assembly5306S = oDataBuilder.Function("BatchHourReportFm2Assembly5306sFunc");
          batchHourReportFm2Assembly5306S.Returns(typeof(int));

          var batchHourReportFm2PickAndPlace5305S = oDataBuilder.Function("BatchHourReportFm2PickAndPlace5305sFunc");
          batchHourReportFm2PickAndPlace5305S.Returns(typeof(int));

          var batchHourReportSh1Assembly5202S = oDataBuilder.Function("BatchHourReportSh1Assembly5202sFunc");
          batchHourReportSh1Assembly5202S.Returns(typeof(int));

          var batchHourReportSh1PickAndPlace5220S = oDataBuilder.Function("BatchHourReportSh1PickAndPlace5220sFunc");
          batchHourReportSh1PickAndPlace5220S.Returns(typeof(int));

          var batchHourReportSh2Assembly5308S = oDataBuilder.Function("BatchHourReportSh2Assembly5308sFunc");
          batchHourReportSh2Assembly5308S.Returns(typeof(int));

          var batchHourReportSh2PickAndPlace5307S = oDataBuilder.Function("BatchHourReportSh2PickAndPlace5307sFunc");
          batchHourReportSh2PickAndPlace5307S.Returns(typeof(int));

          var batchReportDashTimers = oDataBuilder.Function("BatchReportDashTimersFunc");
          batchReportDashTimers.Parameter<int?>("MachineID");
          batchReportDashTimers.Parameter<string>("BatchID");
          batchReportDashTimers.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.BatchReportDashTimer>("BatchReportDashTimers");

          var batchReportDashTimersGroupeds = oDataBuilder.Function("BatchReportDashTimersGroupedsFunc");
          batchReportDashTimersGroupeds.Parameter<int?>("MachineID");
          batchReportDashTimersGroupeds.Parameter<string>("BatchID");
          batchReportDashTimersGroupeds.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.BatchReportDashTimersGrouped>("BatchReportDashTimersGroupeds");

          var chartData = oDataBuilder.Function("ChartDataFunc");
          chartData.Parameter<int?>("MachineID");
          chartData.Parameter<string>("TagGroup");
          chartData.Parameter<string>("TagType");
          chartData.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.ChartDatum>("ChartData");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.DailyProductionShift>("DailyProductionShifts");

          var dashData = oDataBuilder.Function("DashDataFunc");
          dashData.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.DashDatum>("DashData");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Date>("Dates");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm1Assembly5201Batch>("Fm1Assembly5201Batches");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm1Assembly5201Datum>("Fm1Assembly5201Data");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm1Assembly5201PerBatchPerCycle>("Fm1Assembly5201PerBatchPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm1Assembly5201PerShiftPerCycle>("Fm1Assembly5201PerShiftPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm1Assembly5201Shift>("Fm1Assembly5201Shifts");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm1AssemblyReportHourShift>("Fm1AssemblyReportHourShifts");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219Batch>("Fm1PickAndPlace5219Batches");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219Datum>("Fm1PickAndPlace5219Data");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle>("Fm1PickAndPlace5219PerBatchPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle>("Fm1PickAndPlace5219PerShiftPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219ReportHourShift>("Fm1PickAndPlace5219ReportHourShifts");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219Shift>("Fm1PickAndPlace5219Shifts");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm2Assembly5306Batch>("Fm2Assembly5306Batches");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm2Assembly5306Datum>("Fm2Assembly5306Data");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm2Assembly5306PerBatchPerCycle>("Fm2Assembly5306PerBatchPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm2Assembly5306PerShiftPerCycle>("Fm2Assembly5306PerShiftPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm2Assembly5306Shift>("Fm2Assembly5306Shifts");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305Batch>("Fm2PickAndPlace5305Batches");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305Datum>("Fm2PickAndPlace5305Data");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305PerBatchPerCycle>("Fm2PickAndPlace5305PerBatchPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle>("Fm2PickAndPlace5305PerShiftPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305Shift>("Fm2PickAndPlace5305Shifts");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.HourValue>("HourValues");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Machine>("Machines");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>("OmPadBrPerShiftPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>("OmPadLpcPerShiftPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>("OmPadShPerShiftPerCycles");

          var populateAbbvieFm1Assembly5201Batches = oDataBuilder.Function("PopulateAbbvieFm1Assembly5201BatchesFunc");
          populateAbbvieFm1Assembly5201Batches.Returns(typeof(int));

          var populateAbbvieFm1Assembly5201Shifts = oDataBuilder.Function("PopulateAbbvieFm1Assembly5201ShiftsFunc");
          populateAbbvieFm1Assembly5201Shifts.Returns(typeof(int));

          var populateAbbvieFm1PickAndPlace5219Batches = oDataBuilder.Function("PopulateAbbvieFm1PickAndPlace5219BatchesFunc");
          populateAbbvieFm1PickAndPlace5219Batches.Returns(typeof(int));

          var populateAbbvieFm1PickAndPlace5219Shifts = oDataBuilder.Function("PopulateAbbvieFm1PickAndPlace5219ShiftsFunc");
          populateAbbvieFm1PickAndPlace5219Shifts.Returns(typeof(int));

          var populateAbbvieFm2Assembly5306Shifts = oDataBuilder.Function("PopulateAbbvieFm2Assembly5306ShiftsFunc");
          populateAbbvieFm2Assembly5306Shifts.Returns(typeof(int));

          var populateAbbvieFm2PickAndPlace5305Shifts = oDataBuilder.Function("PopulateAbbvieFm2PickAndPlace5305ShiftsFunc");
          populateAbbvieFm2PickAndPlace5305Shifts.Returns(typeof(int));

          var populateAbbvieSh1Assembly5202Shifts = oDataBuilder.Function("PopulateAbbvieSh1Assembly5202ShiftsFunc");
          populateAbbvieSh1Assembly5202Shifts.Returns(typeof(int));

          var populateAbbvieSh1PickAndPlace5220Shifts = oDataBuilder.Function("PopulateAbbvieSh1PickAndPlace5220ShiftsFunc");
          populateAbbvieSh1PickAndPlace5220Shifts.Returns(typeof(int));

          var populateAbbvieSh2Assembly5308Shifts = oDataBuilder.Function("PopulateAbbvieSh2Assembly5308ShiftsFunc");
          populateAbbvieSh2Assembly5308Shifts.Returns(typeof(int));

          var populateAbbvieSh2PickAndPlace5307Shifts = oDataBuilder.Function("PopulateAbbvieSh2PickAndPlace5307ShiftsFunc");
          populateAbbvieSh2PickAndPlace5307Shifts.Returns(typeof(int));

          var populateFm1AssemblyReportHourShifts = oDataBuilder.Function("PopulateFm1AssemblyReportHourShiftsFunc");
          populateFm1AssemblyReportHourShifts.Returns(typeof(int));

          var populateFm1PickAndPlace5219ReportHourShifts = oDataBuilder.Function("PopulateFm1PickAndPlace5219ReportHourShiftsFunc");
          populateFm1PickAndPlace5219ReportHourShifts.Returns(typeof(int));

          var populateFm2Assembly5306Batches = oDataBuilder.Function("PopulateFm2Assembly5306BatchesFunc");
          populateFm2Assembly5306Batches.Returns(typeof(int));

          var populateFm2PickAndPlace5305Batches = oDataBuilder.Function("PopulateFm2PickAndPlace5305BatchesFunc");
          populateFm2PickAndPlace5305Batches.Returns(typeof(int));

          var populateSh1Assembly5202Batches = oDataBuilder.Function("PopulateSh1Assembly5202BatchesFunc");
          populateSh1Assembly5202Batches.Returns(typeof(int));

          var populateSh1Assembly5202Shifts = oDataBuilder.Function("PopulateSh1Assembly5202ShiftsFunc");
          populateSh1Assembly5202Shifts.Returns(typeof(int));

          var populateSh1PickAndPlace5220Batches = oDataBuilder.Function("PopulateSh1PickAndPlace5220BatchesFunc");
          populateSh1PickAndPlace5220Batches.Returns(typeof(int));

          var populateSh2Assembly5308Batches = oDataBuilder.Function("PopulateSh2Assembly5308BatchesFunc");
          populateSh2Assembly5308Batches.Returns(typeof(int));

          var populateSh2PickAndPlace5307Batches = oDataBuilder.Function("PopulateSh2PickAndPlace5307BatchesFunc");
          populateSh2PickAndPlace5307Batches.Returns(typeof(int));
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh1Assembly5202Batch>("Sh1Assembly5202Batches");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh1Assembly5202Datum>("Sh1Assembly5202Data");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh1Assembly5202PerBatchPerCycle>("Sh1Assembly5202PerBatchPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh1Assembly5202PerShiftPerCycle>("Sh1Assembly5202PerShiftPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh1Assembly5202Shift>("Sh1Assembly5202Shifts");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220Batch>("Sh1PickAndPlace5220Batches");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220Datum>("Sh1PickAndPlace5220Data");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle>("Sh1PickAndPlace5220PerBatchPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle>("Sh1PickAndPlace5220PerShiftPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220Shift>("Sh1PickAndPlace5220Shifts");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh2Assembly5308Batch>("Sh2Assembly5308Batches");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh2Assembly5308Datum>("Sh2Assembly5308Data");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh2Assembly5308PerBatchPerCycle>("Sh2Assembly5308PerBatchPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh2Assembly5308PerShiftPerCycle>("Sh2Assembly5308PerShiftPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh2Assembly5308Shift>("Sh2Assembly5308Shifts");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307Batch>("Sh2PickAndPlace5307Batches");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307Datum>("Sh2PickAndPlace5307Data");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307PerBatchPerCycle>("Sh2PickAndPlace5307PerBatchPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307PerShiftPerCycle>("Sh2PickAndPlace5307PerShiftPerCycles");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307Shift>("Sh2PickAndPlace5307Shifts");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Shift>("Shifts");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.ShiftHourReport>("ShiftHourReports");

          var shiftHourReport1S = oDataBuilder.Function("ShiftHourReport1sFunc");
          shiftHourReport1S.Parameter<string>("BatchID");
          shiftHourReport1S.Parameter<int?>("MachineID");
          shiftHourReport1S.Parameter<string>("Shift");
          shiftHourReport1S.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.ShiftHourReport1>("ShiftHourReport1s");

          var shiftHourReportFm1Assembly5201S = oDataBuilder.Function("ShiftHourReportFm1Assembly5201sFunc");
          shiftHourReportFm1Assembly5201S.Returns(typeof(int));

          var shiftHourReportFm1PickAndPlace5219S = oDataBuilder.Function("ShiftHourReportFm1PickAndPlace5219sFunc");
          shiftHourReportFm1PickAndPlace5219S.Returns(typeof(int));

          var shiftHourReportFm2Assembly5306S = oDataBuilder.Function("ShiftHourReportFm2Assembly5306sFunc");
          shiftHourReportFm2Assembly5306S.Returns(typeof(int));

          var shiftHourReportFm2PickAndPlace5305S = oDataBuilder.Function("ShiftHourReportFm2PickAndPlace5305sFunc");
          shiftHourReportFm2PickAndPlace5305S.Returns(typeof(int));

          var shiftHourReportLastRowIds = oDataBuilder.Function("ShiftHourReportLastRowIdsFunc");
          shiftHourReportLastRowIds.Parameter<int?>("LastRowID");
          shiftHourReportLastRowIds.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.ShiftHourReportLastRowId>("ShiftHourReportLastRowIds");

          var shiftHourReportSh1Assembly5202S = oDataBuilder.Function("ShiftHourReportSh1Assembly5202sFunc");
          shiftHourReportSh1Assembly5202S.Returns(typeof(int));

          var shiftHourReportSh1PickAndPlace5220S = oDataBuilder.Function("ShiftHourReportSh1PickAndPlace5220sFunc");
          shiftHourReportSh1PickAndPlace5220S.Returns(typeof(int));

          var shiftHourReportSh2Assembly5308S = oDataBuilder.Function("ShiftHourReportSh2Assembly5308sFunc");
          shiftHourReportSh2Assembly5308S.Returns(typeof(int));

          var shiftHourReportSh2PickAndPlace5307S = oDataBuilder.Function("ShiftHourReportSh2PickAndPlace5307sFunc");
          shiftHourReportSh2PickAndPlace5307S.Returns(typeof(int));

          var shiftReportDashTimers = oDataBuilder.Function("ShiftReportDashTimersFunc");
          shiftReportDashTimers.Parameter<int?>("MachineID");
          shiftReportDashTimers.Parameter<string>("BatchID");
          shiftReportDashTimers.Parameter<string>("Shift");
          shiftReportDashTimers.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.ShiftReportDashTimer>("ShiftReportDashTimers");

          var shiftReportDashTimersGroupeds = oDataBuilder.Function("ShiftReportDashTimersGroupedsFunc");
          shiftReportDashTimersGroupeds.Parameter<int?>("MachineID");
          shiftReportDashTimersGroupeds.Parameter<string>("BatchID");
          shiftReportDashTimersGroupeds.Parameter<string>("Shift");
          shiftReportDashTimersGroupeds.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.ShiftReportDashTimersGrouped>("ShiftReportDashTimersGroupeds");

          var shiftReportDashTotalGodBads = oDataBuilder.Function("ShiftReportDashTotalGodBadsFunc");
          shiftReportDashTotalGodBads.Parameter<int?>("MachineID");
          shiftReportDashTotalGodBads.Parameter<string>("BatchID");
          shiftReportDashTotalGodBads.Parameter<string>("Shift");
          shiftReportDashTotalGodBads.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.ShiftReportDashTotalGodBad>("ShiftReportDashTotalGodBads");

          var spBacthReportDashes = oDataBuilder.Function("SpBacthReportDashesFunc");
          spBacthReportDashes.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.SpBacthReportDash>("SpBacthReportDashes");

          var spBacthReportHeaders = oDataBuilder.Function("SpBacthReportHeadersFunc");
          spBacthReportHeaders.Parameter<int?>("MachineID");
          spBacthReportHeaders.Parameter<string>("BatchID");
          spBacthReportHeaders.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.SpBacthReportHeader>("SpBacthReportHeaders");

          var spBacthReportHeaderRows = oDataBuilder.Function("SpBacthReportHeaderRowsFunc");
          spBacthReportHeaderRows.Parameter<int?>("MachineID");
          spBacthReportHeaderRows.Parameter<string>("BatchID");
          spBacthReportHeaderRows.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.SpBacthReportHeaderRow>("SpBacthReportHeaderRows");

          var spBatchHourValuesGrids = oDataBuilder.Function("SpBatchHourValuesGridsFunc");
          spBatchHourValuesGrids.Parameter<int?>("MAchineID");
          spBatchHourValuesGrids.Parameter<string>("BatchID");
          spBatchHourValuesGrids.Parameter<string>("TagGroup");
          spBatchHourValuesGrids.Parameter<string>("TagType");
          spBatchHourValuesGrids.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.SpBatchHourValuesGrid>("SpBatchHourValuesGrids");

          var spBatchLists = oDataBuilder.Function("SpBatchListsFunc");
          spBatchLists.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.SpBatchList>("SpBatchLists");

          var spClearDataTables = oDataBuilder.Function("SpClearDataTablesFunc");
          spClearDataTables.Returns(typeof(int));

          var spHourValues = oDataBuilder.Function("SpHourValuesFunc");
          spHourValues.Parameter<int?>("MAchineID");
          spHourValues.Parameter<string>("BatchID");
          spHourValues.Parameter<string>("TagGroup");
          spHourValues.Parameter<string>("TagType");
          spHourValues.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.SpHourValue>("SpHourValues");

          var spHourValuesGrids = oDataBuilder.Function("SpHourValuesGridsFunc");
          spHourValuesGrids.Parameter<int?>("MAchineID");
          spHourValuesGrids.Parameter<string>("BatchID");
          spHourValuesGrids.Parameter<string>("TagGroup");
          spHourValuesGrids.Parameter<string>("TagType");
          spHourValuesGrids.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.SpHourValuesGrid>("SpHourValuesGrids");

          var spHourValuesShifts = oDataBuilder.Function("SpHourValuesShiftsFunc");
          spHourValuesShifts.Parameter<int?>("MAchineID");
          spHourValuesShifts.Parameter<string>("BatchID");
          spHourValuesShifts.Parameter<string>("Shift");
          spHourValuesShifts.Parameter<string>("TagGroup");
          spHourValuesShifts.Parameter<string>("TagType");
          spHourValuesShifts.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.SpHourValuesShift>("SpHourValuesShifts");

          var spPopulateHourValues = oDataBuilder.Function("SpPopulateHourValuesFunc");
          spPopulateHourValues.Returns(typeof(int));

          var spShiftHourValuesGrids = oDataBuilder.Function("SpShiftHourValuesGridsFunc");
          spShiftHourValuesGrids.Parameter<int?>("MAchineID");
          spShiftHourValuesGrids.Parameter<string>("BatchID");
          spShiftHourValuesGrids.Parameter<string>("Shift");
          spShiftHourValuesGrids.Parameter<string>("TagType");
          spShiftHourValuesGrids.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.SpShiftHourValuesGrid>("SpShiftHourValuesGrids");

          var spShiftReportDashes = oDataBuilder.Function("SpShiftReportDashesFunc");
          spShiftReportDashes.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.SpShiftReportDash>("SpShiftReportDashes");

          var spShiftReportHeaders = oDataBuilder.Function("SpShiftReportHeadersFunc");
          spShiftReportHeaders.Parameter<int?>("MachineID");
          spShiftReportHeaders.Parameter<string>("BatchID");
          spShiftReportHeaders.Parameter<string>("Shift");
          spShiftReportHeaders.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.SpShiftReportHeader>("SpShiftReportHeaders");

          var spStopTimeChartSources = oDataBuilder.Function("SpStopTimeChartSourcesFunc");
          spStopTimeChartSources.Parameter<int?>("MachineID");
          spStopTimeChartSources.Parameter<string>("BatchID");
          spStopTimeChartSources.ReturnsCollectionFromEntitySet<DataAnalysis.Models.Sortimat.SpStopTimeChartSource>("SpStopTimeChartSources");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.Tag>("Tags");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.TestSh1PickAndPlace5220ShiftPerHour>("TestSh1PickAndPlace5220ShiftPerHours");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.VBacthReportHeaderRow>("VBacthReportHeaderRows");
          oDataBuilder.EntitySet<DataAnalysis.Models.Sortimat.VChartDatum>("VChartData");

          this.OnConfigureOData(oDataBuilder);

          var model = oDataBuilder.GetEdmModel();

          builder.MapODataServiceRoute("odata/Sortimat", "odata/Sortimat", model);

      });

      if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("RADZEN")) && env.IsDevelopment())
      {
        app.UseSpa(spa =>
        {
          spa.Options.SourcePath = "../client";
          spa.UseAngularCliServer(npmScript: "start -- --port 8000 --open");
        });
      }

      OnConfigure(app);
      OnConfigure(app, env);
    }
  }
}
