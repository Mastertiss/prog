using System;

namespace projet1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable 
            Random aleatoire = new Random();
            int choix = 0;


            Console.WriteLine("Iron fist esseye de trouver un moyen de retourner a Kun-Lun, apres un certain temps de recherche,il trouve une forêt ou il y aurait possiblement un chemin pour y retourner mais bien sur,\n La Main était la avant lui ainsi que plusieurs pièges.Vous devrez  faire des choix important et réfléchis pour trouver le passage avant eu");
            Console.WriteLine("");
            Console.WriteLine("Arrivant a la foret, Iron fist voit deux chemin possible, le chemin de gauche est un chemin noir et obscure et lui de droite a lair plus sur et est plus éclairé ");
            Console.WriteLine("");
            Console.WriteLine("1- aller a gauche ou 2- aller a droite");

            //saisir 

            choix = Convert.ToInt32(Console.ReadLine());
            if (choix == 1)//gauche
            {

                Console.WriteLine("En empruntant le chemin de gauche,Iron fist avance tranquillement dans la foret sans rencontrer de problem");
                Console.WriteLine("");
                Console.WriteLine("Rendu a une petite cabane perdu dans les bois, Iron Fist tombe face a face avec mamy Chio,elle veut l'empecher de continuer.Il faut l'éliminer.");
                Console.WriteLine("");
                Console.WriteLine("lancé le dée et obtener 3 ou plus pour la mettre hors d`état de nuire");

                int chance = aleatoire.Next(1, 7);

                if (chance > 3)//
                {
                    Console.WriteLine("Vous avez vaincu mamy Chio et elle bat en retraite");

                }
                else
                {
                    Console.WriteLine("Vous l'avez vaincu mais vous etes affaiblie");

                }

                Console.WriteLine("apres avoir vaincu mamy Chio,vous appercevez une grotte au loin,vous pensez a y aller ou retourner paisiblement a new york");
                Console.WriteLine("");
                Console.WriteLine(" ");
                Console.WriteLine("");
                Console.WriteLine("1-aller a la grotte    2-retourner a new york ");


                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Vous entrez dans la grotte et vous apercevez le dragon magique de Kun Lun, Shou-Lao et 3 autre dragon protege l'entrée pour Kun Lun car vous n'étiez plus la, vous devez vous enfuir ou tenter de vous rendre au passage ");
                    Console.WriteLine("1- tenter de se rendre au passage  2-s`enfuir");
                }
                choix = Convert.ToInt32(Console.ReadLine());

                if (choix == 1)
                {
                    Console.WriteLine("si vous avez été blessé contre mamy Chio vous etes clairement mort.");
                    Console.WriteLine("Si votre combat contre mamy Chio c`est bien dérouler alors vous avez réussi a passer au travers des dragons et vous etes maintenant revenu a Kun Lun pour faire le devoir du Iron Fist ");
                }


                else
                {
                    Console.WriteLine("En sortant de la foret , mamy Chio vous attend encore avec quelque un de ses meilleures disciples. ");
                    Console.WriteLine("");
                    Console.WriteLine("1-en finir une fois pour toute et les éliminer  2-s`enfuir et retourner a New York");

                }
                choix = Convert.ToInt32(Console.ReadLine());
                if (choix == 1)
                {
                    Console.WriteLine("c`était un combat sanglan et intense mais le Iron Fist réussi toujours a vaincre ces ennemis,pret a retourner a new york et attendre que le prochain danger arrive");


                }
                else
                {

                    Console.WriteLine("Vous vous etes enfui comme une filette,votre honneur est drétuite et le Iron Fist tombe en dépression. Cela va prendre du temps avant de pouvoir défendre la vile a nouveaux");

                }


            }
            else //droite 
            {
                Console.WriteLine("Arrivant dans le chemin de droite, un ninja de la Main sort de l'ombre pour affronter le héros, un combat s'impose");
                Console.WriteLine("");
                Console.WriteLine("Vous devez lancé le dée et avoir plus que 2 pour vaincre le ninja");

                int chance = aleatoire.Next(1, 7);

                if (chance > 2)//
                {
                    Console.WriteLine("Vous avez éclater le ninja");

                }
                else
                {
                    Console.WriteLine("le ninja est mort mais il vous a gravement blesser");
                }

                Console.WriteLine("vous appercevez une grotte et vous allez voir, une armée de ninja Kung fu vous attende pour venger leur frere tomber,l'heure du combat final est arrivé ");
                Console.WriteLine("");
                Console.WriteLine("1-les combattre sans le Iron fist  2-combattre avec le iron fist");

                choix = Convert.ToInt32(Console.ReadLine());
                if (choix == 1)//New York
                {

                    Console.WriteLine("Vous les avez tous neutralisé mais le passage vers Kun-Lun c'est refermé alors, vous devez rester a New York et protéger les habitants a tout jamais. ");

                }

                else
                {
                    Console.WriteLine("Vous les avez écrasé rapidement et vous avez réussi a vous rendre a Kun Lun pour faire votre vrai devoir et protéger cette cité ancestral");

                }










            }





            //");


            /*   Console.WriteLine("mamy Chio s'enfui elle n'est pas assez forte pour vous arretez");
               Console.WriteLine("");
               Console.WriteLine("vous appercevez une grotte au loin, c'est le seul lieu qui reste a explorer, vous vous y rendez.");
               Console.WriteLine("");
               Console.WriteLine("Le dragon ancestrale de Kun Lun defend la porte pour y arriver et il est beaucoup plus puissant que avant,vous avez deux choix");
               Console.WriteLine("");
               Console.WriteLine("1-passer sous le dragon et peut etre atteindre Kun-Lun  2-combattre le dragon  ");*/


            Console.ReadKey();
        }
    }
}
