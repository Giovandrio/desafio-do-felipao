namespace nivelDoHeroi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Con Switch
            /*  Console.WriteLine("Olá. Qual é o nome do seu Herói?");

              string nomeHeroi = Console.ReadLine();

              Console.WriteLine($"Cual es el XP de {nomeHeroi}");

              double xp =(double.Parse(Console.ReadLine()));

              switch (xp)
              {
                  case var _ when xp < 1000:
                      Console.WriteLine($"O Herói {nomeHeroi} está no nível Ferro");
                      break;

                  case var _ when xp < 2000:
                      Console.WriteLine($"O Herói {nomeHeroi} está no nível Bronze");
                      break;

                  case var _ when xp < 5000:
                      Console.WriteLine($"O Herói {nomeHeroi} está no nível Prata");
                      break;

                  case var _ when xp < 7000:
                      Console.WriteLine($"O Herói {nomeHeroi} está no nível Ouro");
                      break;

                  case var _ when xp < 8000:
                      Console.WriteLine($"O Herói {nomeHeroi} está no nível Platina");
                      break;

                  case var _ when xp < 9000:
                      Console.WriteLine($"O Herói {nomeHeroi} está no nível Ascendente");
                      break;

                  case var _ when xp < 10000:
                      Console.WriteLine($"O Herói {nomeHeroi} está no nível Imortal");
                      break;

                  case var _ when xp >= 10001:
                      Console.WriteLine($"O Herói {nomeHeroi} está no nível Radiante");
                      break;*/

            //  UTILIXANDO METODO
            Console.WriteLine("Olá. Qual é o nome do seu Herói?");
            string nomeHeroi = Console.ReadLine();

            Console.WriteLine($"Cual é o XP de {nomeHeroi}");
            double xp = double.Parse(Console.ReadLine());

            string nivel = ObterNivel(xp);
            Console.WriteLine($"O Herói {nomeHeroi} está no nível {nivel}");
        }

        private static string ObterNivel(double xp)
        {
            if (xp < 1000)
                return "Ferro";
            else if (xp < 2000)
                return "Bronze";
            else if (xp < 5000)
                return "Prata";
            else if (xp < 7000)
                return "Ouro";
            else if (xp < 8000)
                return "Platina";
            else if (xp < 9000)
                return "Ascendente";
            else if (xp < 10000)
                return "Imortal";
            else
                return "Radiante";
        }

    }
            
}