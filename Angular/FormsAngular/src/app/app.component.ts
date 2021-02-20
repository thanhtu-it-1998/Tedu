import { Component } from '@angular/core';
import { NgForm } from '@angular/forms'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  RegisterStudent(studentForm: NgForm): void {   
    var firstName = studentForm.controls.firstName.value;
    var lastName = studentForm.controls.lastName.value;
    var email = studentForm.controls.email.value;
    debugger;
    console.log(studentForm.value);

  }
}