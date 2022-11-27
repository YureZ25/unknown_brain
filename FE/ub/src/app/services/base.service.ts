import { environment } from "src/environments/environment";

export abstract class BaseService {
    protected apiPath: string = `${environment.API_URL}/api`;
}