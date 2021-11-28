import { Routes } from '@angular/router';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { BaseDesignComponent } from './base-design/base-design.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { DetailsComponent } from './details/details.component';
import { ThankYouComponent } from './thank-you/thank-you.component';
import { LoginComponent } from './login/login.component';
import { NumKeypadComponent } from './num-kepad/num-keypad.component';
import { ReasonOfDelayComponent } from './reason-of-delay/reason-of-delay.component';



export const ROUTES: Routes = [
    { path: '', component: LoginComponent },
    { path: 'fetch-data', component: FetchDataComponent },
    {
        
        path: 'base', component: BaseDesignComponent,
        children: [
            { path: 'fetch-data', component: FetchDataComponent },
            {
                path: '', component: SignInComponent,
                children: [
                    // { path: '', component: NumKeypadComponent },
                ]
            },
            { path: 'details', component: DetailsComponent },
            { path: 'thanks', component: ThankYouComponent },
            { path: 'delay', component: ReasonOfDelayComponent },
        ],
    },

]; 