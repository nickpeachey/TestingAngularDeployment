import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-app-users',
    templateUrl: './app-users.component.html',
    styleUrls: ['./app-users.component.css']
})
/** app-users component*/
export class AppUsersComponent {

  public appUsers: AppUserAuth[];
    /** app-users ctor */
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<AppUserAuth[]>(baseUrl + 'api/AppUsers').subscribe(result => {
      this.appUsers = result;
      console.log(result);
    }, error => console.error(error));
  }
}


interface AppUserAuth {
  id: number;
  userName: string;
  canAccessProducts: boolean;
}
