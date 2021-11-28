import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-base-design',
  templateUrl: './base-design.component.html',
  styleUrls: ['./base-design.component.css']
})
export class BaseDesignComponent implements OnInit {

  constructor(private r : Router) { }

  ngOnInit(): void {
  }

}
