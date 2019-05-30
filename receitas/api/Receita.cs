using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api
{
  public class Receita
  {
    public long Id { get; set; }
    public string Descricao { get; set; }
    public int Votos { get; set; }
    public string ImgUrl { get; set; }
  }
}
