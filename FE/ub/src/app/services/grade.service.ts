import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from "rxjs";
import { IGradeDto } from "../models/grade.model";
import { BaseService } from "./base.service";

@Injectable({
    providedIn: 'root'
})
export class GradeService extends BaseService {
    private controllerPath = `${this.apiPath}/grade`;

    constructor(
        private http: HttpClient,
    ) { super(); }

    getAll(): Observable<IGradeDto[]> {
        return this.http.get<IGradeDto[]>(`${this.controllerPath}`);
    }
}