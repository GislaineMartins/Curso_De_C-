﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula56 {
    class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double Preco {
            get {
                return _preco;
            }
        }

        public int Quantidade {
            get {
                return _quantidade;
            }
                
        }

       

        public double GetPreco() {
            return _preco;
        }

        public int GetQuantidade() {
            return _quantidade;

        }
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void adicionarProdutos(int qt) {
            _quantidade = _quantidade + qt;

        }

        public void removerProdutos(int qt) {
            _quantidade = _quantidade - qt;

        }

        public override string ToString() {
            return _nome
                + ", R$ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
