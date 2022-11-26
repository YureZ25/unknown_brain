export interface IWelcomeFormVM
{
    userName: string | undefined;
    specializationId: string | undefined;
    gradeId: string | undefined;
    isPM: boolean | undefined;
    isDocWriter: boolean | undefined;
}

export class WelcomeFormVM implements IWelcomeFormVM {
    userName: string | undefined;
    specializationId: string | undefined;
    gradeId: string | undefined;
    isPM: boolean | undefined;
    isDocWriter: boolean | undefined;
    
    constructor(data?: IWelcomeFormVM) {
        this.userName = data?.userName;
        this.specializationId = data?.specializationId;
        this.gradeId = data?.gradeId;
        this.isPM = data?.isPM;
        this.isDocWriter = data?.isDocWriter;
    }
}