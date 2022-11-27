import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { IRecomendationDto } from "../models/response/recomendation.model";
import { BaseService } from "./base.service";

@Injectable({
    providedIn: 'root'
})
export class RecomendationService extends BaseService {
    private controllerPath = `${this.apiPath}/recomendation`;

    constructor(
        private http: HttpClient,
    ) { super(); }

    generate(welcomeFormId: string): Observable<IRecomendationDto[]> {
        return this.http.get<IRecomendationDto[]>(`${this.controllerPath}/genarate`, {
            params: new HttpParams().set('welcomeFormId', welcomeFormId),
        });
    }
}