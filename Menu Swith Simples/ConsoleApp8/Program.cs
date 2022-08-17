using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {

        enum opcao { criar = 1, editar, deletar, atualizar}
        static void Main(string[] args)
        {

            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-criar\n2-editar\n3-deletar\n4-atualizar\n5-limpar");
            int index = int.Parse(Console.ReadLine());
            opcao opcaoSelecionada = (opcao)index;

            Console.WriteLine(opcaoSelecionada);

            
            switch (opcaoSelecionada)
            {

                case opcao.criar:
                    Console.WriteLine("Você deseja criar algo!!");
                    break;
                case opcao.editar:
                    Console.WriteLine("voce deseja editar algo!!");
                    break;
                case opcao.deletar:
                    Console.WriteLine("voce deseja deletar, ATENÇÂO!!");
                    break;
                case opcao.atualizar:
                    Console.WriteLine("voce deseja atualizar algo!");
                    break;
                default:
                    Console.WriteLine("opcaõs nao encontrada!");
                    break;

                    
            }

            Console.ReadLine();


        }

        
    }
 }
        

        
       

        

    

