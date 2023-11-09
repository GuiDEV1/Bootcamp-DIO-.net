 using exemplos_fundamentos.Models;

// string apresentacao = "Olá, seja bem vindo!!";

// int quantidade = 1;
// quantidade = 34;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool mundialDoPalmeiras = false;

// Console.WriteLine("O valor da variavel apresentação: " + apresentacao);
// Console.WriteLine("O valor da variavel quantidade: " + quantidade);
// Console.WriteLine("O valor da variavel altura: " + altura.ToString("0.00"));
// Console.WriteLine("O valor da variavel Preco: " + preco);
// Console.WriteLine("O valor da variavel mundialDoPalmeiras: " + mundialDoPalmeiras);

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// int a = 10 , b = 20;
// int c = a + b;
// c *= 5;

// Console.WriteLine($"O total da váriavel c é: {c}");

// // Cast - Casting
// int a = Convert.ToInt32(null);
// //int a = int.Parse(null); 

// Console.WriteLine(a); 

// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);

// int a = 5;
// double b = a;

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;
// Console.WriteLine(b);

// double a = 4 / (2 + 2);

// Console.WriteLine(a);

// string a = "15A";
// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Guilherme";
// pessoa1.Idade = 22;
// pessoa1.Apresentar();

// int quantidadeEstoque = 10, quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
// Console.WriteLine($"Quantidade em compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda ? {possivelVenda}");

// if (quantidadeCompra == 0) {
//     Console.WriteLine("Venda invalida");
// }
// else if (possivelVenda) {
//    Console.WriteLine("Venda realizada.");
// }
// else {
//     Console.WriteLine("Desculpe a quantidade que deseja comprar não estar disponivel");
// }


// Console.WriteLine("Digite uma letra");
// string  letra = Console.ReadLine();

// switch (letra) {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//       Console.WriteLine("Vogal");
//       break;
//     default:
//       Console.WriteLine("Não é uma Vogal");
//       break;
// }

// bool eMaiorDeIdade = true;
// bool possuiAutorizacaoDoResposavel = false;

// if(eMaiorDeIdade || possuiAutorizacaoDoResposavel) {
//  Console.WriteLine("Entrada liberada!");
// } else {
//   Console.WriteLine("Entrada não liberada");
// }

// bool possuiPresencaMinima = false;
// double media = 7.5;

// if(possuiPresencaMinima && media >= 7) {
//   Console.WriteLine("Aprovado");
// } else {
//   Console.WriteLine("Reprovado");
// }

// bool choveu = false;
// bool estaTarde = false;

// if(!choveu && !estaTarde) {
//   Console.WriteLine("Vou pedalar");
// } else {
//    Console.WriteLine("Vou pedalar outro dia!");
// }

// Calculadora calc = new Calculadora();

// calc.Somar(20,5);
// calc.Subtrair(300,100);
// calc.Multplicar(10,100);
// calc.Dividir(20,4);
// calc.Potencia(3,3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// int numero = 10;

// Console.WriteLine(numero);
// Console.WriteLine("Incrementando o 10");
// numero--;
// Console.WriteLine(numero);
// calc.RaizQuadrada(9);

// int numero = 5;

// for(int i = 1; i <= 1000; i++) {
//   Console.WriteLine($"{numero} x {i} = {numero * i}");
// }

// int numero = 5;
// int i = 0;
// while(i <= 10) 
// {
//    Console.WriteLine($"{numero} x {i} = {numero * i}");
//    i++;

//    if(i == 6) 
//    {
//      break;
//    }
// }

// int soma = 0, numero = 0;

// do {
//     Console.WriteLine("Digite um numero: (0) para parar");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números são: {soma}");

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
  Console.Clear();
  Console.WriteLine("Digite a sua opção:");
  Console.WriteLine("1 - Cadastrar cliente");
  Console.WriteLine("2 - Buscar Clientes");
  Console.WriteLine("3 - Apagar Clientes");
  Console.WriteLine("4 - Encerrar:");

  opcao = Console.ReadLine();

  switch(opcao)
  {
     case "1":
      Console.WriteLine("Cadastro de Cliente");
      break;

      case "2":
        Console.WriteLine("Busca de cliente");
        break;

      case "3":
        Console.WriteLine("Apagar Cliente");
        break;

      case "4":
        Console.WriteLine("Encerrar");
        exibirMenu = false;
        break;    

      default:
        Console.WriteLine("Opção invalida");
        break;  
  }
}

Console.WriteLine("O programa se encerrou!");