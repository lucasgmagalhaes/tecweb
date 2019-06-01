import { Component, OnInit } from '@angular/core';
import { ReceitaService, Receita } from '../service/receita.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  receitas: Receita[] = [];

  constructor(private receitaService: ReceitaService) {
    this.receitaService.buscar().then(receitas => this.receitas = receitas);
  }

  ngOnInit() {
  }


}
