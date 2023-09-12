import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListartodasComponent } from './listartodas.component';

describe('ListartodasComponent', () => {
  let component: ListartodasComponent;
  let fixture: ComponentFixture<ListartodasComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ListartodasComponent]
    });
    fixture = TestBed.createComponent(ListartodasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
