using System.Runtime.CompilerServices;

namespace Cartao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal saldoCartao = 100;
            string ids = "00025";
            string senhas = "1425";
            string resposta2 = "s";

            Console.WriteLine("informe o valor da compra:");
            decimal compra = decimal.Parse(Console.ReadLine());

            while (resposta2 == "s")
            {
                Console.WriteLine("informe a Id: ");
                string id = Console.ReadLine());
                Console.WriteLine("insira a senha: ");
                string senha = Console.ReadLine();

                if (id == ids && senha == senhas)
                {
                    if (saldoCartao >= compra)
                    {
                        decimal saldoCartao2 = saldoCartao - compra;
                        Console.WriteLine($"O valor da compra:{compra}\nSaldo Anterior:{saldoCartao}\nSaldo Atual:{saldoCartao2}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valor insuficiente!");
                        if (saldoCartao > 0)
                        {
                            Console.WriteLine("Gostaria de abater o com o saldo e efetuar o restante do" +
                                " pagamento de outra maneira? responda [ok]");
                            string resposta = Console.ReadLine();
                            if (resposta == "ok")
                            {
                                decimal falta = compra - saldoCartao;
                                Console.WriteLine($"Valor anterior:{compra}\nFalta:{falta}");
                                Console.WriteLine("valor pago:");
                                decimal pagamento = decimal.Parse(Console.ReadLine());
                                decimal troco = pagamento - falta;
                                Console.WriteLine("Pagamento efetuado!");
                                Console.WriteLine($"Troco:{troco}");
                                break;
                                   
                            }
                            else
                            {
                                Console.WriteLine("escolha outra forma de pagamento");
                                Console.WriteLine("Efetue o pagamento em dinheiro");
                                Console.WriteLine("valor pago:");
                                decimal pagamento = decimal.Parse(Console.ReadLine());
                                decimal troco = pagamento - compra;
                                Console.WriteLine("Pagamento Efetuado!");
                                Console.WriteLine($"Troco:{troco}");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Infelizmente você não tem saldo suficiente para abate no valor");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Usuario ou senha incorretas,deseja tenta novamente? [S]ou[N]");
                    resposta2 = Console.ReadLine();
                        if(resposta2 == "n")
                         {
                            Console.WriteLine("atendimento encerrado");    
                        }
                }
            }
       
        }
    }
}