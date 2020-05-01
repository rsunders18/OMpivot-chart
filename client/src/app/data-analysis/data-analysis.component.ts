import { Component, Injector, ViewChild } from '@angular/core';
import { DataAnalysisGenerated } from './data-analysis-generated.component';
import { WebDataRocksPivot } from '../webdatarocks/webdatarocks.angular4';

@Component({
  selector: 'page-data-analysis',
  templateUrl: './data-analysis.component.html'
})
export class DataAnalysisComponent extends DataAnalysisGenerated {
  @ViewChild("pivot1") child: WebDataRocksPivot;
  showA = false;
  pivotReport: any;

  constructor(injector: Injector) {
    super(injector);
  }
  load() {
    console.log("Getting chart data");
    let maxRows = 100;
    console.time("Got chart data in");
    this.sortimat.getVChartData(null, maxRows, null, null, null, null, null, "TagType, TagName, Value")
        .subscribe((result: any) => {
            console.log("Data:", result.value);
            console.timeEnd("Got chart data in");
            this.pivotReport = {
                dataSource: {
                    data: result.value
                }
            }
            this.startGoogle();
        }, (result: any) => {
            console.error("In file dynamic-pivot-table.component.ts -> load() -> getVChartData()");
        });

}

updateToolbar(toolbar) {
    console.log("Updating tool bar:", toolbar);

    //toolbar.Labels.connect = "abc"
    
    let tabs = toolbar.getTabs();
    toolbar.getTabs = function () {
        delete tabs[0] // Connect
        // delete tabs[1] // Open
        // delete tabs[2] // Save
        // delete tabs[3] // Export
        return tabs;
    }

}

startGoogle() {
    this.showA = true;
    // @ts-ignore
    google.charts.load("current", { packages: ["corechart"] });
    // @ts-ignore
    google.charts.setOnLoadCallback(() => this.onGoogleChartsLoaded());
}

onGoogleChartsLoaded() {
    console.log("Google charts loaded")
    this.googleChartsLoaded = true;
    if (this.pivotTableReportComplete) {
        this.createGoogleChart();
    }
}

onPivotReady(pivot: WebDataRocks.Pivot): void {
    console.log("Pivot table ready", this.child);
}

onCustomizeCell(
    cell: WebDataRocks.CellBuilder,
    data: WebDataRocks.CellData
): void {
    //console.log("[customizeCell] WebDataRocksPivot");
    if (data.isClassicTotalRow) cell.addClass("fm-total-classic-r");
    if (data.isGrandTotalRow) cell.addClass("fm-grand-total-r");
    if (data.isGrandTotalColumn) cell.addClass("fm-grand-total-c");
}

onCellClick(cell) {
    console.log("Clicked cell:", cell)
}

onCellDoubleClick(cell) {
    console.log("Double clicked cell:", cell)
}

pivotTableReportComplete: boolean = false;
googleChartsLoaded: boolean = false;

onReportComplete(): void {
    console.log("onReportComplete called");
    this.child.webDataRocks.off("reportcomplete");
    this.pivotTableReportComplete = true;
    this.createGoogleChart();
}

createGoogleChart() {
    console.log("Creating google chart")
    if (this.googleChartsLoaded) {
        this.child.webDataRocks.googlecharts.getData(
            { type: "line" },
            data => this.drawChart(data),
            data => this.drawChart(data)
        );
    }
}

drawChart(_data: any) {
    console.log("Drawing chart")
    // @ts-ignore
    var data = google.visualization.arrayToDataTable(_data.data);

    var options = {
        title: "Sortimat Data",
        titleTextStyle: {
            color: '333333',
            fontName: 'Arial',
            fontSize: 20
          },
        legend: { position: "top" },
        colors: ["#034694"],
        isStacked: false,
        hAxis: {
            slantedText: true
        },
    };

    // @ts-ignore
    var chart = new google.visualization.LineChart(
        document.getElementById("googlechart-container")
    );
    // @ts-ignore
    chart.draw(data, <google.visualization.LineChartOptions>options);
    console.log("Chart drawn:", chart)
}
}

