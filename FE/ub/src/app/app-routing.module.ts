import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { RecomendationsComponent } from './components/recomendations/recomendations.component';
import { WelcomeFormComponent } from './components/welcome-form/welcome-form.component';

const routes: Routes = [
  { path: 'welcome', component: WelcomeFormComponent },
  { path: 'recomendations', component: RecomendationsComponent },
  { path: '', redirectTo: '/welcome', pathMatch: 'full' },
];

@NgModule({
  imports: [BrowserModule, RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
