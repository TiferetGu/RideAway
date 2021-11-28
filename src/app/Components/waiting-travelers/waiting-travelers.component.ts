import { Component, OnInit } from '@angular/core';
import { ChartsModule, ModalModule, WavesModule } from 'angular-bootstrap-md'
import { DataService } from 'src/app/bootstrap/Services/data.service';
import { Passenger } from 'src/app/Passenger';
import {BusLines} from 'src/app/BusLines'



@Component({
  selector: 'app-waiting-travelers',
  templateUrl: './waiting-travelers.component.html',
  styleUrls: ['./waiting-travelers.component.css']
})
export class WaitingTravelersComponent implements OnInit {

  passenger : Passenger;
  dataArr : BusLines[];
  showNewMessage:boolean = false;
  constructor(private dataService : DataService) { 
    this.dataService.getPassengers().subscribe((res: Passenger)=>{this.passenger=res});
     this.dataArr = this.dataService.busLines;
  }


  ngOnInit(): void {
  }
  //#region charts
  public chartType: string = 'bar';

 public chartDatasets: any[] = [
  { data: [14,22,20,10,5,20,36,15], label: 'מספר ממתינים' }
];


public chartLabels:  Array<any> = ['31','32','36','37','63','64','71','72'];

  public chartColors: Array<any> = [
    {
      backgroundColor: [
        'rgba(153, 255, 153, 0.7)',
        'rgba(102, 204, 102, 0.7)',
        'rgba(51, 153, 51, 0.7)',
        'rgba(0, 102, 51, 0.7)',
        'rgba(169, 233, 255, 0.7)',
        'rgba(153, 204, 255, 0.7)',
        'rgba(102, 153, 204, 0.7)',
        'rgba(76, 115, 147, 0.7)'
      ],
      borderColor: [
        'rgba(153, 255, 153, 1)',
        'rgba(102, 204, 102, 1)',
        'rgba(51, 153, 51, 1)',
        'rgba(0, 102, 51, 1)',
        'rgba(169, 233, 255, 1)',
        'rgba(153, 204, 255, 1)',
        'rgba(102, 153, 204, 1)',
        'rgba(76, 115, 147, 1)'
      ],
      borderWidth: 2,
    }
    ];

    public chartOptions: any = {
      responsive: true,
        scales: {
          xAxes: [{
            stacked: true
            }],
          yAxes: [
          {
            stacked: true
          }
        ]
      }
    };
    public chartClicked(modal: any,e:any): void {
      console.log(e.active[0]._index)
      this.displayImg();
      modal.show()
     
      
     }
    public chartHovered(e: any): void {

     }
    //#endregion
    display:any;
    public displayImg(){
this.display = true;
    }
    //#region table
    elements: any = [
      {headElements: 'האוטובוס לא הגיע', first: '12',second:'153', last: '315468526'},
      {headElements: 'האוטובוס חלף על פני התחנה ולא עצר', first: '10',second:'155', last: '11nnjnniec444356%%k'},
      {headElements: 'האוטובוס היה עמוס, לא הצלחתי לעלות', first: '20',second:'158', last: '210369754'},
    ];
  
