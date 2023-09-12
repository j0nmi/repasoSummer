import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarfiltroComponent } from './listarfiltro.component';

describe('ListarfiltroComponent', () => {
  let component: ListarfiltroComponent;
  let fixture: ComponentFixture<ListarfiltroComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ListarfiltroComponent]
    });
    fixture = TestBed.createComponent(ListarfiltroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
