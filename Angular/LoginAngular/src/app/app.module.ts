import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { MyTitlePipe } from './my-title.pipe';
import { LoginComponent } from './login/login.component';
import { CustomerrorComponent } from './customerror/customerror.component';

@NgModule({
  declarations: [
    AppComponent,
    MyTitlePipe,
    LoginComponent,
    CustomerrorComponent
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