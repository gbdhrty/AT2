namespace AT2
{
    public delegate string ImprimirMensagem(string mensagem);
    
    internal class Program
    {
        static void Main(string[] args)
        {
            ImprimirMensagem imprimirMaiusculo = delegate (string mensagem)
            {
                return mensagem.ToUpper();
            };

            ImprimirMensagem imprimirMinusculo = delegate (string mensagem)
            {
                return mensagem.ToLower();
            };

            Console.WriteLine("Digite uma frase:");
            string mensagem = Console.ReadLine();

            Console.WriteLine(imprimirMaiusculo(mensagem));
            Console.WriteLine(imprimirMinusculo(mensagem));
        }
    }
}
