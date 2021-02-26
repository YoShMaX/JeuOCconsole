using System;

namespace NombreMystereconseole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Génération d'un nombre aléatoire entre 1 et 20
            int randomed = new Random().Next(20) + 1;

            NouvellePartie(randomed);
                        
            // On sort de la boucle
            YouWin(randomed);
            Console.ReadKey();
        }

        static void YouWin(int randomed)
        {
         Console.WriteLine("Bravo, vous avez trouvé le bon nombre : " + randomed);
        }

        static void NouvellePartie(int randomed)
        {
            // Demander à l'utilisateur de saissir un nombre et le stocker dans une variable
            Console.WriteLine("Saississez un nombre entre 1 et 20 :");

            
            int pickedNum = PickaNumber();



            while (pickedNum != randomed)
            {
                if (pickedNum < randomed)
                {
                    Console.WriteLine("C'est plus");

                }
                else
                {
                    Console.WriteLine("C'est moins");

                }
                pickedNum = PickaNumber();
            }
        }
        static int PickaNumber()
        {
            string picked = Console.ReadLine();

            // Vérifier la validité de la saisie avec TryParse (tryparse est un test boléen)
            int pickedNum;

            while (int.TryParse(picked, out pickedNum) == false)
            {
                Console.WriteLine("Oups ! Je n'ai pas compris, veuillez saisir un nombre entre 1 et 20 :");
                picked = Console.ReadLine();
            }

            return pickedNum;
            

        }
    }
}

