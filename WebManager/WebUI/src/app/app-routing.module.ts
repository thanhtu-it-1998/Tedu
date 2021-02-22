import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { from } from 'rxjs';

import {EmployeeComponent} from './employee/employee.component';
import {DepartmentComponent} from './department/department.component';
const routes: Routes = [
  {path:'',redirectTo:'Employee',pathMatch:'full'},
  {path:'Employee' ,component:EmployeeComponent},
  {path:'Department',component:DepartmentComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
