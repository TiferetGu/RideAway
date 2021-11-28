import { Component, OnInit } from '@angular/core';
import { ManagerService } from '../Services/manager.service';

@Component({
  selector: 'app-reason-of-delay',
  templateUrl: './reason-of-delay.component.html',
  styleUrls: ['./reason-of-delay.component.css']
})
export class ReasonOfDelayComponent implements OnInit {

  constructor(private service: ManagerService) { }

  ngOnInit(): void {
  }
reset(){
  this.service.tz = "123456789"
}
}
