import { Component, OnInit, Input } from '@angular/core';
import { Receita, ReceitaService } from '../service/receita.service';

@Component({
  selector: 'app-produto-card',
  templateUrl: './produto-card.component.html',
  styleUrls: ['./produto-card.component.scss']
})
export class ProdutoCardComponent implements OnInit {

  @Input()
  receita: Receita;

  constructor(private receitaService: ReceitaService) { }


  addVoto() {
    this.receita.votos++;
    this.receitaService.atualizar(this.receita).catch(() => this.receita.votos--);
  }

  ngOnInit() {
  }

}
