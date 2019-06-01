import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ReceitaService, Receita } from '../service/receita.service';

@Component({
  selector: 'app-receita-detalhe',
  templateUrl: './receita-detalhe.component.html',
  styleUrls: ['./receita-detalhe.component.scss']
})
export class ReceitaDetalheComponent implements OnInit {

  receita: Receita;

  constructor(private activeRoute: ActivatedRoute, private receitaService: ReceitaService) {
    const id = this.activeRoute.snapshot.paramMap.get('id');
    this.receitaService.buscarPorId(Number.parseInt(id)).then(receita => this.receita = receita);
  }

  ngOnInit() {
  }

}
