import { Component, OnInit, Input, EventEmitter, Output } from "@angular/core";

@Component({
  selector: 'num-keypad',
  templateUrl: './num-keypad.component.html',
  styleUrls: ['./num-keypad.component.css']
})
export class NumKeypadComponent implements OnInit {

  @Input()
  value: string;
  @Input()
  showNumKeypad: boolean;
  @Output()
  returnFunc: EventEmitter<any> = new EventEmitter<any>();
  @Output()
  valueChange: EventEmitter<any> = new EventEmitter<any>();
  @Output()
  showNumKeypadChange: EventEmitter<any> = new EventEmitter<any>();

  numbers: number[];

  constructor() { }

  ngOnInit() {
    this.numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
  }

  keyPress(number) {
    this.value = this.value ? this.value + number.toString() : number;
    this.valueChange.emit(this.value);
  }

  keyDelete() {
    this.value = this.value ? this.value.substring(0, this.value.length - 1) : this.value;
    this.valueChange.emit(this.value);
  }

  submit() {
    this.returnFunc.emit();
    this.showNumKeypad = false;
  }
} 
