using System;

namespace Exercicio_Validacao_de_senha
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Validação de senha");
         Console.WriteLine("------------------");

         Console.Write("Digite o seu nome: ");
         string nome = Console.ReadLine();

         Console.Write("Digite a senha: ");
         string senha = Console.ReadLine();


         while(nome == senha){
            Console.WriteLine("Senha inválida - Digite uma senha diferente do seu nome.");
            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();
        }
        Console.WriteLine("Usuário cadastrado com sucesso!");
        }
    }
}
