import {Routes, RouterModule} from "@angular/router";
import {ModuleWithProviders} from "@angular/core";

const rootRouterConfig: Routes = [
	{path:"./log_in", component: "LogInComponent"}

];
export const  rootRouterModule: ModuleWithProviders = RouterModule.forRoot(rootRouterConfig,{useHash:true});