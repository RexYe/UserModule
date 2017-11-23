import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LogInComponent } from './log-in/log-in.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import {Routes, RouterModule} from '@angular/router';
import { DosthComponent } from './dosth/dosth.component';

const appRouter: Routes = [
    {path: 'log_in', component: LogInComponent},
    {path: 'sign_up', component: SignUpComponent},
    {path: 'do_sth', component: DosthComponent}
]

@NgModule({
    declarations: [
        AppComponent,
        LogInComponent,
        SignUpComponent,
        DosthComponent
    ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        RouterModule.forRoot(appRouter)
    ],
    providers: [],
    bootstrap: [AppComponent]
})

export class AppModule { }
