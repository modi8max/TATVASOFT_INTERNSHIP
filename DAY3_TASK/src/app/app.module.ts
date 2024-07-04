import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { PrivacyComponent } from './privacy/privacy.component';
import { MycomponentComponent } from './mycomponent/mycomponent.component';
//import { UserComponent } from './mycomponent/user/user.component';
//import { UserListComponent } from './mycomponent/user-list/user-list.component';
//import { AddUserComponent } from './mycomponent/add-user/add-user.component';





@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    HomeComponent,
    AboutComponent,
    PrivacyComponent,
    MycomponentComponent,
  // UserComponent,
   // UserListComponent,
    //AddUserComponent,
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
  
})
export class AppModule { }
