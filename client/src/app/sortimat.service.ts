import { Injectable } from '@angular/core';
import { Location } from '@angular/common';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable, BehaviorSubject, throwError } from 'rxjs';

import { ConfigService } from './config.service';
import { ODataClient } from './odata-client';
import * as models from './sortimat.model';

@Injectable()
export class SortimatService {
  odata: ODataClient;
  basePath: string;

  constructor(private http: HttpClient, private config: ConfigService) {
    this.basePath = config.get('sortimat');
    this.odata = new ODataClient(this.http, this.basePath, { legacy: false, withCredentials: true });
  }

  getAppDailyProductionShifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/AppDailyProductionShifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getBatchHourReports(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/BatchHourReports`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createBatchHourReport(expand: string | null, batchHourReport: models.BatchHourReport | null) : Observable<any> {
    return this.odata.post(`/BatchHourReports`, batchHourReport, { expand }, []);
  }

  deleteBatchHourReport(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/BatchHourReports(${rowId})`, item => !(item.RowID == rowId));
  }

  getBatchHourReportByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/BatchHourReports(${rowId})`, { expand });
  }

  updateBatchHourReport(expand: string | null, rowId: number | null, batchHourReport: models.BatchHourReport | null) : Observable<any> {
    return this.odata.patch(`/BatchHourReports(${rowId})`, batchHourReport, item => item.RowID == rowId, { expand }, []);
  }

  batchHourReportFm1Assembly5201S() : Observable<any> {
    return this.odata.get(`/BatchHourReportFm1Assembly5201sFunc()`, {  });
  }

  batchHourReportFm1PickAndPlace5219S() : Observable<any> {
    return this.odata.get(`/BatchHourReportFm1PickAndPlace5219sFunc()`, {  });
  }

  batchHourReportFm2Assembly5306S() : Observable<any> {
    return this.odata.get(`/BatchHourReportFm2Assembly5306sFunc()`, {  });
  }

  batchHourReportFm2PickAndPlace5305S() : Observable<any> {
    return this.odata.get(`/BatchHourReportFm2PickAndPlace5305sFunc()`, {  });
  }

  batchHourReportSh1Assembly5202S() : Observable<any> {
    return this.odata.get(`/BatchHourReportSh1Assembly5202sFunc()`, {  });
  }

  batchHourReportSh1PickAndPlace5220S() : Observable<any> {
    return this.odata.get(`/BatchHourReportSh1PickAndPlace5220sFunc()`, {  });
  }

  batchHourReportSh2Assembly5308S() : Observable<any> {
    return this.odata.get(`/BatchHourReportSh2Assembly5308sFunc()`, {  });
  }

  batchHourReportSh2PickAndPlace5307S() : Observable<any> {
    return this.odata.get(`/BatchHourReportSh2PickAndPlace5307sFunc()`, {  });
  }

  getBatchReportDashTimers(machineId: number | null, batchId: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/BatchReportDashTimersFunc(MachineID=${machineId},BatchID='${encodeURIComponent(batchId)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getBatchReportDashTimersGroupeds(machineId: number | null, batchId: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/BatchReportDashTimersGroupedsFunc(MachineID=${machineId},BatchID='${encodeURIComponent(batchId)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getChartData(machineId: number | null, tagGroup: string | null, tagType: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/ChartDataFunc(MachineID=${machineId},TagGroup='${encodeURIComponent(tagGroup)}',TagType='${encodeURIComponent(tagType)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getDailyProductionShifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/DailyProductionShifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getDashData(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/DashDataFunc()`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getDates(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Dates`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createDate(expand: string | null, date: models.Date | null) : Observable<any> {
    return this.odata.post(`/Dates`, date, { expand }, []);
  }

  deleteDate(date1: string | null) : Observable<any> {
    return this.odata.delete(`/Dates(${encodeURIComponent(date1)})`, item => !(item.Date1 == date1));
  }

  getDateByDate1(expand: string | null, date1: string | null) : Observable<any> {
    return this.odata.getById(`/Dates(${encodeURIComponent(date1)})`, { expand });
  }

  updateDate(expand: string | null, date1: string | null, date: models.Date | null) : Observable<any> {
    return this.odata.patch(`/Dates(${encodeURIComponent(date1)})`, date, item => item.Date1 == date1, { expand }, []);
  }

  getFm1Assembly5201Batches(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm1Assembly5201Batches`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm1Assembly5201Batch(expand: string | null, fm1Assembly5201Batch: models.Fm1Assembly5201Batch | null) : Observable<any> {
    return this.odata.post(`/Fm1Assembly5201Batches`, fm1Assembly5201Batch, { expand }, []);
  }

  deleteFm1Assembly5201Batch(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm1Assembly5201Batches(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm1Assembly5201BatchByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm1Assembly5201Batches(${rowId})`, { expand });
  }

  updateFm1Assembly5201Batch(expand: string | null, rowId: number | null, fm1Assembly5201Batch: models.Fm1Assembly5201Batch | null) : Observable<any> {
    return this.odata.patch(`/Fm1Assembly5201Batches(${rowId})`, fm1Assembly5201Batch, item => item.RowID == rowId, { expand }, []);
  }

  getFm1Assembly5201Data(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm1Assembly5201Data`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm1Assembly5201Datum(expand: string | null, fm1Assembly5201Datum: models.Fm1Assembly5201Datum | null) : Observable<any> {
    return this.odata.post(`/Fm1Assembly5201Data`, fm1Assembly5201Datum, { expand }, []);
  }

  deleteFm1Assembly5201Datum(id: number | null) : Observable<any> {
    return this.odata.delete(`/Fm1Assembly5201Data(${id})`, item => !(item.id == id));
  }

  getFm1Assembly5201DatumByid(expand: string | null, id: number | null) : Observable<any> {
    return this.odata.getById(`/Fm1Assembly5201Data(${id})`, { expand });
  }

  updateFm1Assembly5201Datum(expand: string | null, id: number | null, fm1Assembly5201Datum: models.Fm1Assembly5201Datum | null) : Observable<any> {
    return this.odata.patch(`/Fm1Assembly5201Data(${id})`, fm1Assembly5201Datum, item => item.id == id, { expand }, []);
  }

  getFm1Assembly5201PerBatchPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm1Assembly5201PerBatchPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm1Assembly5201PerBatchPerCycle(expand: string | null, fm1Assembly5201PerBatchPerCycle: models.Fm1Assembly5201PerBatchPerCycle | null) : Observable<any> {
    return this.odata.post(`/Fm1Assembly5201PerBatchPerCycles`, fm1Assembly5201PerBatchPerCycle, { expand }, []);
  }

  deleteFm1Assembly5201PerBatchPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm1Assembly5201PerBatchPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm1Assembly5201PerBatchPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm1Assembly5201PerBatchPerCycles(${rowId})`, { expand });
  }

  updateFm1Assembly5201PerBatchPerCycle(expand: string | null, rowId: number | null, fm1Assembly5201PerBatchPerCycle: models.Fm1Assembly5201PerBatchPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Fm1Assembly5201PerBatchPerCycles(${rowId})`, fm1Assembly5201PerBatchPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getFm1Assembly5201PerShiftPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm1Assembly5201PerShiftPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm1Assembly5201PerShiftPerCycle(expand: string | null, fm1Assembly5201PerShiftPerCycle: models.Fm1Assembly5201PerShiftPerCycle | null) : Observable<any> {
    return this.odata.post(`/Fm1Assembly5201PerShiftPerCycles`, fm1Assembly5201PerShiftPerCycle, { expand }, []);
  }

  deleteFm1Assembly5201PerShiftPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm1Assembly5201PerShiftPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm1Assembly5201PerShiftPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm1Assembly5201PerShiftPerCycles(${rowId})`, { expand });
  }

  updateFm1Assembly5201PerShiftPerCycle(expand: string | null, rowId: number | null, fm1Assembly5201PerShiftPerCycle: models.Fm1Assembly5201PerShiftPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Fm1Assembly5201PerShiftPerCycles(${rowId})`, fm1Assembly5201PerShiftPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getFm1Assembly5201Shifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm1Assembly5201Shifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm1Assembly5201Shift(expand: string | null, fm1Assembly5201Shift: models.Fm1Assembly5201Shift | null) : Observable<any> {
    return this.odata.post(`/Fm1Assembly5201Shifts`, fm1Assembly5201Shift, { expand }, []);
  }

  deleteFm1Assembly5201Shift(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm1Assembly5201Shifts(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm1Assembly5201ShiftByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm1Assembly5201Shifts(${rowId})`, { expand });
  }

  updateFm1Assembly5201Shift(expand: string | null, rowId: number | null, fm1Assembly5201Shift: models.Fm1Assembly5201Shift | null) : Observable<any> {
    return this.odata.patch(`/Fm1Assembly5201Shifts(${rowId})`, fm1Assembly5201Shift, item => item.RowID == rowId, { expand }, []);
  }

  getFm1AssemblyReportHourShifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm1AssemblyReportHourShifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm1AssemblyReportHourShift(expand: string | null, fm1AssemblyReportHourShift: models.Fm1AssemblyReportHourShift | null) : Observable<any> {
    return this.odata.post(`/Fm1AssemblyReportHourShifts`, fm1AssemblyReportHourShift, { expand }, []);
  }

  deleteFm1AssemblyReportHourShift(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm1AssemblyReportHourShifts(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm1AssemblyReportHourShiftByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm1AssemblyReportHourShifts(${rowId})`, { expand });
  }

  updateFm1AssemblyReportHourShift(expand: string | null, rowId: number | null, fm1AssemblyReportHourShift: models.Fm1AssemblyReportHourShift | null) : Observable<any> {
    return this.odata.patch(`/Fm1AssemblyReportHourShifts(${rowId})`, fm1AssemblyReportHourShift, item => item.RowID == rowId, { expand }, []);
  }

  getFm1PickAndPlace5219Batches(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm1PickAndPlace5219Batches`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm1PickAndPlace5219Batch(expand: string | null, fm1PickAndPlace5219Batch: models.Fm1PickAndPlace5219Batch | null) : Observable<any> {
    return this.odata.post(`/Fm1PickAndPlace5219Batches`, fm1PickAndPlace5219Batch, { expand }, []);
  }

  deleteFm1PickAndPlace5219Batch(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm1PickAndPlace5219Batches(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm1PickAndPlace5219BatchByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm1PickAndPlace5219Batches(${rowId})`, { expand });
  }

  updateFm1PickAndPlace5219Batch(expand: string | null, rowId: number | null, fm1PickAndPlace5219Batch: models.Fm1PickAndPlace5219Batch | null) : Observable<any> {
    return this.odata.patch(`/Fm1PickAndPlace5219Batches(${rowId})`, fm1PickAndPlace5219Batch, item => item.RowID == rowId, { expand }, []);
  }

  getFm1PickAndPlace5219Data(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm1PickAndPlace5219Data`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm1PickAndPlace5219Datum(expand: string | null, fm1PickAndPlace5219Datum: models.Fm1PickAndPlace5219Datum | null) : Observable<any> {
    return this.odata.post(`/Fm1PickAndPlace5219Data`, fm1PickAndPlace5219Datum, { expand }, []);
  }

  deleteFm1PickAndPlace5219Datum(id: number | null) : Observable<any> {
    return this.odata.delete(`/Fm1PickAndPlace5219Data(${id})`, item => !(item.id == id));
  }

  getFm1PickAndPlace5219DatumByid(expand: string | null, id: number | null) : Observable<any> {
    return this.odata.getById(`/Fm1PickAndPlace5219Data(${id})`, { expand });
  }

  updateFm1PickAndPlace5219Datum(expand: string | null, id: number | null, fm1PickAndPlace5219Datum: models.Fm1PickAndPlace5219Datum | null) : Observable<any> {
    return this.odata.patch(`/Fm1PickAndPlace5219Data(${id})`, fm1PickAndPlace5219Datum, item => item.id == id, { expand }, []);
  }

  getFm1PickAndPlace5219PerBatchPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm1PickAndPlace5219PerBatchPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm1PickAndPlace5219PerBatchPerCycle(expand: string | null, fm1PickAndPlace5219PerBatchPerCycle: models.Fm1PickAndPlace5219PerBatchPerCycle | null) : Observable<any> {
    return this.odata.post(`/Fm1PickAndPlace5219PerBatchPerCycles`, fm1PickAndPlace5219PerBatchPerCycle, { expand }, []);
  }

  deleteFm1PickAndPlace5219PerBatchPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm1PickAndPlace5219PerBatchPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm1PickAndPlace5219PerBatchPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm1PickAndPlace5219PerBatchPerCycles(${rowId})`, { expand });
  }

  updateFm1PickAndPlace5219PerBatchPerCycle(expand: string | null, rowId: number | null, fm1PickAndPlace5219PerBatchPerCycle: models.Fm1PickAndPlace5219PerBatchPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Fm1PickAndPlace5219PerBatchPerCycles(${rowId})`, fm1PickAndPlace5219PerBatchPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getFm1PickAndPlace5219PerShiftPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm1PickAndPlace5219PerShiftPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm1PickAndPlace5219PerShiftPerCycle(expand: string | null, fm1PickAndPlace5219PerShiftPerCycle: models.Fm1PickAndPlace5219PerShiftPerCycle | null) : Observable<any> {
    return this.odata.post(`/Fm1PickAndPlace5219PerShiftPerCycles`, fm1PickAndPlace5219PerShiftPerCycle, { expand }, []);
  }

  deleteFm1PickAndPlace5219PerShiftPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm1PickAndPlace5219PerShiftPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm1PickAndPlace5219PerShiftPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm1PickAndPlace5219PerShiftPerCycles(${rowId})`, { expand });
  }

  updateFm1PickAndPlace5219PerShiftPerCycle(expand: string | null, rowId: number | null, fm1PickAndPlace5219PerShiftPerCycle: models.Fm1PickAndPlace5219PerShiftPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Fm1PickAndPlace5219PerShiftPerCycles(${rowId})`, fm1PickAndPlace5219PerShiftPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getFm1PickAndPlace5219ReportHourShifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm1PickAndPlace5219ReportHourShifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm1PickAndPlace5219ReportHourShift(expand: string | null, fm1PickAndPlace5219ReportHourShift: models.Fm1PickAndPlace5219ReportHourShift | null) : Observable<any> {
    return this.odata.post(`/Fm1PickAndPlace5219ReportHourShifts`, fm1PickAndPlace5219ReportHourShift, { expand }, []);
  }

  deleteFm1PickAndPlace5219ReportHourShift(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm1PickAndPlace5219ReportHourShifts(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm1PickAndPlace5219ReportHourShiftByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm1PickAndPlace5219ReportHourShifts(${rowId})`, { expand });
  }

  updateFm1PickAndPlace5219ReportHourShift(expand: string | null, rowId: number | null, fm1PickAndPlace5219ReportHourShift: models.Fm1PickAndPlace5219ReportHourShift | null) : Observable<any> {
    return this.odata.patch(`/Fm1PickAndPlace5219ReportHourShifts(${rowId})`, fm1PickAndPlace5219ReportHourShift, item => item.RowID == rowId, { expand }, []);
  }

  getFm1PickAndPlace5219Shifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm1PickAndPlace5219Shifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm1PickAndPlace5219Shift(expand: string | null, fm1PickAndPlace5219Shift: models.Fm1PickAndPlace5219Shift | null) : Observable<any> {
    return this.odata.post(`/Fm1PickAndPlace5219Shifts`, fm1PickAndPlace5219Shift, { expand }, []);
  }

  deleteFm1PickAndPlace5219Shift(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm1PickAndPlace5219Shifts(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm1PickAndPlace5219ShiftByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm1PickAndPlace5219Shifts(${rowId})`, { expand });
  }

  updateFm1PickAndPlace5219Shift(expand: string | null, rowId: number | null, fm1PickAndPlace5219Shift: models.Fm1PickAndPlace5219Shift | null) : Observable<any> {
    return this.odata.patch(`/Fm1PickAndPlace5219Shifts(${rowId})`, fm1PickAndPlace5219Shift, item => item.RowID == rowId, { expand }, []);
  }

  getFm2Assembly5306Batches(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm2Assembly5306Batches`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm2Assembly5306Batch(expand: string | null, fm2Assembly5306Batch: models.Fm2Assembly5306Batch | null) : Observable<any> {
    return this.odata.post(`/Fm2Assembly5306Batches`, fm2Assembly5306Batch, { expand }, []);
  }

  deleteFm2Assembly5306Batch(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm2Assembly5306Batches(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm2Assembly5306BatchByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm2Assembly5306Batches(${rowId})`, { expand });
  }

  updateFm2Assembly5306Batch(expand: string | null, rowId: number | null, fm2Assembly5306Batch: models.Fm2Assembly5306Batch | null) : Observable<any> {
    return this.odata.patch(`/Fm2Assembly5306Batches(${rowId})`, fm2Assembly5306Batch, item => item.RowID == rowId, { expand }, []);
  }

  getFm2Assembly5306Data(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm2Assembly5306Data`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm2Assembly5306Datum(expand: string | null, fm2Assembly5306Datum: models.Fm2Assembly5306Datum | null) : Observable<any> {
    return this.odata.post(`/Fm2Assembly5306Data`, fm2Assembly5306Datum, { expand }, []);
  }

  deleteFm2Assembly5306Datum(id: number | null) : Observable<any> {
    return this.odata.delete(`/Fm2Assembly5306Data(${id})`, item => !(item.id == id));
  }

  getFm2Assembly5306DatumByid(expand: string | null, id: number | null) : Observable<any> {
    return this.odata.getById(`/Fm2Assembly5306Data(${id})`, { expand });
  }

  updateFm2Assembly5306Datum(expand: string | null, id: number | null, fm2Assembly5306Datum: models.Fm2Assembly5306Datum | null) : Observable<any> {
    return this.odata.patch(`/Fm2Assembly5306Data(${id})`, fm2Assembly5306Datum, item => item.id == id, { expand }, []);
  }

  getFm2Assembly5306PerBatchPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm2Assembly5306PerBatchPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm2Assembly5306PerBatchPerCycle(expand: string | null, fm2Assembly5306PerBatchPerCycle: models.Fm2Assembly5306PerBatchPerCycle | null) : Observable<any> {
    return this.odata.post(`/Fm2Assembly5306PerBatchPerCycles`, fm2Assembly5306PerBatchPerCycle, { expand }, []);
  }

  deleteFm2Assembly5306PerBatchPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm2Assembly5306PerBatchPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm2Assembly5306PerBatchPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm2Assembly5306PerBatchPerCycles(${rowId})`, { expand });
  }

  updateFm2Assembly5306PerBatchPerCycle(expand: string | null, rowId: number | null, fm2Assembly5306PerBatchPerCycle: models.Fm2Assembly5306PerBatchPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Fm2Assembly5306PerBatchPerCycles(${rowId})`, fm2Assembly5306PerBatchPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getFm2Assembly5306PerShiftPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm2Assembly5306PerShiftPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm2Assembly5306PerShiftPerCycle(expand: string | null, fm2Assembly5306PerShiftPerCycle: models.Fm2Assembly5306PerShiftPerCycle | null) : Observable<any> {
    return this.odata.post(`/Fm2Assembly5306PerShiftPerCycles`, fm2Assembly5306PerShiftPerCycle, { expand }, []);
  }

  deleteFm2Assembly5306PerShiftPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm2Assembly5306PerShiftPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm2Assembly5306PerShiftPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm2Assembly5306PerShiftPerCycles(${rowId})`, { expand });
  }

  updateFm2Assembly5306PerShiftPerCycle(expand: string | null, rowId: number | null, fm2Assembly5306PerShiftPerCycle: models.Fm2Assembly5306PerShiftPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Fm2Assembly5306PerShiftPerCycles(${rowId})`, fm2Assembly5306PerShiftPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getFm2Assembly5306Shifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm2Assembly5306Shifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm2Assembly5306Shift(expand: string | null, fm2Assembly5306Shift: models.Fm2Assembly5306Shift | null) : Observable<any> {
    return this.odata.post(`/Fm2Assembly5306Shifts`, fm2Assembly5306Shift, { expand }, []);
  }

  deleteFm2Assembly5306Shift(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm2Assembly5306Shifts(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm2Assembly5306ShiftByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm2Assembly5306Shifts(${rowId})`, { expand });
  }

  updateFm2Assembly5306Shift(expand: string | null, rowId: number | null, fm2Assembly5306Shift: models.Fm2Assembly5306Shift | null) : Observable<any> {
    return this.odata.patch(`/Fm2Assembly5306Shifts(${rowId})`, fm2Assembly5306Shift, item => item.RowID == rowId, { expand }, []);
  }

  getFm2PickAndPlace5305Batches(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm2PickAndPlace5305Batches`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm2PickAndPlace5305Batch(expand: string | null, fm2PickAndPlace5305Batch: models.Fm2PickAndPlace5305Batch | null) : Observable<any> {
    return this.odata.post(`/Fm2PickAndPlace5305Batches`, fm2PickAndPlace5305Batch, { expand }, []);
  }

  deleteFm2PickAndPlace5305Batch(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm2PickAndPlace5305Batches(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm2PickAndPlace5305BatchByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm2PickAndPlace5305Batches(${rowId})`, { expand });
  }

  updateFm2PickAndPlace5305Batch(expand: string | null, rowId: number | null, fm2PickAndPlace5305Batch: models.Fm2PickAndPlace5305Batch | null) : Observable<any> {
    return this.odata.patch(`/Fm2PickAndPlace5305Batches(${rowId})`, fm2PickAndPlace5305Batch, item => item.RowID == rowId, { expand }, []);
  }

  getFm2PickAndPlace5305Data(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm2PickAndPlace5305Data`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm2PickAndPlace5305Datum(expand: string | null, fm2PickAndPlace5305Datum: models.Fm2PickAndPlace5305Datum | null) : Observable<any> {
    return this.odata.post(`/Fm2PickAndPlace5305Data`, fm2PickAndPlace5305Datum, { expand }, []);
  }

  deleteFm2PickAndPlace5305Datum(id: number | null) : Observable<any> {
    return this.odata.delete(`/Fm2PickAndPlace5305Data(${id})`, item => !(item.id == id));
  }

  getFm2PickAndPlace5305DatumByid(expand: string | null, id: number | null) : Observable<any> {
    return this.odata.getById(`/Fm2PickAndPlace5305Data(${id})`, { expand });
  }

  updateFm2PickAndPlace5305Datum(expand: string | null, id: number | null, fm2PickAndPlace5305Datum: models.Fm2PickAndPlace5305Datum | null) : Observable<any> {
    return this.odata.patch(`/Fm2PickAndPlace5305Data(${id})`, fm2PickAndPlace5305Datum, item => item.id == id, { expand }, []);
  }

  getFm2PickAndPlace5305PerBatchPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm2PickAndPlace5305PerBatchPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm2PickAndPlace5305PerBatchPerCycle(expand: string | null, fm2PickAndPlace5305PerBatchPerCycle: models.Fm2PickAndPlace5305PerBatchPerCycle | null) : Observable<any> {
    return this.odata.post(`/Fm2PickAndPlace5305PerBatchPerCycles`, fm2PickAndPlace5305PerBatchPerCycle, { expand }, []);
  }

  deleteFm2PickAndPlace5305PerBatchPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm2PickAndPlace5305PerBatchPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm2PickAndPlace5305PerBatchPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm2PickAndPlace5305PerBatchPerCycles(${rowId})`, { expand });
  }

  updateFm2PickAndPlace5305PerBatchPerCycle(expand: string | null, rowId: number | null, fm2PickAndPlace5305PerBatchPerCycle: models.Fm2PickAndPlace5305PerBatchPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Fm2PickAndPlace5305PerBatchPerCycles(${rowId})`, fm2PickAndPlace5305PerBatchPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getFm2PickAndPlace5305PerShiftPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm2PickAndPlace5305PerShiftPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm2PickAndPlace5305PerShiftPerCycle(expand: string | null, fm2PickAndPlace5305PerShiftPerCycle: models.Fm2PickAndPlace5305PerShiftPerCycle | null) : Observable<any> {
    return this.odata.post(`/Fm2PickAndPlace5305PerShiftPerCycles`, fm2PickAndPlace5305PerShiftPerCycle, { expand }, []);
  }

  deleteFm2PickAndPlace5305PerShiftPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm2PickAndPlace5305PerShiftPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm2PickAndPlace5305PerShiftPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm2PickAndPlace5305PerShiftPerCycles(${rowId})`, { expand });
  }

  updateFm2PickAndPlace5305PerShiftPerCycle(expand: string | null, rowId: number | null, fm2PickAndPlace5305PerShiftPerCycle: models.Fm2PickAndPlace5305PerShiftPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Fm2PickAndPlace5305PerShiftPerCycles(${rowId})`, fm2PickAndPlace5305PerShiftPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getFm2PickAndPlace5305Shifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Fm2PickAndPlace5305Shifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createFm2PickAndPlace5305Shift(expand: string | null, fm2PickAndPlace5305Shift: models.Fm2PickAndPlace5305Shift | null) : Observable<any> {
    return this.odata.post(`/Fm2PickAndPlace5305Shifts`, fm2PickAndPlace5305Shift, { expand }, []);
  }

  deleteFm2PickAndPlace5305Shift(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Fm2PickAndPlace5305Shifts(${rowId})`, item => !(item.RowID == rowId));
  }

  getFm2PickAndPlace5305ShiftByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Fm2PickAndPlace5305Shifts(${rowId})`, { expand });
  }

  updateFm2PickAndPlace5305Shift(expand: string | null, rowId: number | null, fm2PickAndPlace5305Shift: models.Fm2PickAndPlace5305Shift | null) : Observable<any> {
    return this.odata.patch(`/Fm2PickAndPlace5305Shifts(${rowId})`, fm2PickAndPlace5305Shift, item => item.RowID == rowId, { expand }, []);
  }

  getHourValues(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/HourValues`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createHourValue(expand: string | null, hourValue: models.HourValue | null) : Observable<any> {
    return this.odata.post(`/HourValues`, hourValue, { expand }, []);
  }

  deleteHourValue(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/HourValues(${rowId})`, item => !(item.RowID == rowId));
  }

  getHourValueByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/HourValues(${rowId})`, { expand });
  }

  updateHourValue(expand: string | null, rowId: number | null, hourValue: models.HourValue | null) : Observable<any> {
    return this.odata.patch(`/HourValues(${rowId})`, hourValue, item => item.RowID == rowId, { expand }, []);
  }

  getMachines(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Machines`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createMachine(expand: string | null, machine: models.Machine | null) : Observable<any> {
    return this.odata.post(`/Machines`, machine, { expand }, []);
  }

  deleteMachine(machineId: number | null) : Observable<any> {
    return this.odata.delete(`/Machines(${machineId})`, item => !(item.MachineID == machineId));
  }

  getMachineByMachineId(expand: string | null, machineId: number | null) : Observable<any> {
    return this.odata.getById(`/Machines(${machineId})`, { expand });
  }

  updateMachine(expand: string | null, machineId: number | null, machine: models.Machine | null) : Observable<any> {
    return this.odata.patch(`/Machines(${machineId})`, machine, item => item.MachineID == machineId, { expand }, []);
  }

  getOmPadBrPerShiftPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/OmPadBrPerShiftPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getOmPadLpcPerShiftPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/OmPadLpcPerShiftPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getOmPadShPerShiftPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/OmPadShPerShiftPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  populateAbbvieFm1Assembly5201Batches() : Observable<any> {
    return this.odata.get(`/PopulateAbbvieFm1Assembly5201BatchesFunc()`, {  });
  }

  populateAbbvieFm1Assembly5201Shifts() : Observable<any> {
    return this.odata.get(`/PopulateAbbvieFm1Assembly5201ShiftsFunc()`, {  });
  }

  populateAbbvieFm1PickAndPlace5219Batches() : Observable<any> {
    return this.odata.get(`/PopulateAbbvieFm1PickAndPlace5219BatchesFunc()`, {  });
  }

  populateAbbvieFm1PickAndPlace5219Shifts() : Observable<any> {
    return this.odata.get(`/PopulateAbbvieFm1PickAndPlace5219ShiftsFunc()`, {  });
  }

  populateAbbvieFm2Assembly5306Shifts() : Observable<any> {
    return this.odata.get(`/PopulateAbbvieFm2Assembly5306ShiftsFunc()`, {  });
  }

  populateAbbvieFm2PickAndPlace5305Shifts() : Observable<any> {
    return this.odata.get(`/PopulateAbbvieFm2PickAndPlace5305ShiftsFunc()`, {  });
  }

  populateAbbvieSh1Assembly5202Shifts() : Observable<any> {
    return this.odata.get(`/PopulateAbbvieSh1Assembly5202ShiftsFunc()`, {  });
  }

  populateAbbvieSh1PickAndPlace5220Shifts() : Observable<any> {
    return this.odata.get(`/PopulateAbbvieSh1PickAndPlace5220ShiftsFunc()`, {  });
  }

  populateAbbvieSh2Assembly5308Shifts() : Observable<any> {
    return this.odata.get(`/PopulateAbbvieSh2Assembly5308ShiftsFunc()`, {  });
  }

  populateAbbvieSh2PickAndPlace5307Shifts() : Observable<any> {
    return this.odata.get(`/PopulateAbbvieSh2PickAndPlace5307ShiftsFunc()`, {  });
  }

  populateFm1AssemblyReportHourShifts() : Observable<any> {
    return this.odata.get(`/PopulateFm1AssemblyReportHourShiftsFunc()`, {  });
  }

  populateFm1PickAndPlace5219ReportHourShifts() : Observable<any> {
    return this.odata.get(`/PopulateFm1PickAndPlace5219ReportHourShiftsFunc()`, {  });
  }

  populateFm2Assembly5306Batches() : Observable<any> {
    return this.odata.get(`/PopulateFm2Assembly5306BatchesFunc()`, {  });
  }

  populateFm2PickAndPlace5305Batches() : Observable<any> {
    return this.odata.get(`/PopulateFm2PickAndPlace5305BatchesFunc()`, {  });
  }

  populateSh1Assembly5202Batches() : Observable<any> {
    return this.odata.get(`/PopulateSh1Assembly5202BatchesFunc()`, {  });
  }

  populateSh1Assembly5202Shifts() : Observable<any> {
    return this.odata.get(`/PopulateSh1Assembly5202ShiftsFunc()`, {  });
  }

  populateSh1PickAndPlace5220Batches() : Observable<any> {
    return this.odata.get(`/PopulateSh1PickAndPlace5220BatchesFunc()`, {  });
  }

  populateSh2Assembly5308Batches() : Observable<any> {
    return this.odata.get(`/PopulateSh2Assembly5308BatchesFunc()`, {  });
  }

  populateSh2PickAndPlace5307Batches() : Observable<any> {
    return this.odata.get(`/PopulateSh2PickAndPlace5307BatchesFunc()`, {  });
  }

  getSh1Assembly5202Batches(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh1Assembly5202Batches`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh1Assembly5202Batch(expand: string | null, sh1Assembly5202Batch: models.Sh1Assembly5202Batch | null) : Observable<any> {
    return this.odata.post(`/Sh1Assembly5202Batches`, sh1Assembly5202Batch, { expand }, []);
  }

  deleteSh1Assembly5202Batch(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh1Assembly5202Batches(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh1Assembly5202BatchByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh1Assembly5202Batches(${rowId})`, { expand });
  }

  updateSh1Assembly5202Batch(expand: string | null, rowId: number | null, sh1Assembly5202Batch: models.Sh1Assembly5202Batch | null) : Observable<any> {
    return this.odata.patch(`/Sh1Assembly5202Batches(${rowId})`, sh1Assembly5202Batch, item => item.RowID == rowId, { expand }, []);
  }

  getSh1Assembly5202Data(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh1Assembly5202Data`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh1Assembly5202Datum(expand: string | null, sh1Assembly5202Datum: models.Sh1Assembly5202Datum | null) : Observable<any> {
    return this.odata.post(`/Sh1Assembly5202Data`, sh1Assembly5202Datum, { expand }, []);
  }

  deleteSh1Assembly5202Datum(id: number | null) : Observable<any> {
    return this.odata.delete(`/Sh1Assembly5202Data(${id})`, item => !(item.id == id));
  }

  getSh1Assembly5202DatumByid(expand: string | null, id: number | null) : Observable<any> {
    return this.odata.getById(`/Sh1Assembly5202Data(${id})`, { expand });
  }

  updateSh1Assembly5202Datum(expand: string | null, id: number | null, sh1Assembly5202Datum: models.Sh1Assembly5202Datum | null) : Observable<any> {
    return this.odata.patch(`/Sh1Assembly5202Data(${id})`, sh1Assembly5202Datum, item => item.id == id, { expand }, []);
  }

  getSh1Assembly5202PerBatchPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh1Assembly5202PerBatchPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh1Assembly5202PerBatchPerCycle(expand: string | null, sh1Assembly5202PerBatchPerCycle: models.Sh1Assembly5202PerBatchPerCycle | null) : Observable<any> {
    return this.odata.post(`/Sh1Assembly5202PerBatchPerCycles`, sh1Assembly5202PerBatchPerCycle, { expand }, []);
  }

  deleteSh1Assembly5202PerBatchPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh1Assembly5202PerBatchPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh1Assembly5202PerBatchPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh1Assembly5202PerBatchPerCycles(${rowId})`, { expand });
  }

  updateSh1Assembly5202PerBatchPerCycle(expand: string | null, rowId: number | null, sh1Assembly5202PerBatchPerCycle: models.Sh1Assembly5202PerBatchPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Sh1Assembly5202PerBatchPerCycles(${rowId})`, sh1Assembly5202PerBatchPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getSh1Assembly5202PerShiftPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh1Assembly5202PerShiftPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh1Assembly5202PerShiftPerCycle(expand: string | null, sh1Assembly5202PerShiftPerCycle: models.Sh1Assembly5202PerShiftPerCycle | null) : Observable<any> {
    return this.odata.post(`/Sh1Assembly5202PerShiftPerCycles`, sh1Assembly5202PerShiftPerCycle, { expand }, []);
  }

  deleteSh1Assembly5202PerShiftPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh1Assembly5202PerShiftPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh1Assembly5202PerShiftPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh1Assembly5202PerShiftPerCycles(${rowId})`, { expand });
  }

  updateSh1Assembly5202PerShiftPerCycle(expand: string | null, rowId: number | null, sh1Assembly5202PerShiftPerCycle: models.Sh1Assembly5202PerShiftPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Sh1Assembly5202PerShiftPerCycles(${rowId})`, sh1Assembly5202PerShiftPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getSh1Assembly5202Shifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh1Assembly5202Shifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh1Assembly5202Shift(expand: string | null, sh1Assembly5202Shift: models.Sh1Assembly5202Shift | null) : Observable<any> {
    return this.odata.post(`/Sh1Assembly5202Shifts`, sh1Assembly5202Shift, { expand }, []);
  }

  deleteSh1Assembly5202Shift(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh1Assembly5202Shifts(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh1Assembly5202ShiftByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh1Assembly5202Shifts(${rowId})`, { expand });
  }

  updateSh1Assembly5202Shift(expand: string | null, rowId: number | null, sh1Assembly5202Shift: models.Sh1Assembly5202Shift | null) : Observable<any> {
    return this.odata.patch(`/Sh1Assembly5202Shifts(${rowId})`, sh1Assembly5202Shift, item => item.RowID == rowId, { expand }, []);
  }

  getSh1PickAndPlace5220Batches(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh1PickAndPlace5220Batches`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh1PickAndPlace5220Batch(expand: string | null, sh1PickAndPlace5220Batch: models.Sh1PickAndPlace5220Batch | null) : Observable<any> {
    return this.odata.post(`/Sh1PickAndPlace5220Batches`, sh1PickAndPlace5220Batch, { expand }, []);
  }

  deleteSh1PickAndPlace5220Batch(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh1PickAndPlace5220Batches(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh1PickAndPlace5220BatchByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh1PickAndPlace5220Batches(${rowId})`, { expand });
  }

  updateSh1PickAndPlace5220Batch(expand: string | null, rowId: number | null, sh1PickAndPlace5220Batch: models.Sh1PickAndPlace5220Batch | null) : Observable<any> {
    return this.odata.patch(`/Sh1PickAndPlace5220Batches(${rowId})`, sh1PickAndPlace5220Batch, item => item.RowID == rowId, { expand }, []);
  }

  getSh1PickAndPlace5220Data(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh1PickAndPlace5220Data`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh1PickAndPlace5220Datum(expand: string | null, sh1PickAndPlace5220Datum: models.Sh1PickAndPlace5220Datum | null) : Observable<any> {
    return this.odata.post(`/Sh1PickAndPlace5220Data`, sh1PickAndPlace5220Datum, { expand }, []);
  }

  deleteSh1PickAndPlace5220Datum(id: number | null) : Observable<any> {
    return this.odata.delete(`/Sh1PickAndPlace5220Data(${id})`, item => !(item.id == id));
  }

  getSh1PickAndPlace5220DatumByid(expand: string | null, id: number | null) : Observable<any> {
    return this.odata.getById(`/Sh1PickAndPlace5220Data(${id})`, { expand });
  }

  updateSh1PickAndPlace5220Datum(expand: string | null, id: number | null, sh1PickAndPlace5220Datum: models.Sh1PickAndPlace5220Datum | null) : Observable<any> {
    return this.odata.patch(`/Sh1PickAndPlace5220Data(${id})`, sh1PickAndPlace5220Datum, item => item.id == id, { expand }, []);
  }

  getSh1PickAndPlace5220PerBatchPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh1PickAndPlace5220PerBatchPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh1PickAndPlace5220PerBatchPerCycle(expand: string | null, sh1PickAndPlace5220PerBatchPerCycle: models.Sh1PickAndPlace5220PerBatchPerCycle | null) : Observable<any> {
    return this.odata.post(`/Sh1PickAndPlace5220PerBatchPerCycles`, sh1PickAndPlace5220PerBatchPerCycle, { expand }, []);
  }

  deleteSh1PickAndPlace5220PerBatchPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh1PickAndPlace5220PerBatchPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh1PickAndPlace5220PerBatchPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh1PickAndPlace5220PerBatchPerCycles(${rowId})`, { expand });
  }

  updateSh1PickAndPlace5220PerBatchPerCycle(expand: string | null, rowId: number | null, sh1PickAndPlace5220PerBatchPerCycle: models.Sh1PickAndPlace5220PerBatchPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Sh1PickAndPlace5220PerBatchPerCycles(${rowId})`, sh1PickAndPlace5220PerBatchPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getSh1PickAndPlace5220PerShiftPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh1PickAndPlace5220PerShiftPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh1PickAndPlace5220PerShiftPerCycle(expand: string | null, sh1PickAndPlace5220PerShiftPerCycle: models.Sh1PickAndPlace5220PerShiftPerCycle | null) : Observable<any> {
    return this.odata.post(`/Sh1PickAndPlace5220PerShiftPerCycles`, sh1PickAndPlace5220PerShiftPerCycle, { expand }, []);
  }

  deleteSh1PickAndPlace5220PerShiftPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh1PickAndPlace5220PerShiftPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh1PickAndPlace5220PerShiftPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh1PickAndPlace5220PerShiftPerCycles(${rowId})`, { expand });
  }

  updateSh1PickAndPlace5220PerShiftPerCycle(expand: string | null, rowId: number | null, sh1PickAndPlace5220PerShiftPerCycle: models.Sh1PickAndPlace5220PerShiftPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Sh1PickAndPlace5220PerShiftPerCycles(${rowId})`, sh1PickAndPlace5220PerShiftPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getSh1PickAndPlace5220Shifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh1PickAndPlace5220Shifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh1PickAndPlace5220Shift(expand: string | null, sh1PickAndPlace5220Shift: models.Sh1PickAndPlace5220Shift | null) : Observable<any> {
    return this.odata.post(`/Sh1PickAndPlace5220Shifts`, sh1PickAndPlace5220Shift, { expand }, []);
  }

  deleteSh1PickAndPlace5220Shift(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh1PickAndPlace5220Shifts(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh1PickAndPlace5220ShiftByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh1PickAndPlace5220Shifts(${rowId})`, { expand });
  }

  updateSh1PickAndPlace5220Shift(expand: string | null, rowId: number | null, sh1PickAndPlace5220Shift: models.Sh1PickAndPlace5220Shift | null) : Observable<any> {
    return this.odata.patch(`/Sh1PickAndPlace5220Shifts(${rowId})`, sh1PickAndPlace5220Shift, item => item.RowID == rowId, { expand }, []);
  }

  getSh2Assembly5308Batches(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh2Assembly5308Batches`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh2Assembly5308Batch(expand: string | null, sh2Assembly5308Batch: models.Sh2Assembly5308Batch | null) : Observable<any> {
    return this.odata.post(`/Sh2Assembly5308Batches`, sh2Assembly5308Batch, { expand }, []);
  }

  deleteSh2Assembly5308Batch(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh2Assembly5308Batches(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh2Assembly5308BatchByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh2Assembly5308Batches(${rowId})`, { expand });
  }

  updateSh2Assembly5308Batch(expand: string | null, rowId: number | null, sh2Assembly5308Batch: models.Sh2Assembly5308Batch | null) : Observable<any> {
    return this.odata.patch(`/Sh2Assembly5308Batches(${rowId})`, sh2Assembly5308Batch, item => item.RowID == rowId, { expand }, []);
  }

  getSh2Assembly5308Data(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh2Assembly5308Data`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh2Assembly5308Datum(expand: string | null, sh2Assembly5308Datum: models.Sh2Assembly5308Datum | null) : Observable<any> {
    return this.odata.post(`/Sh2Assembly5308Data`, sh2Assembly5308Datum, { expand }, []);
  }

  deleteSh2Assembly5308Datum(id: number | null) : Observable<any> {
    return this.odata.delete(`/Sh2Assembly5308Data(${id})`, item => !(item.id == id));
  }

  getSh2Assembly5308DatumByid(expand: string | null, id: number | null) : Observable<any> {
    return this.odata.getById(`/Sh2Assembly5308Data(${id})`, { expand });
  }

  updateSh2Assembly5308Datum(expand: string | null, id: number | null, sh2Assembly5308Datum: models.Sh2Assembly5308Datum | null) : Observable<any> {
    return this.odata.patch(`/Sh2Assembly5308Data(${id})`, sh2Assembly5308Datum, item => item.id == id, { expand }, []);
  }

  getSh2Assembly5308PerBatchPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh2Assembly5308PerBatchPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh2Assembly5308PerBatchPerCycle(expand: string | null, sh2Assembly5308PerBatchPerCycle: models.Sh2Assembly5308PerBatchPerCycle | null) : Observable<any> {
    return this.odata.post(`/Sh2Assembly5308PerBatchPerCycles`, sh2Assembly5308PerBatchPerCycle, { expand }, []);
  }

  deleteSh2Assembly5308PerBatchPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh2Assembly5308PerBatchPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh2Assembly5308PerBatchPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh2Assembly5308PerBatchPerCycles(${rowId})`, { expand });
  }

  updateSh2Assembly5308PerBatchPerCycle(expand: string | null, rowId: number | null, sh2Assembly5308PerBatchPerCycle: models.Sh2Assembly5308PerBatchPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Sh2Assembly5308PerBatchPerCycles(${rowId})`, sh2Assembly5308PerBatchPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getSh2Assembly5308PerShiftPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh2Assembly5308PerShiftPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh2Assembly5308PerShiftPerCycle(expand: string | null, sh2Assembly5308PerShiftPerCycle: models.Sh2Assembly5308PerShiftPerCycle | null) : Observable<any> {
    return this.odata.post(`/Sh2Assembly5308PerShiftPerCycles`, sh2Assembly5308PerShiftPerCycle, { expand }, []);
  }

  deleteSh2Assembly5308PerShiftPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh2Assembly5308PerShiftPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh2Assembly5308PerShiftPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh2Assembly5308PerShiftPerCycles(${rowId})`, { expand });
  }

  updateSh2Assembly5308PerShiftPerCycle(expand: string | null, rowId: number | null, sh2Assembly5308PerShiftPerCycle: models.Sh2Assembly5308PerShiftPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Sh2Assembly5308PerShiftPerCycles(${rowId})`, sh2Assembly5308PerShiftPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getSh2Assembly5308Shifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh2Assembly5308Shifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh2Assembly5308Shift(expand: string | null, sh2Assembly5308Shift: models.Sh2Assembly5308Shift | null) : Observable<any> {
    return this.odata.post(`/Sh2Assembly5308Shifts`, sh2Assembly5308Shift, { expand }, []);
  }

  deleteSh2Assembly5308Shift(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh2Assembly5308Shifts(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh2Assembly5308ShiftByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh2Assembly5308Shifts(${rowId})`, { expand });
  }

  updateSh2Assembly5308Shift(expand: string | null, rowId: number | null, sh2Assembly5308Shift: models.Sh2Assembly5308Shift | null) : Observable<any> {
    return this.odata.patch(`/Sh2Assembly5308Shifts(${rowId})`, sh2Assembly5308Shift, item => item.RowID == rowId, { expand }, []);
  }

  getSh2PickAndPlace5307Batches(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh2PickAndPlace5307Batches`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh2PickAndPlace5307Batch(expand: string | null, sh2PickAndPlace5307Batch: models.Sh2PickAndPlace5307Batch | null) : Observable<any> {
    return this.odata.post(`/Sh2PickAndPlace5307Batches`, sh2PickAndPlace5307Batch, { expand }, []);
  }

  deleteSh2PickAndPlace5307Batch(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh2PickAndPlace5307Batches(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh2PickAndPlace5307BatchByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh2PickAndPlace5307Batches(${rowId})`, { expand });
  }

  updateSh2PickAndPlace5307Batch(expand: string | null, rowId: number | null, sh2PickAndPlace5307Batch: models.Sh2PickAndPlace5307Batch | null) : Observable<any> {
    return this.odata.patch(`/Sh2PickAndPlace5307Batches(${rowId})`, sh2PickAndPlace5307Batch, item => item.RowID == rowId, { expand }, []);
  }

  getSh2PickAndPlace5307Data(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh2PickAndPlace5307Data`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh2PickAndPlace5307Datum(expand: string | null, sh2PickAndPlace5307Datum: models.Sh2PickAndPlace5307Datum | null) : Observable<any> {
    return this.odata.post(`/Sh2PickAndPlace5307Data`, sh2PickAndPlace5307Datum, { expand }, []);
  }

  deleteSh2PickAndPlace5307Datum(id: number | null) : Observable<any> {
    return this.odata.delete(`/Sh2PickAndPlace5307Data(${id})`, item => !(item.id == id));
  }

  getSh2PickAndPlace5307DatumByid(expand: string | null, id: number | null) : Observable<any> {
    return this.odata.getById(`/Sh2PickAndPlace5307Data(${id})`, { expand });
  }

  updateSh2PickAndPlace5307Datum(expand: string | null, id: number | null, sh2PickAndPlace5307Datum: models.Sh2PickAndPlace5307Datum | null) : Observable<any> {
    return this.odata.patch(`/Sh2PickAndPlace5307Data(${id})`, sh2PickAndPlace5307Datum, item => item.id == id, { expand }, []);
  }

  getSh2PickAndPlace5307PerBatchPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh2PickAndPlace5307PerBatchPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh2PickAndPlace5307PerBatchPerCycle(expand: string | null, sh2PickAndPlace5307PerBatchPerCycle: models.Sh2PickAndPlace5307PerBatchPerCycle | null) : Observable<any> {
    return this.odata.post(`/Sh2PickAndPlace5307PerBatchPerCycles`, sh2PickAndPlace5307PerBatchPerCycle, { expand }, []);
  }

  deleteSh2PickAndPlace5307PerBatchPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh2PickAndPlace5307PerBatchPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh2PickAndPlace5307PerBatchPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh2PickAndPlace5307PerBatchPerCycles(${rowId})`, { expand });
  }

  updateSh2PickAndPlace5307PerBatchPerCycle(expand: string | null, rowId: number | null, sh2PickAndPlace5307PerBatchPerCycle: models.Sh2PickAndPlace5307PerBatchPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Sh2PickAndPlace5307PerBatchPerCycles(${rowId})`, sh2PickAndPlace5307PerBatchPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getSh2PickAndPlace5307PerShiftPerCycles(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh2PickAndPlace5307PerShiftPerCycles`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh2PickAndPlace5307PerShiftPerCycle(expand: string | null, sh2PickAndPlace5307PerShiftPerCycle: models.Sh2PickAndPlace5307PerShiftPerCycle | null) : Observable<any> {
    return this.odata.post(`/Sh2PickAndPlace5307PerShiftPerCycles`, sh2PickAndPlace5307PerShiftPerCycle, { expand }, []);
  }

  deleteSh2PickAndPlace5307PerShiftPerCycle(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh2PickAndPlace5307PerShiftPerCycles(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh2PickAndPlace5307PerShiftPerCycleByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh2PickAndPlace5307PerShiftPerCycles(${rowId})`, { expand });
  }

  updateSh2PickAndPlace5307PerShiftPerCycle(expand: string | null, rowId: number | null, sh2PickAndPlace5307PerShiftPerCycle: models.Sh2PickAndPlace5307PerShiftPerCycle | null) : Observable<any> {
    return this.odata.patch(`/Sh2PickAndPlace5307PerShiftPerCycles(${rowId})`, sh2PickAndPlace5307PerShiftPerCycle, item => item.RowID == rowId, { expand }, []);
  }

  getSh2PickAndPlace5307Shifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Sh2PickAndPlace5307Shifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createSh2PickAndPlace5307Shift(expand: string | null, sh2PickAndPlace5307Shift: models.Sh2PickAndPlace5307Shift | null) : Observable<any> {
    return this.odata.post(`/Sh2PickAndPlace5307Shifts`, sh2PickAndPlace5307Shift, { expand }, []);
  }

  deleteSh2PickAndPlace5307Shift(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/Sh2PickAndPlace5307Shifts(${rowId})`, item => !(item.RowID == rowId));
  }

  getSh2PickAndPlace5307ShiftByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/Sh2PickAndPlace5307Shifts(${rowId})`, { expand });
  }

  updateSh2PickAndPlace5307Shift(expand: string | null, rowId: number | null, sh2PickAndPlace5307Shift: models.Sh2PickAndPlace5307Shift | null) : Observable<any> {
    return this.odata.patch(`/Sh2PickAndPlace5307Shifts(${rowId})`, sh2PickAndPlace5307Shift, item => item.RowID == rowId, { expand }, []);
  }

  getShifts(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Shifts`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createShift(expand: string | null, shift: models.Shift | null) : Observable<any> {
    return this.odata.post(`/Shifts`, shift, { expand }, []);
  }

  deleteShift(shiftId: number | null) : Observable<any> {
    return this.odata.delete(`/Shifts(${shiftId})`, item => !(item.ShiftID == shiftId));
  }

  getShiftByShiftId(expand: string | null, shiftId: number | null) : Observable<any> {
    return this.odata.getById(`/Shifts(${shiftId})`, { expand });
  }

  updateShift(expand: string | null, shiftId: number | null, shift: models.Shift | null) : Observable<any> {
    return this.odata.patch(`/Shifts(${shiftId})`, shift, item => item.ShiftID == shiftId, { expand }, []);
  }

  getShiftHourReports(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/ShiftHourReports`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createShiftHourReport(expand: string | null, shiftHourReport: models.ShiftHourReport | null) : Observable<any> {
    return this.odata.post(`/ShiftHourReports`, shiftHourReport, { expand }, []);
  }

  deleteShiftHourReport(rowId: number | null) : Observable<any> {
    return this.odata.delete(`/ShiftHourReports(${rowId})`, item => !(item.RowID == rowId));
  }

  getShiftHourReportByRowId(expand: string | null, rowId: number | null) : Observable<any> {
    return this.odata.getById(`/ShiftHourReports(${rowId})`, { expand });
  }

  updateShiftHourReport(expand: string | null, rowId: number | null, shiftHourReport: models.ShiftHourReport | null) : Observable<any> {
    return this.odata.patch(`/ShiftHourReports(${rowId})`, shiftHourReport, item => item.RowID == rowId, { expand }, []);
  }

  getShiftHourReport1S(batchId: string | null, machineId: number | null, shift: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/ShiftHourReport1sFunc(BatchID='${encodeURIComponent(batchId)}',MachineID=${machineId},Shift='${encodeURIComponent(shift)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  shiftHourReportFm1Assembly5201S() : Observable<any> {
    return this.odata.get(`/ShiftHourReportFm1Assembly5201sFunc()`, {  });
  }

  shiftHourReportFm1PickAndPlace5219S() : Observable<any> {
    return this.odata.get(`/ShiftHourReportFm1PickAndPlace5219sFunc()`, {  });
  }

  shiftHourReportFm2Assembly5306S() : Observable<any> {
    return this.odata.get(`/ShiftHourReportFm2Assembly5306sFunc()`, {  });
  }

  shiftHourReportFm2PickAndPlace5305S() : Observable<any> {
    return this.odata.get(`/ShiftHourReportFm2PickAndPlace5305sFunc()`, {  });
  }

  getShiftHourReportLastRowIds(lastRowId: number | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/ShiftHourReportLastRowIdsFunc(LastRowID=${lastRowId})`, { filter, top, skip, orderby, count, expand, format, select });
  }

  shiftHourReportSh1Assembly5202S() : Observable<any> {
    return this.odata.get(`/ShiftHourReportSh1Assembly5202sFunc()`, {  });
  }

  shiftHourReportSh1PickAndPlace5220S() : Observable<any> {
    return this.odata.get(`/ShiftHourReportSh1PickAndPlace5220sFunc()`, {  });
  }

  shiftHourReportSh2Assembly5308S() : Observable<any> {
    return this.odata.get(`/ShiftHourReportSh2Assembly5308sFunc()`, {  });
  }

  shiftHourReportSh2PickAndPlace5307S() : Observable<any> {
    return this.odata.get(`/ShiftHourReportSh2PickAndPlace5307sFunc()`, {  });
  }

  getShiftReportDashTimers(machineId: number | null, batchId: string | null, shift: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/ShiftReportDashTimersFunc(MachineID=${machineId},BatchID='${encodeURIComponent(batchId)}',Shift='${encodeURIComponent(shift)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getShiftReportDashTimersGroupeds(machineId: number | null, batchId: string | null, shift: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/ShiftReportDashTimersGroupedsFunc(MachineID=${machineId},BatchID='${encodeURIComponent(batchId)}',Shift='${encodeURIComponent(shift)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getShiftReportDashTotalGodBads(machineId: number | null, batchId: string | null, shift: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/ShiftReportDashTotalGodBadsFunc(MachineID=${machineId},BatchID='${encodeURIComponent(batchId)}',Shift='${encodeURIComponent(shift)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getSpBacthReportDashes(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/SpBacthReportDashesFunc()`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getSpBacthReportHeaders(machineId: number | null, batchId: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/SpBacthReportHeadersFunc(MachineID=${machineId},BatchID='${encodeURIComponent(batchId)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getSpBacthReportHeaderRows(machineId: number | null, batchId: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/SpBacthReportHeaderRowsFunc(MachineID=${machineId},BatchID='${encodeURIComponent(batchId)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getSpBatchHourValuesGrids(mAchineId: number | null, batchId: string | null, tagGroup: string | null, tagType: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/SpBatchHourValuesGridsFunc(MAchineID=${mAchineId},BatchID='${encodeURIComponent(batchId)}',TagGroup='${encodeURIComponent(tagGroup)}',TagType='${encodeURIComponent(tagType)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getSpBatchLists(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/SpBatchListsFunc()`, { filter, top, skip, orderby, count, expand, format, select });
  }

  spClearDataTables() : Observable<any> {
    return this.odata.get(`/SpClearDataTablesFunc()`, {  });
  }

  getSpHourValues(mAchineId: number | null, batchId: string | null, tagGroup: string | null, tagType: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/SpHourValuesFunc(MAchineID=${mAchineId},BatchID='${encodeURIComponent(batchId)}',TagGroup='${encodeURIComponent(tagGroup)}',TagType='${encodeURIComponent(tagType)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getSpHourValuesGrids(mAchineId: number | null, batchId: string | null, tagGroup: string | null, tagType: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/SpHourValuesGridsFunc(MAchineID=${mAchineId},BatchID='${encodeURIComponent(batchId)}',TagGroup='${encodeURIComponent(tagGroup)}',TagType='${encodeURIComponent(tagType)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getSpHourValuesShifts(mAchineId: number | null, batchId: string | null, shift: string | null, tagGroup: string | null, tagType: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/SpHourValuesShiftsFunc(MAchineID=${mAchineId},BatchID='${encodeURIComponent(batchId)}',Shift='${encodeURIComponent(shift)}',TagGroup='${encodeURIComponent(tagGroup)}',TagType='${encodeURIComponent(tagType)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  spPopulateHourValues() : Observable<any> {
    return this.odata.get(`/SpPopulateHourValuesFunc()`, {  });
  }

  getSpShiftHourValuesGrids(mAchineId: number | null, batchId: string | null, shift: string | null, tagType: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/SpShiftHourValuesGridsFunc(MAchineID=${mAchineId},BatchID='${encodeURIComponent(batchId)}',Shift='${encodeURIComponent(shift)}',TagType='${encodeURIComponent(tagType)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getSpShiftReportDashes(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/SpShiftReportDashesFunc()`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getSpShiftReportHeaders(machineId: number | null, batchId: string | null, shift: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/SpShiftReportHeadersFunc(MachineID=${machineId},BatchID='${encodeURIComponent(batchId)}',Shift='${encodeURIComponent(shift)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getSpStopTimeChartSources(machineId: number | null, batchId: string | null, filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/SpStopTimeChartSourcesFunc(MachineID=${machineId},BatchID='${encodeURIComponent(batchId)}')`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getTags(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/Tags`, { filter, top, skip, orderby, count, expand, format, select });
  }

  createTag(expand: string | null, tag: models.Tag | null) : Observable<any> {
    return this.odata.post(`/Tags`, tag, { expand }, []);
  }

  deleteTag(tagId: number | null) : Observable<any> {
    return this.odata.delete(`/Tags(${tagId})`, item => !(item.TagID == tagId));
  }

  getTagByTagId(expand: string | null, tagId: number | null) : Observable<any> {
    return this.odata.getById(`/Tags(${tagId})`, { expand });
  }

  updateTag(expand: string | null, tagId: number | null, tag: models.Tag | null) : Observable<any> {
    return this.odata.patch(`/Tags(${tagId})`, tag, item => item.TagID == tagId, { expand }, []);
  }

  getTestSh1PickAndPlace5220ShiftPerHours(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/TestSh1PickAndPlace5220ShiftPerHours`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getVBacthReportHeaderRows(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/VBacthReportHeaderRows`, { filter, top, skip, orderby, count, expand, format, select });
  }

  getVChartData(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null, format: string | null, select: string | null) : Observable<any> {
    return this.odata.get(`/VChartData`, { filter, top, skip, orderby, count, expand, format, select });
  }
}
