﻿using System.Collections.Concurrent;

namespace ObjectenWereld
{
    // Binnen de namespace mag ik alleen types definieren, zoals een class

    internal class Program
    {
        // Binnen de class mag ik alleen procedures en functies definieren.
        // Hier geen classen definieren
        static void Main(string[] args)
        {
            // En hier al helemaal niet.
            // Dit is jouw virtuele universum (Big Bang)
            Lamp led = new Lamp("geel");  // Lamp is het type, led is de variabelenaam en dus het object
            led.Sterkte = 200;
           // led.Kleur = "geel";

            string ssss = led.Kleur;
            Console.WriteLine(ssss);

            led.Aan();
            led.Uit();
            
            Lamp tl = new Lamp("rood");
            tl.Sterkte = -400;
            //tl.Kleur = "rood";

            tl.Aan();
            //Lamp[] lampen = new Lamp[5];
            //lampen[0] = led;
            //lampen[1] = tl;
            //List<Lamp> lams = new List<Lamp>();
            //lams.Add(led);
            //lams.Add(tl);

            // Property Initializers
            Lamp schemerlamp = new Lamp
            {
                Kleur = "blauw",
                Sterkte = 500
            };

            schemerlamp.Aan();
            // Einde universum (Big crunch)
        }
    }

    // Hier mag in classen definieren.
    // Dit is dus een type definitie van een lamp! (blauwdruk van een lamp)
    class Lamp
    {
        // Eigenschappen van de lamp. Die leg ik vast in variabelen:
        // En die noemt men dan FIELDS
        // Fields zijn by default private. Alleen binnen de class kan men erbij.
        // Als ze public zijn, kan iedereen erbij.
        private int sterkte = 0;
        //private string kleur;

        // CONSTRUCTORS.
        // Dit zijn speciale functies die bedoeld zijn om FIELDS 
        // een initiele waarde te geven.
        // Kunnen alleen door new worden aangeroepen!
        public Lamp()
        {
            Console.WriteLine("Hallo constructor");
        }
        // Ook constructors kunnen argumenten hebben.
        public Lamp(string kleur)
        {
            Kleur = kleur;
        }

        // Gecontroleerde toegang tot privates regel je via
        // PROPERTIES
        public int Sterkte
        {
            get
            {
                return sterkte;
            }
            set
            {
                if (value >= 0)
                {
                    sterkte = value; // Value is een impliciet argument
                }
            }
        }
        
        // Auto generating properties.
        // Die brengen hun eigen private field mee.
        public string Kleur { get; set; }

         // Gedrag van een lamp leg je vast in functies/procedures
         // En die noemt men dan METHODS
        public void Aan()
        {
            Console.WriteLine($"De lamp brandt in het {Kleur} met intensiteit {Sterkte}lm");
        }
        public void Uit()
        {
            Console.WriteLine("De lamp is nu uit");
        }
    }

}
