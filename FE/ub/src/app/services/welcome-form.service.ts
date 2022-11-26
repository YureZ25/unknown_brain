import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { BaseService } from "./base.service";
import { WelcomeFormVM } from "../models/request/welcomeForm.model";
import { Observable } from "rxjs";
import { IWelcomeFormDto } from "../models/response/welcomeForm.model";

@Injectable({
    providedIn: 'root'
})
export class WelcomeFormService extends BaseService {
    private controllerPath = `${this.apiPath}/welcome-form`;

    constructor(
        private http: HttpClient,
    ) { super(); }

    post(body: WelcomeFormVM): Observable<IWelcomeFormDto> {
        return this.http.post<IWelcomeFormDto>(this.controllerPath, body);
    }
}