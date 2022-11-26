import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { ISpecialization } from "../models/specialization.model";
import { BaseService } from "./base.service";

@Injectable({
    providedIn: 'root'
})
export class SpecializationService extends BaseService {
    private controllerPath = `${this.apiPath}/specialization`;

    constructor(
        private http: HttpClient,
    ) { super(); }

    getAll(): Observable<ISpecialization[]> {
        return this.http.get<ISpecialization[]>(this.controllerPath);
    }
}