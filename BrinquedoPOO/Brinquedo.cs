﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrinquedoPOO
{
    //-Produto
    //-Categoria
    //-Idade Mínima
    //-Retorna concatenação do Código de Barras, Descrição e Categoria
    //-Retorna concatenação do Código de Barras, Descrição, Categoria e Nome Fabricante
    public class Brinquedo
    {
        public Produto Produto { get; set; }
        public string Categoria { get; set; }
        public int IdadeMin { get; set; }
        public string CodBarrasDescCat
        {
            get
            {
                return Produto.CodBarrasDesc + " - " +
                    Categoria;
            }
        }

        public string CodBarrasDescCatFab
        {
            get
            {
                return CodBarrasDescCat + " - " +
                    Produto.Fabricante.Nome;
            }
        }
    }
}
