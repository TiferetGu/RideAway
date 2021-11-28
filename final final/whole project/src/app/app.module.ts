import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { AppComponent } from './app.component';
import {RouterModule} from '@angular/router'
import {ROUTES} from './routes';
import {HttpClientModule} from '@angular/common/http';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { BaseDesignComponent } from './base-design/base-design.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { DetailsComponent } from './details/details.component';
import { ThankYouComponent } from './thank-you/thank-you.component';
import { LoginComponent } from './login/login.component';
import { NumKeypadComponent } from './num-kepad/num-keypad.component';
import { ReasonOfDelayComponent } from './reason-of-delay/reason-of-delay.component';



@NgModule({
  declarations: [
    AppComponent,
    FetchDataComponent,
    BaseDesignComponent,
    SignInComponent,
    DetailsComponent,
    ThankYouComponent,
    LoginComponent,
    NumKeypadComponent,
    ReasonOfDelayComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(ROUTES),
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
