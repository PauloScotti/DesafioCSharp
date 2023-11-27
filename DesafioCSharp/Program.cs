//Console.WriteLine("Digite sua idade:");
//int idade = Convert.ToInt32(Console.ReadLine());

//if (idade >= 60 )
//{
//    Console.WriteLine("Você tem o direito a tirar o cartão idoso da prefeitura");
//}
//else
//{
//    Console.WriteLine("Você ainda não tem o direito a tirar o cartão idoso da prefeitura");
//    int anosfaltantes = 60 - idade;
//    int diasfaltantes = anosfaltantes * 365;
//    Console.WriteLine("Faltam ainda " + anosfaltantes + " anos para tirar seu cartão");
//    Console.WriteLine("Faltam ainda " + diasfaltantes + " dias aproximadamente para tirar seu cartão");
//    idade++;
//    int umanomaisvelho = idade;
//    diasfaltantes = (60 -  umanomaisvelho) * 365;
//    Console.WriteLine("Faltaria " + diasfaltantes + " dias aproximadamente para tirar seu cartão se você tivesse " + umanomaisvelho);
//}

/*
string nomecompleto;
string textoolamundo = "Olá mundo, meu primeiro programa CSharp! Feito por ";
int idade;

Console.WriteLine("Qual o seu nome?");

nomecompleto = Console.ReadLine().ToString();

Console.WriteLine("Qual a sua idade?");

idade = Convert.ToInt32(Console.ReadLine());

switch (nomecompleto)
{
    case "Paulo": Console.WriteLine("Dev"); break;
    case "Danilo": Console.WriteLine("Guitarra"); break;
    default: Console.WriteLine("Não encontrado"); break;
}

bool valido = false;

if(valido)
{
    Console.WriteLine("Passou como verdadeiro");
}
else
{
    Console.WriteLine("Passou como falso");
}

Console.WriteLine(!valido);
Console.WriteLine(valido);

if(idade == 40 || nomecompleto == "Paulo Scotti")
{
    Console.WriteLine(textoolamundo + nomecompleto + " que tem " + idade + " anos.");
} else
{
    Console.WriteLine("Você errou a idade ou o nome");
}

Console.WriteLine(textoolamundo + nomecompleto + " que tem " + idade + " anos.");

*/

//Exercicio

//string nomedojogador;

Console.WriteLine("Bem-vindos ao torneio de Poker Devaria!");

//ExemploForEach();
//ExemploWhile();
//ExemploFor();
ExemploDoWhile();

//Console.WriteLine("Qual o nome do jogador");
//nomedojogador = Console.ReadLine().ToString();

//bool validacaojogador;

//switch (nomedojogador)
//{
//    case "Paulo":
//    case "Danilo":
//    case "Fernando":
//    case "Rafael":
//    case "Daniel":
//    case "Douglas":
//    case "Adriano":
//    case "Kaique":
//        Console.WriteLine("Jogador autorizado para o torneio de poker");
//        validacaojogador = true;
//        break;
//    default:
//        Console.WriteLine("Jogador não autorizado para o torneio de poker");
//        validacaojogador = false;
//        break;
//}

//if (validacaojogador)
//{
//    Console.WriteLine("Quantas vitórias você conquistou");
//    int vitorias = Convert.ToInt32(Console.ReadLine());
//    int pontuacaoatual = VerificarPontuacao(vitorias);
//    Console.WriteLine("Você possui " + pontuacaoatual.ToString() + " pontos no torneio");
//    int pontuacaonova = BonificarParticipacao(pontuacaoatual);
//    Console.WriteLine("Parabéns, você ganhou 1 ponto de bônus. Agora sua pontuação é: " + pontuacaonova.ToString());
//}


//// Método de verificação da pontuação do jogador
//int VerificarPontuacao (int vitorias)
//{
//    const int fatorvitoria = 3;

//    int pontuacao = fatorvitoria * vitorias;

//    return pontuacao;
//}

//// Método de bonificação de participação
//int BonificarParticipacao(int pontuacaoatual)
//{
//    int pontuacaonova = pontuacaoatual;
//    pontuacaonova++;

//    return pontuacaonova;
//}

//void ExemploForEach()
//{
//    string[] jogadores = { "Paulo", "Danilo", "Fernando", "Daniel" };

//    foreach(string jogador in jogadores)
//    {
//        Console.WriteLine("Bem-vindo(a) as quartas de final " + jogador);
//    }
//}

//void ExemploWhile()
//{
//    Console.WriteLine("Qual a sua pontuação atual?");
//    int pontuacaojogador = Convert.ToInt32(Console.ReadLine());

//    if(pontuacaojogador < 27) {

//    while(pontuacaojogador < 27)
//    {
//        Console.WriteLine("Jogando");
//        Console.WriteLine("Você ganhou? (S/N)");
//        string ganhou = Console.ReadLine();
//        if(ganhou == "S")
//        {
//            pontuacaojogador = pontuacaojogador + 3;
//        } else
//        {
//            Console.WriteLine("Infelizmente você está fora do torneio");
//            break;
//        }
//    }
//        Console.WriteLine("Você já está nas quartas de final. Parabéns!");
//    } else
//    {
//        Console.WriteLine("Você já está nas quartas de final. Parabéns!");
//    }
//}

void ExemploDoWhile()
{
    Console.WriteLine("Qual a sua pontuação atual?");
    int pontuacaojogador = Convert.ToInt32(Console.ReadLine());

    if (pontuacaojogador < 27)
    {

        do
        {
            Console.WriteLine("Jogando");
            Console.WriteLine("Você ganhou? (S/N)");
            string ganhou = Console.ReadLine();
            if (ganhou == "S")
            {
                pontuacaojogador = pontuacaojogador + 3;
            }
            else
            {
                Console.WriteLine("Infelizmente você está fora do torneio");
                break;
            }
        } while (pontuacaojogador < 27);
        Console.WriteLine("Você já está nas quartas de final. Parabéns!");
    }
    else
    {
        Console.WriteLine("Você já está nas quartas de final. Parabéns!");
    }
}

void ExemploFor()
{
    string[] jogadores = { "Paulo", "Danilo", "Fernando", "Daniel" };

    for (int contajogador = 0; contajogador < 4; contajogador++)
    {
        Console.WriteLine("Bem-vindo(a) as quartas de final " + jogadores[contajogador]);
    }
}