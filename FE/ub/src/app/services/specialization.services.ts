import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ISpecializationDto } from "../models/response/specialization.model";
import { BaseService } from "./base.service";

@Injectable({
    providedIn: 'root'
})
export class SpecializationService extends BaseService {
    private controllerPath = `${this.apiPath}/specialization`;

    constructor(
        private http: HttpClient,
    ) { super(); }

    getAll(): Observable<ISpecializationDto[]> {
        return this.http.get<ISpecializationDto[]>(this.controllerPath);
    }
}