import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { StudentComponent } from './student/student.component';
import { StudentdetailComponent } from './studentdetail/studentdetail.component';

const routes: Routes = [{
  path:'',redirectTo:'Login',pathMatch:'full'
},{
  path:'studentLink',component:StudentComponent
},
{
  path:'studentdetailsLink',component:StudentdetailComponent
},
{
  path:'Login',component:LoginComponent
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
