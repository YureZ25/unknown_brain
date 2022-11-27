import { IGradeDto } from "./grade.model";

export interface IUserDto
{
    id: string;
    userName: string | undefined;
    grade: IGradeDto | undefined;
}