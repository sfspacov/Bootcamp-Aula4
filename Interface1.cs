using System;

namespace ConsoleApp2
{
    public interface IVeiculo
    {
        int Rodas { get; set; }
        int Eixos { get; set; }
        bool CintoDeSeguranca { get; set; }
        string Andar();
        void Ligar();
    }

    public class Moto : IVeiculo
    {
        public int Rodas
        {
            get { return 2; }
            set { }
        }
        public int Eixos
        {
            get { return 2; }
            set { }
        }
        public bool CintoDeSeguranca
        {
            get { return false; }
            set { }
        }
        public string Andar()
        {
            return "Anda só pra frente";
        }

        public void Ligar()
        {
            Console.Write("Liga batendo o pé");
        }
    }

    public class Carro : IVeiculo
    {
        public int Rodas
        {
            get
            {
                return 4;
            }
            set
            {

            }
        }

        public int Eixos
        {
            get { return 2; }
            set { }
        }

        public bool CintoDeSeguranca
        {
            get { return true; }
            set { }
        }

        public string Andar()
        {
            return "Anda pra frente e pra trás";
        }

        public void Ligar()
        {
            Console.Write("Liga girando a chave");
        }
    }
}
