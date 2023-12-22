
/*Abaixo somente para FOR*/
// int numero = 5;
// // for(int contador = 0; contador <= 10; contador++){
// // Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// // }

/*Abaixo somente para WHILE*/

// int contador = 1;
// int numero = 5;
// while(contador <= 10)
// {
//     Console.WriteLine($"{contador}ª Execuxão: {numero} x {contador} = {numero * contador}");
//     contador++;
//     if(contador == 6)
//     {
//         break;
//     }
    
// }


/*Abaixo somente para DO WHILE*/
// int soma = 0, numero = 0;
// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// }while(numero != 0);

// Console.WriteLine($"Total de soma dos números digitados é: {soma}");
/*Abaixo somente para MENU INTERATIVO*/
string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;
        case "2":
            Console.WriteLine("Buscar de Cliente");
            break;
        case "3":
            Console.WriteLine("Apagar de Cliente");
            break;
        case "4":
            Console.WriteLine("Encerar");
            exibirMenu = false;
            //Environment.Exit(0);
            break;
        default:
            Console.WriteLine("opção inválida");
            break;
        
    }
}
Console.WriteLine("O programa se encerrou");