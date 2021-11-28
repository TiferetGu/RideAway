import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WaitingTravelersComponent } from './waiting-travelers.component';

describe('WaitingTravelersComponent', () => {
  let component: WaitingTravelersComponent;
  let fixture: ComponentFixture<WaitingTravelersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WaitingTravelersComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WaitingTravelersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
