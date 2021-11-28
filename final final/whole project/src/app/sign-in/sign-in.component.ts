import { Component, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { ManagerService } from '../Services/manager.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {
  
  constructor(private r: Router, public service: ManagerService, private router: Router) {
    // service.tz = this.tz;//הבעיה: הוא מכיר רק את הערך הדפולטיבי !!!!!
  }

  nav() {
    if (this.service.tz == "123456789"){
      this.router.navigate(['/base/details']);
      return;
    }
      
    else if (this.service.tz == "234567891"){
      this.router.navigate(['/base/thanks']);
      return;
    }
      
    this.router.navigate(['/base/delay']);

  }
  ngOnInit(): void {

  }

}
