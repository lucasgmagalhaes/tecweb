import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CadastroReceitaComponent } from './cadastro-receita/cadastro-receita.component';
import { ReceitaDetalheComponent } from './receita-detalhe/receita-detalhe.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'cadastro', component: CadastroReceitaComponent },
  { path: 'receita-detalhe/:id', component: ReceitaDetalheComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
