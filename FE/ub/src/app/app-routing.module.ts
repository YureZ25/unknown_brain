import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { RecomendationsComponent } from './components/recomendations/recomendations.component';
import { WelcomeFormComponent } from './components/welcome-form/welcome-form.component';

const routes: Routes = [
  { path: '', component: WelcomeFormComponent },
  { path: 'recomendations', component: RecomendationsComponent }
];

@NgModule({
  imports: [BrowserModule, RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
