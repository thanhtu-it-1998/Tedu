import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import{ShowDepComponent} from 'src/app/department/show-dep/show-dep.component';

@Component({
  selector: 'app-add-edit-dep',
  templateUrl: './add-edit-dep.component.html',
  styleUrls: ['./add-edit-dep.component.css']
})
export class AddEditDepComponent implements OnInit {

  constructor(private service: SharedService) { }

  @Input() dep: any;
  ID: string;
  Name: string

  ngOnInit(): void {
    this.ID = this.dep.ID;
    this.Name = this.dep.Name;
  }

  addDepartment() {
    var val = {
      ID: this.ID,
      Name: this.Name
    };
    this.service.addDepartment(val).subscribe(res => {
      alert(res.toString());
    });
  }

  updateDepartment() {
    var val = {
      ID: this.ID,
      Name: this.Name
    };
    this.service.updateDepartment(val).subscribe(res => {
      alert(res.toString());
    });
  }
}
