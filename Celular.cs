using System;
namespace Celular_POO
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado = false;
        public string contato;

        public bool Ligar()
        {
            return ligado = true;
        }
        public bool Desligar()
        {
            return ligado = false;
        }
        public string FazerLigacao()
        {
            if (ligado == true)
            {
                return $"Ligando para {contato}";
            }
            else
            {
                return "Ligue o celular primeiro";
            }            
        }
        public string EnviarMensagem()
        {
            if (ligado == true)
            {
                return $"A mensagem enviada para {contato} foi";
            }
            else
            {
                return "Ligue o celular primeiro";
            }
        }
    }
}