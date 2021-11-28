import { Component, OnInit } from '@angular/core';
import { ManagerService } from '../Services/manager.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private service: ManagerService) { }

  ngOnInit(): void {
    this.service.tz = "";
  }

}
