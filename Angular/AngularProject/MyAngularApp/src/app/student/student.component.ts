import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent  {

 Name: string ='Anurag';
 Branch: string = 'CSR';
 Mobile:number = 9304745623;
 Gender: string = 'Anurag';
 Age: number = 22;
}
