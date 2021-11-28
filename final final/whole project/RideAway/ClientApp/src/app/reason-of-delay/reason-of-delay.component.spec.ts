import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReasonOfDelayComponent } from './reason-of-delay.component';

describe('ReasonOfDelayComponent', () => {
  let component: ReasonOfDelayComponent;
  let fixture: ComponentFixture<ReasonOfDelayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReasonOfDelayComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReasonOfDelayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
