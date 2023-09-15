using System;
using System.Collections.Generic;

class Program
{
    // Lista para armazenar os Blocos
    static List<Bloco> blocos = new List<Bloco>();

    static void Main()
    {
        int escolha;
        do
        {
            // Exibindo o menu para o usuário
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Cadastrar Bloco");
            Console.WriteLine("2 - Listar Blocos");
            Console.WriteLine("3 - Buscar Bloco por Código");
            Console.WriteLine("4 - Listar Blocos por Pedreira");
            Console.WriteLine("5 - SAIR");
            escolha = int.Parse(Console.ReadLine()!);

            switch (escolha)
            {
                case 1:
                    CadastrarBloco(); // Cadastrar um novo bloco
                    break;
                case 2:
                    ListarBlocos(); // Listar todos os blocos cadastrados
                    break;
                case 3:
                    BuscarBlocoPorCodigo(); // Buscar um bloco por código
                    break;
                case 4:
                    ListarBlocosPorPedreira(); // Listar blocos de uma pedreira
                    break;
                case 5:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (escolha != 5); // Continuar até que o usuário escolha sair
    }

    static void CadastrarBloco()
    {
        Bloco bloco = new Bloco();

        // Solicitando informações sobre o Bloco
        Console.WriteLine("Digite o Código do Bloco:");
        bloco.Codigo = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o Número do Bloco:");
        bloco.NumeroBloco = Console.ReadLine()!;

        Console.WriteLine("Digite as Medidas do Bloco (em metros cúbicos):");
        bloco.Medidas = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite a Descrição do Bloco:");
        bloco.Descricao = Console.ReadLine()!;

        Console.WriteLine("Digite o Tipo de Material (mármore ou granito):");
        bloco.TipoMaterial = Console.ReadLine()!;

        Console.WriteLine("Digite o Valor da Compra:");
        bloco.ValorCompra = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite o Valor da Venda:");
        bloco.ValorVenda = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Digite a Pedreira de Origem do Bloco:");
        bloco.Pedreira = Console.ReadLine()!;

        Console.Clear();

        // Adicionar o bloco à lista
        blocos.Add(bloco);
        Console.WriteLine("Bloco cadastrado com sucesso!");
    }

    static void ListarBlocos()
    {
        Console.Clear();

        // Listar todos os blocos cadastrados
        Console.WriteLine("Lista de Blocos cadastrados:");
        foreach (var bloco in blocos)
        {
            Console.WriteLine($"Código: {bloco.Codigo}, Número do Bloco: {bloco.NumeroBloco}, Medidas: {bloco.Medidas}m³\n");
        }
    }

    static void BuscarBlocoPorCodigo()
    {
        // Buscar um bloco por código
        Console.WriteLine("Digite o Código do Bloco que deseja buscar:");
        int codigo = int.Parse(Console.ReadLine()!);

        Bloco blocoEncontrado = blocos.Find(bloco => bloco.Codigo == codigo)!;

        if (blocoEncontrado != null)
        {
            Console.WriteLine($"Código: {blocoEncontrado.Codigo}, Número do Bloco: {blocoEncontrado.NumeroBloco}, Medidas: {blocoEncontrado.Medidas}m³");
        }
        else
        {
            Console.WriteLine("Bloco não encontrado.");
        }
    }

    static void ListarBlocosPorPedreira()
    {
        // Buscar blocos de uma pedreira específica
        Console.WriteLine("Digite o nome da Pedreira que deseja buscar:");
        string pedreira = Console.ReadLine()!;

        List<Bloco> blocosPedreira = blocos.FindAll(bloco => bloco.Pedreira.Equals(pedreira, StringComparison.OrdinalIgnoreCase));

        if (blocosPedreira.Count > 0)
        {
            Console.WriteLine($"Blocos da Pedreira '{pedreira}':");
            foreach (var bloco in blocosPedreira)
            {
                Console.WriteLine($"Código: {bloco.Codigo}, Número do Bloco: {bloco.NumeroBloco}, Medidas: {bloco.Medidas}m³");
            }
        }
        else
        {
            Console.WriteLine($"Nenhum bloco encontrado na Pedreira '{pedreira}'.");
        }
    }
}
