using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //get
            var arrayDeInts = new[] { 1, 2, 3, 4 };
            
            //get; set;
            var listaDeInts = new List<int>() { 1, 2, 19, 4 };
            listaDeInts.Add(5);
            listaDeInts.Remove(3);
            listaDeInts.RemoveAt(2);
            listaDeInts.RemoveAll(x => x > 2);

            Queue<int> FilaDeInts;


            Stack<int> PilhaDeInts;


            //var resultado =  AnonymousType();
            //GenericTypeExemplo1();
            //GenericTypeExemplo2();
            //ImplicitTypeConvertion();

            //São value types
            NullableTypes();
        }

        static void RecebeAnonimo(dynamic tipoAnonimo)
        {
            if (tipoAnonimo.Idade == 18)
            {

            }
        }

        static dynamic AnonymousType()
        {
            var tipoAnonimo = new
            {
                Nome = "João",
                Mensagem = "Oi, bom dia",
                Idade = 32,
                Filhos = new List<string>() { "Maria", "Roberto" }
            };

            return tipoAnonimo;
        }

        static void GenericTypeExemplo1()
        {
            var inteiros = new List<int>();
            var palavras = new List<string>();

            inteiros.Add(1);
            inteiros.Add(2);
            inteiros.Add(3);
            inteiros.Add(4);
            inteiros.Add(5);

            palavras.Add("Oi");
            palavras.Add("Bom dia");
            palavras.Add("Tudo bem?");
        }

        static void GenericTypeExemplo2()
        {
            var bancoDeDados1 = new BancoDeDados<string>();
            var mensagem = "Essa string vai pro banco de dados";
            bancoDeDados1.Salvar(mensagem);

            var bancoDeDados2 = new BancoDeDados<Usuario>();
            var usuario1 = new Usuario();
            usuario1.Idade = 32;
            usuario1.Nome = "João";
            bancoDeDados2.Salvar(usuario1);
        }

        static void ImplicitTypeConvertion()
        {
            var x = "a";
            var y = 'a';
        }

        static void NullableTypes()
        {
            int nonNullable = 0;
            int? nullable = null;
        }
    }
}
