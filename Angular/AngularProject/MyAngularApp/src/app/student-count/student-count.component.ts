import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-student-count',
  templateUrl: './student-count.component.html',
  styleUrls: ['./student-count.component.css']
})
export class StudentCountComponent {
  @Input()
  all: number = 5;
  @Input()
  male: number = 3;
  @Input()
  female: number = 2;

}