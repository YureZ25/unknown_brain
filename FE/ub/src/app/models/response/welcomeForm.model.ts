import { IGradeDto } from "./grade.model";
import { ISpecializationDto } from "./specialization.model";
import { IUserDto } from "./user.model";

export interface IWelcomeFormDto
{
    id: string;
    isPM: boolean;
    isDocWriter: boolean;
    user: IUserDto | undefined;
    grade: IGradeDto | undefined;
    specialization: ISpecializationDto | undefined;
    comment: string | undefined;
}