import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { GradeService } from 'src/app/services/grade.service';
import { IGradeDto } from 'src/app/models/response/grade.model';
import { ISpecializationDto } from 'src/app/models/response/specialization.model';
import { SpecializationService } from 'src/app/services/specialization.services';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { IWelcomeFormVM, WelcomeFormVM } from 'src/app/models/request/welcomeForm.model';
import { WelcomeFormService } from 'src/app/services/welcome-form.service';

interface IWelcomeFormFields
{
  userName: string;
  specialization: ISpecializationDto;
  grade: IGradeDto;
  isPM: boolean;
  isDocWriter: boolean;
  comment: string | undefined;
}

@Component({
  selector: 'app-welcome-form',
  templateUrl: './welcome-form.component.html',
  styleUrls: ['./welcome-form.component.css']
})
export class WelcomeFormComponent {
  grades: IGradeDto[] | undefined;
  specs: ISpecializationDto[] | undefined;

  welcomeForm: FormGroup;

  constructor(
    private route: Router,
    private gradeService: GradeService,
    private specializationService: SpecializationService,
    private welcomeFormService: WelcomeFormService,
  ) { 
    this.welcomeForm = new FormGroup({
      userName: new FormControl('', [ Validators.required ]),
      specialization: new FormControl(null, [ Validators.required ]),
      grade: new FormControl(null, [ Validators.required ]),
      isPM: new FormControl(false, [ Validators.required ]),
      isDocWriter: new FormControl(false, [ Validators.required ]),
      comment: new FormControl(''),
    });
  }

  ngOnInit() {
    this.gradeService.getAll().subscribe(data => this.grades = data);
    this.specializationService.getAll().subscribe(data => this.specs = data);
  }

  public isFieldInvalid(field: string): boolean {
    if (this.welcomeForm.controls[field].invalid 
      && this.welcomeForm.controls[field].touched) {
      return true; 
    }
    return false;
  }

  public submit(): void {
    const data = this.welcomeForm.getRawValue();
    this.postForm(data);
  }

  public touchForm() {
    for (let control in this.welcomeForm.controls) {
      this.welcomeForm.controls[control].markAsTouched();
      console.log(control)
    }
  }
    
  private postForm(data: IWelcomeFormFields): void {
    const body: WelcomeFormVM = new WelcomeFormVM({
      userName: data.userName,
      specializationId: data.specialization.id,
      gradeId: data.grade.id,
      isPM: data.isPM,
      isDocWriter: data.isDocWriter,
      comment: data.comment,
    });
    this.welcomeFormService.post(body).subscribe(data => {
      this.route.navigate(
        ['/recomendations'],
        {
          queryParams: {
            'welcomeFormId': data.id,
          },
        },
      );
    });
  }
}
