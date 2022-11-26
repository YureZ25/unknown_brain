import { Component } from '@angular/core';
import { GradeService } from 'src/app/services/grade.service';
import { IGradeDto } from 'src/app/models/grade.model';
import { ISpecialization } from 'src/app/models/specialization.model';
import { SpecializationService } from 'src/app/services/specialization.services';

@Component({
  selector: 'app-welcome-form',
  templateUrl: './welcome-form.component.html',
  styleUrls: ['./welcome-form.component.css']
})
export class WelcomeFormComponent {
  grades: IGradeDto[] | undefined;
  specs: ISpecialization[] | undefined;

  grade: IGradeDto | undefined;
  spec: ISpecialization | undefined;

  constructor(
    private gradeService: GradeService,
    private specializationService: SpecializationService,
  ) { }

  ngOnInit() {
    
  }
}
