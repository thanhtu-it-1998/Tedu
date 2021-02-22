import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-show-dep',
  templateUrl: './show-dep.component.html',
  styleUrls: ['./show-dep.component.css']
})
export class ShowDepComponent implements OnInit {

  DepartmentList: any[];
  ModalTitle: string;
  ActivateAddEditDepComp: boolean = false;
  dep: any;


  constructor(private service: SharedService) { }

  ngOnInit(): void {
    this.refreshDepList();
  }

  refreshDepList() {
    this.service.getDepList().subscribe(data => {
      this.DepartmentList = data
    });
  }

  addClick() {
    this.dep = {
      ID: 0,
      Name: ""
    }
    this.ModalTitle = "Add Department";
    this.ActivateAddEditDepComp = true;
  }
  editClick(item) {
    this.dep = item;
    this.ModalTitle = "Edit Department";
    this.ActivateAddEditDepComp = true;
  }
  deleteClick(item) {
    if (confirm('Are you sure??')) {
      this.service.deleteDepartment(item.ID).subscribe(data => {
        alert(data.toString());
        this.refreshDepList();
      })
    }
  }
  closeClick() {
    this.ActivateAddEditDepComp = false;
    this.refreshDepList();
  }
}
