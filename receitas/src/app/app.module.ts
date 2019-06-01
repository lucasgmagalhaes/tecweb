import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './header/header.component';
import { CadastroReceitaComponent } from './cadastro-receita/cadastro-receita.component';
import { ProdutoCardComponent } from './produto-card/produto-card.component';

import { HttpClientModule } from '@angular/common/http';
import { ReceitaDetalheComponent } from './receita-detalhe/receita-detalhe.component';
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    CadastroReceitaComponent,
    ProdutoCardComponent,
    ReceitaDetalheComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
