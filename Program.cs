// See https://aka.ms/new-console-template for more information


Console.WriteLine("Digite a matricula do Funcionario");
var id = int.Parse(Console.ReadLine());
Funcionario funcionario =  new Funcionario();
funcionario.CadastraFuncionario(id);
