import { Component, OnInit } from '@angular/core';
import { ReceitaService } from '../service/receita.service';

@Component({
  selector: 'app-cadastro-receita',
  templateUrl: './cadastro-receita.component.html',
  styleUrls: ['./cadastro-receita.component.scss']
})
export class CadastroReceitaComponent implements OnInit {

  constructor(private receitaService: ReceitaService) { }

  ngOnInit() {
  }

  cadastrar() {
    this.receitaService.inserir(
      {
        descricao: <string>(<HTMLInputElement>document.getElementById('txtdescricao')).value,
        imgUrl: <string>(<HTMLInputElement>document.getElementById('txtimgurl')).value,
        nome: <string>(<HTMLInputElement>document.getElementById('txtnome')).value,
        votos: 0
      });
  }
}