    headElements = ['סיבת המתנה', 'זמן המתנה', 'מזהה תחנה','מזהה ממתין'];

    
//#endregion

//#region newtable

tableelements: any = [
  {headElements: 'האוטובוס לא הגיע', first: '12', second:'36',last: '315468526'},
  {headElements: 'האוטובוס חלף על פני התחנה ולא עצר', first: '10', second:'72', last: '11nnjnniec444356%%k'},
  {headElements: 'האוטובוס היה עמוס, לא הצלחתי לעלות', first: '7', second:'37', last: '63jluavzpy730275#%p'},
  {headElements: 'סיבת עיכוב אישית. אינה תלויה במערך התחבורה.', first: '19', second:'37', last: '53hkt@ky&m562047&!l'},
  {headElements: 'האוטובוס היה עמוס, לא הצלחתי לעלות', first: '5', second:'31', last: '034698715'},
  {headElements: 'האוטובוס חלף על פני התחנה ולא עצר', first: '8', second:'31', last: '210369754'},
  {headElements: 'האוטובוס היה עמוס, לא הצלחתי לעלות', first: '20', second:'71', last: '11kshskcre549204@&j'},
  {headElements: 'האוטובוס חלף על פני התחנה ולא עצר', first: '16', second:'31', last: '312035987'},
  {headElements: 'האוטובוס לא הגיע', first: '5', second:'71', last: '214798035'},
  {headElements: 'האוטובוס לא הגיע', first: '20', second:'31', last: '59knj@nitc379265%&k'},
];

tableheadElements = ['סיבת המתנה', 'זמן המתנה','מספר קו', 'מזהה ממתין'];

//#endregion

reasontableelements: any = [
  {headElements: 'האוטובוס לא הגיע', first: '12', second:'36',last: '315468526'},
  {headElements: 'האוטובוס לא הגיע', first: '20', second:'31', last: '59knj@nitc379265%&k'},
  {headElements: 'האוטובוס לא הגיע', first: '5', second:'71', last: '214798035'},
  {headElements: 'האוטובוס חלף על פני התחנה ולא עצר', first: '10', second:'72', last: '11nnjnniec444356%%k'},
  {headElements: 'האוטובוס חלף על פני התחנה ולא עצר', first: '16', second:'31', last: '312035987'},
  {headElements: 'האוטובוס חלף על פני התחנה ולא עצר', first: '8', second:'31', last: '210369754'},
  {headElements: 'האוטובוס היה עמוס, לא הצלחתי לעלות', first: '7', second:'37', last: '63jluavzpy730275#%p'},
  {headElements: 'האוטובוס היה עמוס, לא הצלחתי לעלות', first: '5', second:'31', last: '034698715'},
  {headElements: 'האוטובוס היה עמוס, לא הצלחתי לעלות', first: '20', second:'71', last: '11kshskcre549204@&j'},
  {headElements: 'סיבת עיכוב אישית. אינה תלויה במערך התחבורה.', first: '19', second:'37', last: '53hkt@ky&m562047&!l'},
];

mintableelements: any = [
  {headElements: 'האוטובוס חלף על פני התחנה ולא עצר', first: '10', second:'72', last: '11nnjnniec444356%%k'},
  {headElements: 'האוטובוס לא הגיע', first: '12', second:'36',last: '315468526'},
  {headElements: 'האוטובוס חלף על פני התחנה ולא עצר', first: '16', second:'31', last: '312035987'},
  {headElements: 'סיבת עיכוב אישית. אינה תלויה במערך התחבורה.', first: '19', second:'37', last: '53hkt@ky&m562047&!l'},
  {headElements: 'האוטובוס היה עמוס, לא הצלחתי לעלות', first: '20', second:'71', last: '11kshskcre549204@&j'},
  {headElements: 'האוטובוס לא הגיע', first: '20', second:'31', last: '59knj@nitc379265%&k'},

];

//#region linegraph
// public chartType1: string = 'line';

// public chartDatasets1: Array<any> = [
//   { data: [65, 59, 80, 81, 56, 55, 40], label: 'My First dataset' },
//   { data: [28, 48, 40, 19, 86, 27, 90], label: 'My Second dataset' }
// ];

// public chartLabels1: Array<any> = ['January', 'February', 'March', 'April', 'May', 'June', 'July'];

// public chartColors1: Array<any> = [
//   {
//     backgroundColor: 'rgba(105, 0, 132, .2)',
//     borderColor: 'rgba(200, 99, 132, .7)',
//     borderWidth: 2,
//   },
//   {
//     backgroundColor: 'rgba(0, 137, 132, .2)',
//     borderColor: 'rgba(0, 10, 130, .7)',
//     borderWidth: 2,
//   }
// ];

// public chartOptions1: any = {
//   responsive: true
// };
// public chartClicked1(e: any): void { }
// public chartHovered1(e: any): void { }
//#endregion

all:any;
reason:any;
min:any
public showTable(modal:any, e: any){
  if(e.path[0].innerHTML=="הכל"){
    this.all = true;
    this.reason = false;
    this.min = false;
  }
  if(e.path[0].innerHTML=="סיבה"){
    this.reason = true;
    this.all = false;
    this.min = false;
  }
  if(e.path[0].innerHTML=="מינימום דקות המתנה"){
    this.reason = false;
    this.all = false;
    this.min = true;
  }
  console.log(e.path[0].innerHTML);
  console.log(this.all);

}
num:any;
public submit(e:any){
this.num=true;
}
}
