import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

export interface Receita {
  id?: number;
  nome: string;
  descricao: string;
  votos: number;
  imgUrl: string;
}

const PATH = 'http://localhost:54203/api/receita';

@Injectable({
  providedIn: 'root'
})
export class ReceitaService {

  constructor(private http: HttpClient) { }

  inserir(receita: Receita): Promise<void> {
    return this.http.post<void>(PATH, receita).toPromise();
  }

  buscar(): Promise<Receita[]> {
    return this.http.get<Receita[]>(PATH).toPromise();
  }

  buscarPorId(id: number): Promise<Receita> {
    return this.http.get<Receita>(`${PATH}/${id}`).toPromise();
  }

  atualizar(receita: Receita): Promise<void> {
    return this.http.put<void>(PATH, receita).toPromise();
  }

}
