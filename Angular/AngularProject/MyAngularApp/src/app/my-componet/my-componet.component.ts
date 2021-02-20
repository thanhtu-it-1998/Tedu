import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-my-componet',
  templateUrl: './my-componet.component.html',
  styleUrls: ['./my-componet.component.css']
})
export class MyComponetComponent implements OnInit {

  MyVariable = "Welcome to Angular Tutorials";
  constructor() { }

  ngOnInit(): void {
  }

}
