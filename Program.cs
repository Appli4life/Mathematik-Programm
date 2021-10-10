using System;
using System.Collections.Generic;

namespace Projekwoche_Dezember2020
{

    class Program
    {
       
        //Median
        public static double getMedian(double[] array)
        {
            int zaehlen = array.GetLength(0);
            if (zaehlen == 0) return (0);
            
            if ((zaehlen % 2) == 0)
                return ((array[(int)(zaehlen / 2) - 1] + array[(int)(zaehlen / 2)]) / 2);
            else
                return (array[zaehlen / 2]);
        }

        //Standartabweichung
        public static double getStandartabweichung(double[] array, double ds)
        {
            double standartabwerung;
            double zwischenwert = 0;

            foreach(double zahl in array)
            {
                zwischenwert += Math.Pow((zahl - ds), 2);            
            }

            standartabwerung = zwischenwert / array.Length;

            return Math.Pow(standartabwerung,0.5);

        }
        //Hauptprogramm
        static void Main(string[] args)
        {
            string nochmals = "i";
            Double Pi = 3.1415;
            do
            {
                int auswahl = 0;
                string beenden = "a";

                do
                {

                    nochmals = "i";
                    //Auswahl der Rechenart
                    Console.Clear();
                    Console.WriteLine("Wie wollen Sie Rechnen?:");
                    Console.WriteLine("");
                    Console.WriteLine("1: Verschiedene Formeln");
                    Console.WriteLine("2: 2 Dimensional");
                    Console.WriteLine("3: 3 Dimensional");
                    Console.WriteLine("");
                    Console.WriteLine("b: Beenden");
                    Console.WriteLine("");

                    //Aktuelles Pi 
                    if (Pi != 3.1415)
                    {


                        Console.WriteLine("Der aktuelle Wert für Pi ist: " + Pi);

                    }
                    if (Pi == 3.1415)
                    {
                        Console.WriteLine("Der Standartwert für Pi wird verwendet: " + Pi);
                    }
                    Console.WriteLine("Um Pi neu zu definieren, schreiben Sie: edit");
                    if (Pi != 3.1415)
                    {
                        Console.WriteLine("Um Pi auf den Standartwert zurückzusetzen, schreiben Sie: reset");

                    }
                    //Auswahl einlesen
                    Console.WriteLine("");
                    Console.Write("Eingabe: ");
                    string eingabe1 = Console.ReadLine();

                    //Neuer Wert für Pi
                    if (eingabe1 == "edit")
                    {
                        Console.Clear();
                        Console.WriteLine("Pi neu definieren:");
                        Console.WriteLine("Standart: 3.1415");
                        Console.Write("Neuer Wert: ");

                        string neuespi = Console.ReadLine();
                        Pi = Convert.ToDouble(neuespi);

                    }

                    //Pi zurücksetzen
                    if (eingabe1 == "reset")
                    {
                        Pi = Convert.ToDouble(3.1415);

                    }
                    //Beenden
                    if (eingabe1 == "b")
                    {
                        beenden = Convert.ToString(eingabe1);
                        break;
                    }

                    //Normal weiterfahren
                    if ((eingabe1 != "reset") && (eingabe1 != "edit"))
                    {
                        auswahl = Convert.ToInt32(eingabe1);
                    }

                    //Auswahl überprüfen
                } while ((auswahl != 1) && (auswahl != 2) && (auswahl != 3));

                //Zuweisung Wiederverwendbarer Längen/Werten und Pi
                Double länge1 = 0, länge2 = 0, länge3 = 0, länge4 = 0, länge5 = 0, resultat1 = 0, resultat2 = 0, resultat3 = 0, resultat4 = 0;


                //2 Dimensional
                if (auswahl == 2)
                {
                    int auswahl2 = 0;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("2 Dimensional");
                        Console.WriteLine("");

                        //Auswahl Formen
                        Console.WriteLine("Welche Form wollen Sie berechnen?:");
                        Console.WriteLine("");
                        Console.WriteLine("1: Dreieck");
                        Console.WriteLine("2: Rechteck/Quadrat");
                        Console.WriteLine("3: Kreis");
                        Console.WriteLine("4: Trapez");
                        Console.WriteLine("");
                        Console.WriteLine("z: Zurück");
                        Console.WriteLine("");

                        //Auswahl einlesen
                        Console.Write("Eingabe: ");
                        string eingabe2 = Console.ReadLine();

                        //Zurückgehen
                        if (eingabe2 == "z")
                        {
                            nochmals = Convert.ToString(eingabe2);
                            break;
                        }
                        else
                            auswahl2 = Convert.ToInt32(eingabe2);


                        //Auswahl überprüfen
                    } while ((auswahl2 != 1) && (auswahl2 != 2) && (auswahl2 != 3) && (auswahl2 != 4));


                    //Auswahl zuweisen
                    switch (auswahl2)
                    {

                        //Dreieck
                        case 1:
                            string fort = "i";
                            do
                            {
                                //Erste Seitenlänge                           
                                Console.Clear();
                                Console.WriteLine("Dreieck");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Länge der ersten Seite an: ");
                                string ersteseite = Console.ReadLine();
                                länge1 = Convert.ToDouble(ersteseite);

                                //Zweite Seitenlänge
                                Console.Clear();
                                Console.WriteLine("Dreieck");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Länge der zweiten Seite an: ");
                                string zweiteseite = Console.ReadLine();
                                länge2 = Convert.ToDouble(zweiteseite);

                                //Dritte Seitenlänge
                                Console.Clear();
                                Console.WriteLine("Dreieck");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Länge der dritten Seite an: ");
                                string dritteseite = Console.ReadLine();
                                länge3 = Convert.ToDouble(dritteseite);

                                //Berechnung                            
                                resultat1 = länge1 + länge2 + länge3;
                                resultat2 = resultat1 / 2;
                                //Satz des Heron
                                Double zwischenresultat = resultat2 * (resultat2 - länge1) * (resultat2 - länge2) * (resultat2 - länge3);
                                resultat3 = Math.Pow(zwischenresultat, 0.5);

                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Dreieck");
                                Console.WriteLine("");
                                Console.WriteLine("Fläche = " + resultat3);
                                Console.WriteLine("Umfang = " + resultat1);
                                Console.WriteLine("");
                                Console.WriteLine("Seiten: " + länge1 + ", " + länge2 + ", " + länge3);

                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren = Console.ReadLine();
                                if (fortfahren == "b")
                                {
                                    beenden = Convert.ToString(fortfahren);
                                }
                                else
                                    fort = Convert.ToString(fortfahren);


                            } while (fort != "f" && beenden != "b");
                            break;

                        //Rechteck/Quadrat
                        case 2:
                            string fort2 = "i";
                            do
                            {
                                //Erste Seitenlänge                          
                                Console.Clear();
                                Console.WriteLine("Rechteck/Quadrat");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Länge der ersten Seite an: ");
                                string vierteseite = Console.ReadLine();
                                länge1 = Convert.ToDouble(vierteseite);

                                //Zweite Seitenlänge
                                Console.Clear();
                                Console.WriteLine("Rechteck/Quadrat");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Länge der zweiten Seite an: ");
                                string fünfteseite = Console.ReadLine();
                                länge2 = Convert.ToDouble(fünfteseite);

                                //Berechnung                          
                                resultat1 = länge1 * länge2;
                                resultat2 = (länge1 * 2) + (länge2 * 2);

                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Rechteck/Quadrat");
                                Console.WriteLine("");
                                Console.WriteLine("Fläche = " + resultat1);
                                Console.WriteLine("Umfang = " + resultat2);
                                Console.WriteLine("");
                                Console.WriteLine("Seiten: " + länge1 + ", " + länge2);

                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren2 = Console.ReadLine();
                                if (fortfahren2 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren2);
                                }
                                else
                                    fort2 = Convert.ToString(fortfahren2);

                            } while (fort2 != "f" && beenden != "b");
                            break;
                        //Kreis
                        case 3:
                            string fort3 = "i";
                            do
                            {
                                //Radius einlesen
                                Console.Clear();
                                Console.WriteLine("Kreis");
                                Console.WriteLine("");
                                Console.Write("Geben Sie den Radius an: ");
                                string sechsteseite = Console.ReadLine();
                                länge1 = Convert.ToDouble(sechsteseite);

                                //Durchmesser bestimmen
                                länge2 = länge1 * 2;

                                //Berechnung
                                resultat1 = länge1 * länge1 * Pi;
                                resultat2 = länge2 * Pi;

                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Kreis");
                                Console.WriteLine("");
                                Console.WriteLine("Fläche = " + resultat1);
                                Console.WriteLine("Umfang = " + resultat2);

                                //Pi anzeigen
                                Console.WriteLine("");
                                Console.WriteLine("(" + Pi + " für Pi)");
                                Console.WriteLine("");
                                Console.WriteLine("Radius: " + länge1);

                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren3 = Console.ReadLine();
                                if (fortfahren3 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren3);
                                }
                                else
                                    fort3 = Convert.ToString(fortfahren3);

                            } while (fort3 != "f" && beenden != "b");

                            break;
                        //Trapez
                        case 4:
                            string fort4 = "i";
                            do
                            {
                                //Erste Seitenlänge
                                Console.Clear();
                                Console.WriteLine("Trapez");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Länge der ersten parallelen Seite an: ");
                                string siebteseite = Console.ReadLine();
                                länge1 = Convert.ToDouble(siebteseite);

                                //Zweite Seitenlänge
                                Console.Clear();
                                Console.WriteLine("Trapez");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Länge der zweiten parallelen Seite an: ");
                                string achteseite = Console.ReadLine();
                                länge2 = Convert.ToDouble(achteseite);

                                //Dritte Seitenlänge
                                Console.Clear();
                                Console.WriteLine("Trapez");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Länge der ersten nicht parallelen Seite an: ");
                                string neunteseite = Console.ReadLine();
                                länge3 = Convert.ToDouble(neunteseite);

                                //Vierte Seitenlänge
                                Console.Clear();
                                Console.WriteLine("Trapez");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Länge der zweiten nicht parallelen Seite an: ");
                                string eseite = Console.ReadLine();
                                länge4 = Convert.ToDouble(eseite);

                                //Höhe
                                Console.Clear();
                                Console.WriteLine("Trapez");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Höhe an: ");
                                string längeneingabe2 = Console.ReadLine();
                                länge5 = Convert.ToDouble(längeneingabe2);

                                //Berechnen
                                resultat1 = ((länge1 + länge2) / 2) * länge5;
                                resultat2 = länge1 + länge2 + länge3 + länge4;
                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Trapez");
                                Console.WriteLine("");
                                Console.WriteLine("Fläche = " + resultat1);
                                Console.WriteLine("Umfang = " + resultat2);
                                Console.WriteLine("");
                                Console.WriteLine("Seiten: " + länge1 + ", " + länge2 + ", " + länge3 + ", " + länge4);
                                Console.WriteLine("Höhe: " + länge5);

                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren4 = Console.ReadLine();
                                if (fortfahren4 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren4);
                                }
                                else
                                    fort4 = Convert.ToString(fortfahren4);

                            } while (fort4 != "f" && beenden != "b");
                            break;
                    }
                }
                //3 Dimensional
                if (auswahl == 3)
                {
                    int auswahl3 = 0;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("3 Dimensional");
                        Console.WriteLine("");

                        //Auswahl Formen
                        Console.WriteLine("Welchen Körper wollen Sie berechnen?:");
                        Console.WriteLine("");
                        Console.WriteLine("1: Quader");
                        Console.WriteLine("2: Kugel");
                        Console.WriteLine("3: Zylinder");
                        Console.WriteLine("4: Kegel");
                        Console.WriteLine("5: Quadratische Pyramide");
                        Console.WriteLine("6: Dreiseitiige Pyiramide");
                        Console.WriteLine("");
                        Console.WriteLine("z: Zurück");
                        Console.WriteLine("");
                        Console.Write("Eingabe: ");

                        //Auswahl einlesen
                        string eingabe3 = Console.ReadLine();
                        //Zurückgehen
                        if (eingabe3 == "z")
                        {
                            nochmals = Convert.ToString(eingabe3);
                            break;
                        }
                        else
                            auswahl3 = Convert.ToInt32(eingabe3);

                        //Auswahl überprüfen
                    } while ((auswahl3 != 1) && (auswahl3 != 2) && (auswahl3 != 3) && (auswahl3 != 4) && (auswahl3 != 5) && (auswahl3 != 6));

                    //Auswahl zuweisen
                    switch (auswahl3)
                    {
                        //Quader
                        case 1:
                            string fort = "i";
                            do
                            {
                                //Länge
                                Console.Clear();
                                Console.WriteLine("Quader");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Länge an: ");
                                string längeneingabe = Console.ReadLine();
                                länge1 = Convert.ToDouble(längeneingabe);

                                //Breite
                                Console.Clear();
                                Console.WriteLine("Quader");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Breite an: ");
                                string längeneingabe1 = Console.ReadLine();
                                länge2 = Convert.ToDouble(längeneingabe1);

                                //Höhe
                                Console.Clear();
                                Console.WriteLine("Quader");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Höhe an: ");
                                string längeneingabe2 = Console.ReadLine();
                                länge3 = Convert.ToDouble(längeneingabe2);

                                //Berechnung
                                resultat1 = (länge1 * länge2 * länge3);
                                resultat2 = (länge1 * länge2 * 2) + (länge1 * länge3 * 2) + (länge3 * länge2 * 2);

                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Quader");
                                Console.WriteLine("");
                                Console.WriteLine("Volumen = " + resultat1);
                                Console.WriteLine("Oberfläche = " + resultat2);
                                Console.WriteLine("");
                                Console.WriteLine("Länge: " + länge1 + " Breite: " + länge2 + " Höhe: " + länge3);
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren5 = Console.ReadLine();
                                if (fortfahren5 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren5);
                                }
                                else
                                    fort = Convert.ToString(fortfahren5);

                            } while (fort != "f" && beenden != "b");
                            break;

                        //Kugel
                        case 2:
                            string fort1 = "i";
                            do
                            {
                                //Radius einlesen
                                Console.Clear();
                                Console.WriteLine("Kugel");
                                Console.WriteLine("");
                                Console.Write("Geben Sie den Radius an: ");
                                string radius = Console.ReadLine();
                                länge1 = Convert.ToDouble(radius);

                                //Durchmesser bestimmen
                                länge2 = länge1 * 2;

                                //Berechnung
                                resultat1 = Math.Pow(länge1, 3);
                                resultat2 = (resultat1 * Pi * 4) / 3;
                                resultat3 = Math.Pow(länge1, 2);
                                resultat4 = resultat3 * 4 * Pi;

                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Kugel");
                                Console.WriteLine("");
                                Console.WriteLine("Volumen = " + resultat2);
                                Console.WriteLine("Oberfläche = " + resultat4);

                                //Pi anzeigen
                                Console.WriteLine("");
                                Console.WriteLine("(" + Pi + " für Pi)");
                                Console.WriteLine("");
                                Console.WriteLine("Radius: " + länge1);
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren66 = Console.ReadLine();
                                if (fortfahren66 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren66);
                                }
                                else
                                    fort1 = Convert.ToString(fortfahren66);

                            } while (fort1 != "f" && beenden != "b");
                            break;

                        //Zylinder
                        case 3:
                            string fort2 = "i";
                            do
                            {
                                //Radius einlesen
                                Console.Clear();
                                Console.WriteLine("Zylinder");
                                Console.WriteLine("");
                                Console.Write("Geben Sie den Radius an: ");
                                string radius1 = Console.ReadLine();
                                länge1 = Convert.ToDouble(radius1);

                                //Höhe
                                Console.Clear();
                                Console.WriteLine("Zylinder");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Höhe an: ");
                                string höhe = Console.ReadLine();
                                länge2 = Convert.ToDouble(höhe);

                                //Berechnung 
                                resultat1 = länge1 * länge1 * Pi * länge2;
                                resultat2 = (2 * länge1 * länge1 * Pi) + (länge1 * 2 * Pi * länge2);

                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Zylinder");
                                Console.WriteLine("");
                                Console.WriteLine("Volumen = " + resultat1);
                                Console.WriteLine("Oberfläche = " + resultat2);
                                Console.WriteLine("");
                                Console.WriteLine("Radius: " + länge1);
                                Console.WriteLine("Höhe: " + länge2);

                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren6 = Console.ReadLine();
                                if (fortfahren6 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren6);
                                }
                                else
                                    fort2 = Convert.ToString(fortfahren6);

                            } while (fort2 != "f" && beenden != "b");
                            break;

                        //Kegel
                        case 4:
                            string fort3 = "i";
                            do
                            {
                                //Radius einlesen
                                Console.Clear();
                                Console.WriteLine("Kegel");
                                Console.WriteLine("");
                                Console.Write("Geben Sie den Radius an: ");
                                string radius2 = Console.ReadLine();
                                länge1 = Convert.ToDouble(radius2);

                                //Höhe
                                Console.Clear();
                                Console.WriteLine("Zylinder");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Höhe an: ");
                                string höhe1 = Console.ReadLine();
                                länge2 = Convert.ToDouble(höhe1);

                                //Mantellinie bestimmen (Satz des Pythagoras)
                                Double zwischenwert = ((länge1 * länge1) + (länge2 * länge2));

                                //Wurzelziehung
                                Double s = Math.Pow(zwischenwert, 0.5);

                                //Berechnung
                                resultat1 = ((länge1 * länge1) / 3) * Pi * länge2;
                                resultat2 = (länge1 * länge1 * Pi) + (länge1 * Pi * s);

                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Kegel");
                                Console.WriteLine("");
                                Console.WriteLine("Volumen = " + resultat1);
                                Console.WriteLine("Oberfläche = " + resultat2);
                                Console.WriteLine("");
                                Console.WriteLine("Radius: " + länge1);
                                Console.WriteLine("Höhe: " + länge2);

                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren7 = Console.ReadLine();
                                if (fortfahren7 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren7);
                                }
                                else
                                    fort3 = Convert.ToString(fortfahren7);


                            } while (fort3 != "f" && beenden != "b");
                            break;

                        //Quadratische Pyramide
                        case 5:
                            string fort4 = "i";
                            do
                            {
                                //Erste Seitenlänge                          
                                Console.Clear();
                                Console.WriteLine("Quadratische Pyramide");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Seitenlänge der Grundfläche an: ");
                                string seite = Console.ReadLine();
                                länge1 = Convert.ToDouble(seite);

                                //Höhe
                                Console.Clear();
                                Console.WriteLine("Quadratische Pyramide");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Höhe der Pyramide an: ");
                                string höhe2 = Console.ReadLine();
                                länge2 = Convert.ToDouble(höhe2);

                                //Mantellinie bestimmen (Satz des Pythagoras)
                                Double zwischenwert1 = ((länge1 * länge1) + (länge2 * länge2));

                                //Wurzelziehung
                                Double s1 = Math.Pow(zwischenwert1, 0.5);

                                //Berechnung
                                resultat1 = (länge1 * länge1 * länge2) / 3;
                                resultat2 = (länge1 * länge1) + 2 * s1 * länge1;

                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Quadratische Pyramide");
                                Console.WriteLine("");
                                Console.WriteLine("Volumen = " + resultat1);
                                Console.WriteLine("Oberfläche = " + resultat2);
                                Console.WriteLine("");
                                Console.WriteLine("Seite: " + länge1);
                                Console.WriteLine("Höhe: " + länge2);
                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren8 = Console.ReadLine();
                                if (fortfahren8 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren8);
                                }
                                else
                                    fort4 = Convert.ToString(fortfahren8);


                            } while (fort4 != "f" && beenden != "b");
                            break;

                        //Dreiseitige Pyramide
                        case 6:
                            string fort5 = "i";
                            do
                            {
                                //Erste Seitenlänge                           
                                Console.Clear();
                                Console.WriteLine("Dreiseitige Pyramide");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Länge der Grundfläche an: ");
                                string ersteseite = Console.ReadLine();
                                länge1 = Convert.ToDouble(ersteseite);

                                //Zweite Seitenlänge
                                Console.Clear();
                                Console.WriteLine("Dreiseitige Pyramide");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die zweite Länge der Grundfläche an: ");
                                string zweiteseite = Console.ReadLine();
                                länge2 = Convert.ToDouble(zweiteseite);

                                //Dritte Seitenlänge
                                Console.Clear();
                                Console.WriteLine("Dreiseitige Pyramide");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die dritte Länge der Grundfläche an: ");
                                string dritteseite = Console.ReadLine();
                                länge3 = Convert.ToDouble(dritteseite);

                                //Höhe
                                Console.Clear();
                                Console.WriteLine("Dreiseitige Pyramide");
                                Console.WriteLine("");
                                Console.Write("Geben Sie die Höhe der Pyramide an: ");
                                string höhe3 = Console.ReadLine();
                                länge4 = Convert.ToDouble(höhe3);

                                //Umfang der Grundfläche
                                resultat1 = länge1 + länge2 + länge3;

                                //Grundfläche bestimmen                        
                                resultat2 = resultat1 / 2;
                                Double zwischenresultat = resultat2 * (resultat2 - länge1) * (resultat2 - länge2) * (resultat2 - länge3);
                                resultat3 = Math.Pow(zwischenresultat, 0.5);

                                //Volumen und Oberfläche
                                resultat4 = (resultat3 * länge4) / 3;

                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Dreiseitige Pyramide");
                                Console.WriteLine("");
                                Console.WriteLine("Volumen = " + resultat4);
                                Console.WriteLine("");
                                Console.WriteLine("Seiten: " + länge1 + ", " + länge2 + ", " + länge3);
                                Console.WriteLine("Höhe: " + länge4);

                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren9 = Console.ReadLine();
                                if (fortfahren9 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren9);
                                }
                                else
                                    fort5 = Convert.ToString(fortfahren9);


                            } while (fort5 != "f" && beenden != "b");

                            break;
                    }
                }

                //Formeln
                if (auswahl == 1)
                {
                    int auswahl4 = 0;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Verschiedene Formeln");
                        Console.WriteLine("");

                        //Auswahl Formeln
                        Console.WriteLine("Mit welcher Formel wollen Sie rechnen?:");
                        Console.WriteLine("");
                        Console.WriteLine("1: Mitternachts");
                        Console.WriteLine("2: Pythagoras ");
                        Console.WriteLine("3: Logarithmus");
                        Console.WriteLine("4: Trigonometrie: Winkelfunktionen");
                        Console.WriteLine("5: Statistiken");
                        Console.WriteLine("");
                        Console.WriteLine("z: Zurück");
                        Console.WriteLine("");
                        Console.Write("Eingabe: ");


                        //Auswahl einlesen
                        string eingabe4 = Console.ReadLine();
                        //Zurückgehen
                        if (eingabe4 == "z")
                        {
                            nochmals = Convert.ToString(eingabe4);
                            break;
                        }
                        else

                            auswahl4 = Convert.ToInt32(eingabe4);

                        //Auswahl überprüfen
                    } while ((auswahl4 != 1) && (auswahl4 != 2) && (auswahl4 != 3) && (auswahl4 != 4) && (auswahl4 != 5));

                    switch (auswahl4)
                    {
                        //Mitternachtsformel
                        case 1:
                            string fort = "i";
                            do
                            {
                                //a eingeben
                                Console.Clear();
                                Console.WriteLine("Mitternachtsformel");
                                Console.WriteLine("");
                                Console.Write("Geben Sie den Wert a an: ");
                                string dritteseite = Console.ReadLine();
                                länge1 = Convert.ToDouble(dritteseite);

                                //b eingeben
                                Console.Clear();
                                Console.WriteLine("Mitternachtsformel");
                                Console.WriteLine("");
                                Console.Write("Geben Sie den Wert b an: ");
                                string eseite = Console.ReadLine();
                                länge2 = Convert.ToDouble(eseite);

                                //c eingeben
                                Console.Clear();
                                Console.WriteLine("Mitternachtsformel");
                                Console.WriteLine("");
                                Console.Write("Geben Sie den Wert c an: ");
                                string teseite = Console.ReadLine();
                                länge3 = Convert.ToDouble(teseite);

                                //Erste Lösung mit Plus
                                Double hoch2 = länge2 * länge2;
                                Double zwischenresultat = ((hoch2) - (4 * länge1 * länge3));
                                Double zwischenresultat2 = Math.Pow(zwischenresultat, 0.5);
                                resultat1 = ((-1 * länge2) + zwischenresultat2) / (2 * länge1);

                                //Zweite Lösung mit Minus                           
                                resultat2 = ((-1 * länge2) - zwischenresultat2) / (2 * länge1);

                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Mitternachtsformel");
                                Console.WriteLine("");
                                Console.WriteLine("Erste Lösung = " + resultat1);
                                Console.WriteLine("Zweite Lösung = " + resultat2);
                                Console.WriteLine("");
                                Console.WriteLine("a: " + länge1 + " b: " + länge2 + " c: " + länge3);

                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren10 = Console.ReadLine();
                                if (fortfahren10 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren10);
                                }
                                else
                                    fort = Convert.ToString(fortfahren10);


                            } while (fort != "f" && beenden != "b");
                            break;

                        //Pythagoras
                        case 2:
                            string fort2 = "a";
                            do
                            {

                                Console.Clear();
                                Console.WriteLine("Pythagoras");
                                Console.WriteLine("");
                                Console.Write("Geben Sie den Wert a an: ");
                                string driteseite = Console.ReadLine();
                                länge1 = Convert.ToDouble(driteseite);

                                //b eingeben
                                Console.Clear();
                                Console.WriteLine("Pythagoras");
                                Console.WriteLine("");
                                Console.Write("Geben Sie den Wert b an: ");
                                string eeite = Console.ReadLine();
                                länge2 = Convert.ToDouble(eeite);

                              

                                
                                //Berechnung
                                resultat1 = (länge1 * länge1) + (länge2 * länge2);
                                resultat2 = Math.Pow(resultat1, 0.5);

                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Pythagoras");
                                Console.WriteLine("");
                                Console.WriteLine("länge c = " + resultat2);
                                Console.WriteLine("");
                                Console.WriteLine("länge a: " + länge1 + " länge b: " + länge2);


                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren11 = Console.ReadLine();
                                if (fortfahren11 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren11);
                                }
                                else
                                    fort2 = Convert.ToString(fortfahren11);

                            } while (fort2 != "f" && beenden != "b");

                            break;

                        //Logarithmus
                        case 3:

                            string fort3 = "a";
                            do
                            {
                                //Basis
                                Console.Clear();
                                Console.WriteLine("Logarithmus");
                                Console.WriteLine("");
                                Console.Write("Geben Sie den Wert der Basis ein: ");
                                string driteseite = Console.ReadLine();
                                länge1 = Convert.ToDouble(driteseite);

                                //Nemerus
                                Console.Clear();
                                Console.WriteLine("Logarithmus");
                                Console.WriteLine("");
                                Console.Write("Geben Sie den Wert der Nemerus ein: ");
                                string vierteseite = Console.ReadLine();
                                länge2 = Convert.ToDouble(vierteseite);

                                //Berechnung
                                resultat1 = Math.Log(länge2, länge1);

                                //Ergebnis anzeigen
                                Console.Clear();
                                Console.WriteLine("Logarithmus");
                                Console.WriteLine("");
                                Console.WriteLine("Ergibt: " + resultat1);
                                Console.WriteLine("");
                                Console.WriteLine("Basis: " + länge1);
                                Console.WriteLine("Nemerus: " + länge2);

                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren11 = Console.ReadLine();
                                if (fortfahren11 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren11);
                                }
                                else
                                    fort3 = Convert.ToString(fortfahren11);


                            } while (fort3 != "f" && beenden != "b");
                            break;

                        //Trigonometrie
                        case 4:
                            double winkel = 0, verhältnis = 0;

                            string fort4 = "a";
                            do
                            {

                            //Falls falsch eingegeben beginne hier 
                            falscheeingabe:

                                länge1 = 0;
                                länge2 = 0;
                                länge3 = 0;
                                länge4 = 0;
                                resultat1 = 0;
                                resultat2 = 0;
                                resultat3 = 0;
                                resultat4 = 0;

                                Console.Clear();
                                Console.WriteLine("Trigonometrie: Winkelfunktionen");

                                //Auswahl: Sinus, Kosinus und Tangens
                                Console.WriteLine("");
                                Console.WriteLine("Mit welecher Winkelfunktion wollen Sie Rechnen?:");
                                Console.WriteLine("");
                                Console.WriteLine("1: Sinus");
                                Console.WriteLine("2: Konsinus");
                                Console.WriteLine("3: Tangens");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                //Auswahl Einlesen
                                string eingabetri = Console.ReadLine();
                                int wahl = Convert.ToInt32(eingabetri);

                                //Falls Falsche Eingabe
                                if ((wahl != 1) && (wahl != 2) && (wahl != 3) && (wahl != 13))
                                {
                                    //Zurück zur Auswahl
                                    goto falscheeingabe;
                                }

                                //Int das der Winkel/Verhältnis nicht 2 mal eingelesen wird
                                int bereitseingelesen = 0;

                                switch (wahl)
                                {
                                    //Sinus
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("Sinus");
                                        Console.WriteLine("");
                                        Console.WriteLine("Geben Sie die Gegenkathete an: ");
                                        Console.WriteLine("");
                                        Console.WriteLine("Falls Sie den Wert nicht kennen,");
                                        Console.WriteLine("geben Sie 'w' ein um den Winkel einzugen oder 'v' für das Verhältnis!");
                                        Console.WriteLine("");
                                        Console.Write("Eingabe: ");
                                        string Geite = Console.ReadLine();

                                        //Winkel einlesen
                                        if (Geite == "w")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Sinus");
                                            Console.WriteLine("");
                                            Console.Write("Geben Sie den Winkel in Grad an: ");
                                            string wink = Console.ReadLine();
                                            winkel = Convert.ToDouble(wink);

                                            //Verhältnis ausrechnen
                                            verhältnis = Math.Sin(winkel * 3.1415926535897932 / 180);
                                            bereitseingelesen = 1;
                                        }

                                        //Verhältnis einlesen
                                        else if (Geite == "v")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Sinus");
                                            Console.WriteLine("");
                                            Console.Write("Geben Sie das Verhältnis an: ");
                                            string ver = Console.ReadLine();
                                            verhältnis = Convert.ToDouble(ver);

                                            //Winkel ausrechnen
                                            double resultat6 = Math.Asin(verhältnis);
                                            winkel = resultat6 * 180 / 3.1415926535897932;

                                            bereitseingelesen = 1;
                                        }
                                        else
                                        {
                                            //länge1 = Hypotenuse
                                            länge1 = Convert.ToDouble(Geite);
                                        }

                                        Console.Clear();
                                        Console.WriteLine("Sinus");
                                        Console.WriteLine("");
                                        Console.WriteLine("Geben Sie die Hypotenuse an: ");
                                        Console.WriteLine("");

                                        //Falls Winkel/Verhältnis bereits eingelesen wurde
                                        if (bereitseingelesen != 1)
                                        {
                                            Console.WriteLine("Falls Sie den Wert nicht kennen,");
                                            Console.WriteLine("geben Sie 'w' ein um den Winkel einzugen oder 'v' für das Verhältnis!");
                                            Console.WriteLine("");
                                        }

                                        Console.Write("Eingabe: ");
                                        string Heite = Console.ReadLine();

                                        if (bereitseingelesen == 1)
                                        {
                                            //länge2 = Hypotenuse
                                            länge2 = Convert.ToDouble(Heite);
                                            //überspringen falls eingelesen
                                            goto überspringen;
                                        }

                                        //Winkel einlesen (Falls nicht schon getan)
                                        if (Heite == "w")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Sinus");
                                            Console.WriteLine("");
                                            Console.Write("Geben Sie den Winkel in Grad an: ");
                                            string wink = Console.ReadLine();
                                            winkel = Convert.ToDouble(wink);

                                            //Verhältnis ausrechnen
                                            verhältnis = Math.Sin(winkel * 3.1415926535897932 / 180);
                                        }

                                        //Verhältnis einlesen (Falls nicht schon getan)
                                        else if (Heite == "v")
                                        {
                                            verhältnis = Convert.ToDouble(Geite);
                                            Console.Clear();
                                            Console.WriteLine("Sinus");
                                            Console.WriteLine("");
                                            Console.Write("Geben Sie das Verhältnis an: ");
                                            string ver = Console.ReadLine();
                                            verhältnis = Convert.ToDouble(ver);

                                            //Winkel ausrechnen
                                            resultat3 = Math.Asin(verhältnis);
                                            winkel = resultat3 * 180 / 3.1415926535897932;
                                        }
                                        else
                                        {
                                            //länge2 = Hypotenuse
                                            länge2 = Convert.ToDouble(Heite);
                                        }

                                    //falls schon eingelesen
                                    überspringen:

                                        //Fehlendes ausrechnen

                                        //Wenn Hypotenuse leer ist
                                        if (länge2 == 0)
                                        {
                                            //Hypotenuse
                                            länge2 = länge1 / verhältnis;

                                            //Ankathete
                                            double zwischenergebnis = (länge2 * länge2) - (länge1 * länge1);
                                            länge3 = Math.Pow(zwischenergebnis, 0.5);
                                        }

                                        //Wenn Gegenkathete leer ist
                                        else if (länge1 == 0)
                                        {
                                            //Gegenkathete
                                            länge1 = länge2 * verhältnis;

                                            //Ankathete
                                            double zwischenergebnis = (länge2 * länge2) - (länge1 * länge1);
                                            länge3 = Math.Pow(zwischenergebnis, 0.5);
                                        }

                                        //Wenn Verhältnis/Winkel leer ist
                                        else
                                        {
                                            //Verhältnis 
                                            verhältnis = länge1 / länge2;

                                            //Winkel ausrechnen
                                            resultat2 = Math.Asin(verhältnis);
                                            winkel = resultat2 * 180 / 3.1415926535897932;

                                            //Ankathete
                                            double zwischenergebnis = (länge2 * länge2) - (länge1 * länge1);
                                            länge3 = Math.Pow(zwischenergebnis, 0.5);
                                        }

                                        //Ergebnis Anzeigen
                                        Console.Clear();
                                        Console.WriteLine("Sinus");
                                        Console.WriteLine("");
                                        Console.WriteLine("Ergebnisse:");
                                        Console.WriteLine("");
                                        Console.WriteLine("Gegenkathete: " + länge1);
                                        Console.WriteLine("Hypotenuse: " + länge2);
                                        Console.WriteLine("Ankathete: " + länge3);
                                        Console.WriteLine("Winkel: " + winkel);
                                        Console.WriteLine("Verhältnis: " + verhältnis);

                                        break;

                                    //Kosinus
                                    case 2:

                                        /* Ankathete = Aeite, länge3
                                           Gegenkathete = Geite, länge2
                                           Hypotenuse = Heite, länge1
                                           Winkel = wink, winkel
                                           Verhältnis = ver, verhältnis
                                         */

                                        Console.Clear();
                                        Console.WriteLine("Konsinus");
                                        Console.WriteLine("");
                                        Console.WriteLine("Geben Sie die Ankathete an: ");
                                        Console.WriteLine("");
                                        Console.WriteLine("Falls Sie den Wert nicht kennen,");
                                        Console.WriteLine("geben Sie 'w' ein um den Winkel einzugen oder 'v' für das Verhältnis!");
                                        Console.WriteLine("");
                                        Console.Write("Eingabe: ");
                                        string Aeite = Console.ReadLine();

                                        //Winkel einlesen
                                        if (Aeite == "w")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Kosinus");
                                            Console.WriteLine("");
                                            Console.Write("Geben Sie den Winkel in Grad an: ");
                                            string wink = Console.ReadLine();
                                            winkel = Convert.ToDouble(wink);

                                            //Verhältnis ausrechnen
                                            verhältnis = Math.Cos(winkel * 3.1415926535897932 / 180);
                                            bereitseingelesen = 1;
                                        }

                                        //Verhältnis einlesen
                                        else if (Aeite == "v")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Kosinus");
                                            Console.WriteLine("");
                                            Console.Write("Geben Sie das Verhältnis an: ");
                                            string ver = Console.ReadLine();
                                            verhältnis = Convert.ToDouble(ver);

                                            //Winkel ausrechnen
                                            double resultat6 = Math.Acos(verhältnis);
                                            winkel = resultat6 * 180 / 3.1415926535897932;

                                            bereitseingelesen = 1;
                                        }
                                        else
                                        {
                                            //länge3 = Ankathete
                                            länge3 = Convert.ToDouble(Aeite);
                                        }

                                        Console.Clear();
                                        Console.WriteLine("Kosinus");
                                        Console.WriteLine("");
                                        Console.WriteLine("Geben Sie die Hypotenuse an: ");
                                        Console.WriteLine("");

                                        //Falls Winkel/Verhältnis bereits eingelesen wurde
                                        if (bereitseingelesen != 1)
                                        {
                                            Console.WriteLine("Falls Sie den Wert nicht kennen,");
                                            Console.WriteLine("geben Sie 'w' ein um den Winkel einzugen oder 'v' für das Verhältnis!");
                                            Console.WriteLine("");
                                        }

                                        Console.Write("Eingabe: ");
                                        Heite = Console.ReadLine();

                                        if (bereitseingelesen == 1)
                                        {
                                            //länge1 = Hypotenuse
                                            länge1 = Convert.ToDouble(Heite);

                                            //überspringen falls eingelesen
                                            goto überspringenkosinus;
                                        }

                                        //Winkel einlesen (Falls nicht schon getan)
                                        if (Heite == "w")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Kosinus");
                                            Console.WriteLine("");
                                            Console.Write("Geben Sie den Winkel in Grad an: ");
                                            string wink = Console.ReadLine();
                                            winkel = Convert.ToDouble(wink);

                                            //Verhältnis ausrechnen
                                            verhältnis = Math.Cos(winkel * 3.1415926535897932 / 180);
                                        }

                                        //Verhältnis einlesen (Falls nicht schon getan)
                                        else if (Heite == "v")
                                        {
                                            verhältnis = Convert.ToDouble(Heite);
                                            Console.Clear();
                                            Console.WriteLine("Kosinus");
                                            Console.WriteLine("");
                                            Console.Write("Geben Sie das Verhältnis an: ");
                                            string ver = Console.ReadLine();
                                            verhältnis = Convert.ToDouble(ver);

                                            //Winkel ausrechnen
                                            resultat3 = Math.Acos(verhältnis);
                                            winkel = resultat3 * 180 / 3.1415926535897932;
                                        }
                                        else
                                        {
                                            //länge1 = Hypotenuse
                                            länge1 = Convert.ToDouble(Heite);
                                        }

                                    //falls schon eingelesen
                                    überspringenkosinus:

                                        //Fehlendes ausrechnen

                                        //Wenn Hypotenuse leer ist
                                        if (länge1 == 0)
                                        {
                                            //Hypotenuse
                                            länge1 = länge3 / verhältnis;

                                            //Gegenkathete
                                            double zwischenergebnis = (länge1 * länge1) - (länge3 * länge3);
                                            länge2 = Math.Pow(zwischenergebnis, 0.5);
                                        }

                                        //Wenn Ankathete leer ist
                                        else if (länge3 == 0)
                                        {
                                            //Ankathete
                                            länge3 = länge1 * verhältnis;

                                            //Gegenkathete
                                            double zwischenergebnis = (länge1 * länge1) - (länge3 * länge3);
                                            länge2 = Math.Pow(zwischenergebnis, 0.5);
                                        }

                                        //Wenn Verhältnis/Winkel leer ist
                                        else
                                        {
                                            //Verhältnis 
                                            verhältnis = länge3 / länge1;

                                            //Winkel ausrechnen
                                            resultat2 = Math.Acos(verhältnis);
                                            winkel = resultat2 * 180 / 3.1415926535897932;

                                            //Gegenkathete
                                            double zwischenergebnis = (länge1 * länge1) - (länge3 * länge3);
                                            länge2 = Math.Pow(zwischenergebnis, 0.5);
                                        }

                                        //Ergebnis Anzeigen
                                        Console.Clear();
                                        Console.WriteLine("Kosinus");
                                        Console.WriteLine("");
                                        Console.WriteLine("Ergebnisse:");
                                        Console.WriteLine("");
                                        Console.WriteLine("Ankathete: " + länge3);
                                        Console.WriteLine("Hypotenuse: " + länge1);
                                        Console.WriteLine("Gegenkathete: " + länge2);
                                        Console.WriteLine("Winkel: " + winkel);
                                        Console.WriteLine("Verhältnis: " + verhältnis);
                                        break;

                                    //Tangens
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("Tangens");
                                        Console.WriteLine("");
                                        Console.WriteLine("Geben Sie die Gegenkathete an: ");
                                        Console.WriteLine("");
                                        Console.WriteLine("Falls Sie den Wert nicht kennen,");
                                        Console.WriteLine("geben Sie 'w' ein um den Winkel einzugen oder 'v' für das Verhältnis!");
                                        Console.WriteLine("");
                                        Console.Write("Eingabe: ");
                                        Geite = Console.ReadLine();

                                        //Winkel einlesen
                                        if (Geite == "w")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Tangens");
                                            Console.WriteLine("");
                                            Console.Write("Geben Sie den Winkel in Grad an: ");
                                            string wink = Console.ReadLine();
                                            winkel = Convert.ToDouble(wink);

                                            //Verhältnis ausrechnen
                                            verhältnis = Math.Tan(winkel * 3.1415926535897932 / 180);
                                            bereitseingelesen = 1;
                                        }

                                        //Verhältnis einlesen
                                        else if (Geite == "v")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Tangens");
                                            Console.WriteLine("");
                                            Console.Write("Geben Sie das Verhältnis an: ");
                                            string ver = Console.ReadLine();
                                            verhältnis = Convert.ToDouble(ver);

                                            //Winkel ausrechnen
                                            double resultat6 = Math.Atan(verhältnis);
                                            winkel = resultat6 * 180 / 3.1415926535897932;

                                            bereitseingelesen = 1;
                                        }
                                        else
                                        {
                                            //länge1 = Gegenkathete
                                            länge1 = Convert.ToDouble(Geite);
                                        }

                                        Console.Clear();
                                        Console.WriteLine("Tangens");
                                        Console.WriteLine("");
                                        Console.WriteLine("Geben Sie die Ankathete an: ");
                                        Console.WriteLine("");

                                        //Falls Winkel/Verhältnis bereits eingelesen wurde
                                        if (bereitseingelesen != 1)
                                        {
                                            Console.WriteLine("Falls Sie den Wert nicht kennen,");
                                            Console.WriteLine("geben Sie 'w' ein um den Winkel einzugen oder 'v' für das Verhältnis!");
                                            Console.WriteLine("");
                                        }

                                        Console.Write("Eingabe: ");
                                        Aeite = Console.ReadLine();

                                        if (bereitseingelesen == 1)
                                        {
                                            //länge2 = Ankathete
                                            länge2 = Convert.ToDouble(Aeite);

                                            //überspringen falls eingelesen
                                            goto überspringentangens;
                                        }

                                        //Winkel einlesen (Falls nicht schon getan)
                                        if (Aeite == "w")
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Tangens");
                                            Console.WriteLine("");
                                            Console.Write("Geben Sie den Winkel in Grad an: ");
                                            string wink = Console.ReadLine();
                                            winkel = Convert.ToDouble(wink);

                                            //Verhältnis ausrechnen
                                            verhältnis = Math.Tan(winkel * 3.1415926535897932 / 180);
                                        }

                                        //Verhältnis einlesen (Falls nicht schon getan)
                                        else if (Aeite == "v")
                                        {
                                            verhältnis = Convert.ToDouble(Geite);
                                            Console.Clear();
                                            Console.WriteLine("Tangens");
                                            Console.WriteLine("");
                                            Console.Write("Geben Sie das Verhältnis an: ");
                                            string ver = Console.ReadLine();
                                            verhältnis = Convert.ToDouble(ver);

                                            //Winkel ausrechnen
                                            resultat3 = Math.Atan(verhältnis);
                                            winkel = resultat3 * 180 / 3.1415926535897932;
                                        }
                                        else
                                        {
                                            //länge2 = Ankathete
                                            länge2 = Convert.ToDouble(Aeite);
                                        }

                                    //falls schon eingelesen
                                    überspringentangens:

                                        //Fehlendes ausrechnen

                                        //Wenn Gegenkathete leer ist
                                        if (länge1 == 0)
                                        {
                                            //Gegenkathete
                                            länge1 = länge2 * verhältnis;

                                            //Hypotenuse
                                            double zwischenergebnis = (länge1 * länge1) + (länge2 * länge2);
                                            länge3 = Math.Pow(zwischenergebnis, 0.5);
                                        }

                                        //Wenn Ankathete leer ist
                                        else if (länge2 == 0)
                                        {
                                            //Ankathete
                                            länge2 = länge1 / verhältnis;

                                            //Hypotenuse
                                            double zwischenergebnis = (länge1 * länge1) + (länge2 * länge2);
                                            länge3 = Math.Pow(zwischenergebnis, 0.5);
                                        }

                                        //Wenn Verhältnis/Winkel leer ist
                                        else
                                        {
                                            //Verhältnis 
                                            verhältnis = länge1 / länge2;

                                            //Winkel ausrechnen
                                            resultat2 = Math.Atan(verhältnis);
                                            winkel = resultat2 * 180 / 3.1415926535897932;

                                            //Hypotenuse
                                            double zwischenergebnis = (länge1 * länge1) + (länge2 * länge2);
                                            länge3 = Math.Pow(zwischenergebnis, 0.5);
                                        }

                                        //Ergebnis Anzeigen
                                        Console.Clear();
                                        Console.WriteLine("Tangens");
                                        Console.WriteLine("");
                                        Console.WriteLine("Ergebnisse:");
                                        Console.WriteLine("");
                                        Console.WriteLine("Gegenkathete: " + länge1);
                                        Console.WriteLine("Ankathete: " + länge2);
                                        Console.WriteLine("Hypotenuse: " + länge3);
                                        Console.WriteLine("Winkel: " + winkel);
                                        Console.WriteLine("Verhältnis: " + verhältnis);
                                        break;

                                    case 13:
                                        Console.Clear();
                                        Console.WriteLine("Geheime Informationen");
                                        Console.WriteLine("");
                                        Console.WriteLine("Sinus = Gegenkathete : Hypothenuse");
                                        Console.WriteLine("Kosinus = Ankathete : Hypothenuse");
                                        Console.WriteLine("Tangens = Gegenkathete : Ankathete");
                                        Console.WriteLine();
                                        Console.WriteLine("Die Ankathete ist die Seite die den Winkel berührt! (Aber nicht die Hypotenuse!)");
                                        Console.WriteLine("Die Gegenkathete ist die Seite die gegenüber von dem Winkel liegt! (Die einzige Seite die den Winkel nicht berührt!)");
                                        Console.WriteLine("Die Hypotenuse ist die längste Seite in dem Dreieck! (Liegt gegenüber von dem 90° Winkel!)");
                                        Console.WriteLine();
                                        Console.WriteLine("z: Zurück");
                                        Console.WriteLine(); 
                                        Console.Write("Eingabe: ");
                                        string eingabezurück = Console.ReadLine();
                                        
                                        goto falscheeingabe;
                                }


                               

                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren12 = Console.ReadLine();
                                if (fortfahren12 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren12);
                                }
                                else
                                    fort4 = Convert.ToString(fortfahren12);

                            } while (fort4 != "f" && beenden != "b");

                            break;

                            //Statistiken
                        case 5:

                            string fort5 = "a";
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Statistik");
                                Console.WriteLine("");
                                Console.WriteLine("Geben Sie alle Werte getrennt mit einem Komma ein:");
                                Console.WriteLine("");

                                string allezahlen = Console.ReadLine();
                              
                                //Werte in dem Array mit Kommas trennen
                                string[] zahlen = allezahlen.Split(',');

                                //Anzahl Zahlen bestimmen (duplikat für runterzählen)
                                int anzahlzahlen = zahlen.Length;
                                int i = anzahlzahlen;

                                //Array für Doublezahlen 
                                double[] doublezahlen;

                                

                                //Für jeden String in dem Array Zahlen(wenn es nicht leer ist): Convertiere zu Double in den Double Array an Stelle 0 - Fertig
                                foreach (string zahl in zahlen)
                                {                                                                    
                                    double convertedValue;

                                    if (!double.TryParse(zahl, out convertedValue))
                                    { 
                                       
                                        anzahlzahlen--;                         
                                        
                                    }
                                   
                                }

                                //Array länge = länge des String Array
                                doublezahlen = new double[anzahlzahlen];

                                int t = 0;
                                foreach (string zahl in zahlen)
                                {
                                    
                                    double convertedValue;

                                    if (!double.TryParse(zahl, out convertedValue))
                                    {
                                        
                                    }
                                    else
                                    {
                                        doublezahlen[t] = Convert.ToDouble(zahl);
                                        t++;
                                    }
                                }

                                //Array Sortieren
                                Array.Sort(doublezahlen);
                                
                                //alle zahlen addiert
                                double zahlenaddiert = 0;

                                //Zahlen zusammenrechnen
                                foreach(double zahl in doublezahlen)
                                {
                                    zahlenaddiert += zahl;
                                }

                                //Variablen für ergebnisse
                                double durchschnitt;
                                double median;
                                double standartabweichung;

                                //Ausrechnen
                                 
                                //Durchschnitt
                                 durchschnitt = zahlenaddiert / anzahlzahlen;


                                //Median
                                median = getMedian(doublezahlen);

                                //Standartabweichung
                                standartabweichung = getStandartabweichung(doublezahlen, durchschnitt);

                                //Ergebnisse
                                Console.Clear();
                                Console.WriteLine("Statistik");
                                Console.WriteLine("");
                                Console.WriteLine("Ergebnisse:");
                                Console.WriteLine("");
                                Console.WriteLine("Summe: " + zahlenaddiert);
                                Console.WriteLine("Durchschnitt: " + durchschnitt);                              
                                Console.WriteLine("Median: " + median);
                                Console.WriteLine("Standartabweichung: " + standartabweichung);
                                Console.WriteLine("Varianz: "+ Math.Pow(standartabweichung, 2));
                                Console.WriteLine("");
                                Console.WriteLine("Anzahlt Werte: " + anzahlzahlen);


                                //Nochmal
                                Console.WriteLine("");
                                Console.WriteLine("w: Wiederholen");
                                Console.WriteLine("f: Fortfahren");
                                Console.WriteLine("b: Beenden");
                                Console.WriteLine("");
                                Console.Write("Eingabe: ");

                                string fortfahren11 = Console.ReadLine();
                                if (fortfahren11 == "b")
                                {
                                    beenden = Convert.ToString(fortfahren11);
                                }
                                else
                                    fort3 = Convert.ToString(fortfahren11);


                            } while (fort5 != "f" && beenden != "b");
                            break;
                    }
                }

                //Zurückgehen und Beenden
                if (beenden == "b")
                {
                    break;
                }
            } while (true);
        }
    }
}