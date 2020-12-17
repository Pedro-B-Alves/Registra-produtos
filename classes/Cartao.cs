using System;

namespace Registra_produtos.classes
{
    public class Cartao
    {
        public string Titular { get; set; }
        public long Numero { get; set; }
        public string Bandeira { get; set; }
        public DateTime Vencimento { get; set; }
        public int Cvv { get; set; }
        
        public Cartao(){

        }

        public Cartao(string _titular, long _numero, string _bandeira, DateTime _vencimento, int _cvv){
            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.Vencimento = _vencimento;
            this.Cvv = _cvv;
        }
    }
}