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

bool choveu = false;
bool estaTarde = false;

if(!choveu && !estaTarde) {
  Console.WriteLine("Vou pedalar");
} else {
   Console.WriteLine("Vou pedalar outro dia!");
}

