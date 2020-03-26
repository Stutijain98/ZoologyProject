//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    class Elephants:ISpecies,IBodyCharacteristics,IDiet,IReproduction,IDomestication
    {
          void African()
        {
            Console.WriteLine("African Elephants");
            Console.WriteLine("African elephants are found in 38 countries of Africa and stand up to 4m and weigh around 7000kg.");       
        }
          void Asian()
        {
             Console.WriteLine("Asian Elephants");
             Console.WriteLine("Asian elephants are 3.4 m tall and weigh 5,400 kgs.");
        }
          void Trunk()
        {
             Console.WriteLine("Body Characteristics of Elephants");
             Console.WriteLine("Trunk: Is used to tear up their food and then place it in their mouth. ");
        }     
          void Tusk()
        {
             Console.WriteLine("Tusk: 1.> Used to dig for water salt, and roots");
             Console.WriteLine("2.>to debark trees, to eat the bark");
             Console.WriteLine("3.>to dig into baobab trees to get at the pulp inside");
             Console.WriteLine("4.>to move trees and branches when clearing a path.");
        }
          void Teeth()
        {
            Console.WriteLine("Teeth: They usually have 28 teeth. ");       
         
        }
          void Skin()
        {
            Console.WriteLine("Skin: It is extremely tough around most parts of its body and measures about 2.5 cm (1 in) thick.");             
        }
          void Legs()
        {
            Console.WriteLine("Legs and Feet: They are great straight pillars, as they must be to support its bulk weight.");
        }
          void Ears()
        {
            Console.WriteLine("Ears: Elephant ears are made of a very thin layer of skin stretched over cartilage and a rich network of blood vessels.");
        }
          void Herbivores()
        {
            Console.WriteLine("The Diet of elephants");
            Console.Writeline("Diet: Elephants are herbivores, spending 16 hours a day collecting plantf ood.");
        }
          void Interval()
        {
            Console.WriteLine("Reproduction:");
            Console.WriteLine("Females give birth at intervals of about every 5 years.");
        }
          void Weight()
        {
            Console.WriteLine("At birth, calves weigh around 90–115 kg.");
        }
          void Use()
        {
            Console.WriteLine("Domestication: Elephants have been working animals used in various capacities by humans.");
        }
    
    }
    
    
     
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("This is the presentation by Zoology Department");
            Console.WriteLine("Topic:Elephants");
            Elephants obj=new Elephants();
            obj.African();
            obj.Asian();
            obj.Trunk();
            obj.Tusk();
            obj.Teeth();
            obj.Skin();
            obj.Legs();
            obj.Ears();
            obj.Herbivores();
            obj.Interval();
            obj.Weight();
            obj.Use();
        }
    }
}