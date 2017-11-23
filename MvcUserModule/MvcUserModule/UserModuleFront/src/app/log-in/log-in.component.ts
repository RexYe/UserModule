import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {JQuery} from 'JQuery';

@Component({
	selector: 'app-log-in',
	templateUrl: './log-in.component.html',
	styleUrls: ['./log-in.component.css'],
	encapsulation: ViewEncapsulation.None
})

@NgModule({
	imports: [
		CommonModule,
		RouterModule.forChild([
			{path:'', component: LogInComponent}
		])
	]
})
export class LogInComponent implements OnInit {
	constructor() { }
	ngOnInit() {
		console.log(1)
	}
}
