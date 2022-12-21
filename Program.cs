public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de cidades:");
        int.TryParse(Console.ReadLine(), out int numCidades);

        var arrayCidades = new int[numCidades, numCidades];

        for (int i = 0; i < numCidades; i++)
        {
            for (int j = i + 1; j < numCidades; j++)
            {
                Console.WriteLine($"Digite a distância entre {i} e {j}");
                int.TryParse(Console.ReadLine(), out int distanciaCidades);
                arrayCidades[i,j] = distanciaCidades;
            }
        }

        Console.WriteLine("Quantas cidades no percurso: ");
        int.TryParse(Console.ReadLine(), out int numCidadesPercurso);
        int[] cidadesPercurso = new int[numCidadesPercurso];

        for (int i = 0; i < numCidadesPercurso; i++)
        {
            Console.WriteLine($"Digite a {i + 1}ª cidade: ");
            int.TryParse(Console.ReadLine(), out cidadesPercurso[i]);
        }

        for (int i = 0; i + 1 < cidadesPercurso.Length; i++)
        {
            int origem = cidadesPercurso[i];
            int destino = cidadesPercurso[i + 1];
            int trajetoTotal =+arrayCidades[origem, destino];

            if (i + 2 == cidadesPercurso.Length)
            {
                Console.WriteLine($"A distância percorrida foi de {trajetoTotal} KM");
            }

        }

    }
}