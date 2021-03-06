﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula42 {
    class Produto {
        public string nome;
        public double preco;
        public int quantidade;


        public double ValorTotalEmEstoque() {
            return preco * quantidade;
        }

        public void adicionarProdutos(int qt) {
            quantidade = quantidade + qt;
          
        }

        public void removerProdutos(int qt) {
            quantidade = quantidade - qt;

        }

        public override string ToString() {
            return nome
                + ", R$ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);


        }


    }
}
