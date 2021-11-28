import { Component, OnInit, ViewChild, ElementRef, Renderer2 } from '@angular/core';
import { Router } from '@angular/router';
import { Line } from '../Classes/Line';
import { ManagerService } from '../Services/manager.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {
  public busLines: Line[];
  @ViewChild('one') d: ElementRef<HTMLInputElement>;


  constructor(private r: Router, private service: ManagerService, private elementRef: ElementRef, private renderer: Renderer2) {
    this.busLines = [
      new Line(1, "36"),
      new Line(2, "72"),
      new Line(1, "64"),
      new Line(1, "71"),
      new Line(1, "32"),
      new Line(1, "31"),
      new Line(1, "37"),
      new Line(1, "63"),
    ];;
  }
  ngOnInit(): void {
    // this.service.getBusLines("Lines", "131").subscribe((res: string[]) => {
    //   this.busLines = res;
    // });
  }
  ngAfterViewInit() {
    var c = 0;
    this.busLines.forEach(l => {
      c= c+1;
      var button = document.createElement('button');
      var br = document.createElement('br');
      if(c==5){
        this.d.nativeElement.appendChild(br);
      }
      button.innerText = l.line;
      button.className = 'btn btn-success';
      button.style.margin = '1vw';
      button.style.width = '10vw';
      button.style.height = '20vh';
      button.style.marginTop = '5vh';
      button.style.marginBottom = '0vh';
      button.style.marginLeft = '1vw';
      button.style.fontSize = '120%';
      button.style.borderRadius = '9%';


      this.d.nativeElement.appendChild(button);
    });
  }

}
