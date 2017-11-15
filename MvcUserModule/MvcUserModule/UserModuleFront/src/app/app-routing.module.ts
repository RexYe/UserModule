import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {rootRouterModule} from './app.router';
const routes: Routes = [];

@NgModule({
	imports: [
		RouterModule.forRoot(routes),
		//rootRouterModule
	],
	exports: [RouterModule]
})
export class AppRoutingModule { }
