import { Component, OnInit } from '@angular/core';
import { ManagerService } from '../Services/manager.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-thank-you',
  templateUrl: './thank-you.component.html',
  styleUrls: ['./thank-you.component.css']
})
export class ThankYouComponent implements OnInit {

  constructor(private service: ManagerService, private router: Router) { }

  ngOnInit(): void {
  }

  timeisup(){
    //return 2;
    if (this.service.tz == "123456789")
      return 1;
    else if (this.service.tz == "234567891")
      return 2;
       this.router.navigate(['/base/delay']);
  }
}
