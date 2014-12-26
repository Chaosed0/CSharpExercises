using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gwarg
{
    class Program
    {
        const int slimeStartHealth = 50;
        const int slimeStartDamage = 5;
        const int slimeHeal = 5;
        const int slimeDamageUp = 2;
        const int heroStartHealth = 100;
        const int heroHealLower = 5;
        const int heroHealUpper = 15;
        const int heroAttackLower = 5;
        const int heroAttackUpper = 15;
        const int heroDefenseTurns = 2;
        const int heroDefenseBonus = 5;

        static void Main(string[] args)
        {
            int heroHealth = heroStartHealth;
            int heroKills = 0;
            Random gen = new Random();

            Console.Out.WriteLine("Welcome to endless slimes! Press enter to play.");
            Console.In.ReadLine();

            while(heroHealth > 0) {
                int slimeHealth = slimeStartHealth;
                int slimeDamage = slimeStartDamage;
                int defendTurns = 0;

                while(heroHealth > 0 && slimeHealth > 0) {
                    //Hero's turn
                    bool validChoice = false;
                    int choice = 0;

                    if(defendTurns > 0) {
                        defendTurns--;
                    }

                    Console.Out.WriteLine("Slime has " + slimeHealth + " health.");
                    Console.Out.WriteLine("You have " + heroHealth + " health.");
                    Console.Out.WriteLine("What will you do?");
                    Console.Out.WriteLine("(1) Attack" );
                    Console.Out.WriteLine("(2) Heal");
                    Console.Out.WriteLine("(3) Defend");
                    while(!validChoice) {
                        Console.Out.Write("Choice: ");
                        String strchoice = Console.In.ReadLine();
                        if(!int.TryParse(strchoice, out choice)) {
                            Console.Out.WriteLine("You must enter a number!");
                        } else if(choice <= 0 || choice > 3) {
                            Console.Out.WriteLine("The number you entered was not a valid choice!");
                        } else {
                            validChoice = true;
                        }
                    }

                    if(choice == 1) {
                        int randomDamage = gen.Next(heroAttackLower, heroAttackUpper);
                        slimeHealth -= randomDamage;
                        Console.Out.WriteLine("You did " + randomDamage + " damage!");
                    } else if(choice == 2) {
                        int randomHeal = gen.Next(heroHealLower, heroAttackUpper);
                        heroHealth += randomHeal;
                        Console.Out.WriteLine("You healed " + randomHeal + " HP!");
                    } else if(choice == 3) {
                        defendTurns = heroDefenseTurns;
                        Console.Out.WriteLine("You harden your defenses for the next two turns!");
                    }

                    //Slime's turn
                    if(slimeHealth >= 0) {
                        int randomChoice = gen.Next(0, 2);
                        if(randomChoice == 0) {
                            int damage = slimeDamage;
                            if(defendTurns > 0) {
                                damage -= heroDefenseBonus;
                            }
                            heroHealth -= damage;
                            Console.Out.WriteLine("The slime attacks for " + damage + " damage!");
                        } else if(randomChoice == 1) {
                            slimeDamage += slimeDamageUp;
                            slimeHealth += slimeHeal;
                            Console.Out.WriteLine("The slime grows in power! It gained " + slimeHeal + " health and " + slimeDamageUp + " damage!");
                        }
                    } else {
                        Console.Out.WriteLine();
                        Console.Out.WriteLine("The slime died! Another one writhes up to you!");
                        heroKills++;
                    }
                    Console.Out.WriteLine();
                    Console.Out.WriteLine();
                }
            }

            Console.Out.WriteLine("You died! You had " + heroKills + " kills.");
            Console.In.Read();
        }
    }
}
