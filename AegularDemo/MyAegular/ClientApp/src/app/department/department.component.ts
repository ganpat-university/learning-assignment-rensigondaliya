import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'department',
  templateUrl: './department.component.html'
})

export class DepartmentComponent {

  public departments: Department[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Department[]>(baseUrl + 'api/DepartmentsApi').subscribe(result => {

      console.log(result);

      this.departments = result;
      console.log(this.departments);

    }, error => console.error(error));
  }

}


interface Department {
  departmentId: number,
  departmentName: string;
}
