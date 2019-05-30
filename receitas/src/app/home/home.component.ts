import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  exibir: boolean;
  constructor() { }

  ngOnInit() {
  }

  exibirModal() {
    this.exibir = this.exibir ? false : true;
  }

}
