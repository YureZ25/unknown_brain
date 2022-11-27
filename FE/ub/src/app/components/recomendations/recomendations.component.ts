import { Component } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { IRecomendationDto } from 'src/app/models/response/recomendation.model';
import { IWelcomeFormDto } from 'src/app/models/response/welcomeForm.model';
import { RecomendationService } from 'src/app/services/recomendation.service';
import { WelcomeFormService } from 'src/app/services/welcome-form.service';

@Component({
  selector: 'app-recomendations',
  templateUrl: './recomendations.component.html',
  styleUrls: ['./recomendations.component.css']
})
export class RecomendationsComponent {
  welcomeFormId: string | undefined;
  welcomeForm: IWelcomeFormDto | undefined;

  recomendations: IRecomendationDto[] | undefined;

  constructor(
    private route: ActivatedRoute,
    private welcomeFormService: WelcomeFormService,
    private recomendationService: RecomendationService,
  ) { }
  
  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      this.welcomeFormId = params['welcomeFormId'];
      if (this.welcomeFormId) {
        this.welcomeFormService.getById(this.welcomeFormId)
          .subscribe(data => this.welcomeForm = data);
        this.recomendationService.generate(this.welcomeFormId)
          .subscribe(data => this.recomendations = data);
      }
    });
  }
}
