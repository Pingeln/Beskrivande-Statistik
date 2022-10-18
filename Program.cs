﻿using Beskrivande_Statistik;

while (true)
{
    

    
    
    //typvärde och median en skriver ej ut rätt

    int[] temp = DeserializeJson.Deserialize();
    Console.WriteLine("Maximum: " + Statistics.Maximum(temp));
    Console.WriteLine("Minimum: " + Statistics.Minimum(temp));
    Console.WriteLine("Medelvärde: " + Statistics.Mean(temp));
    Console.WriteLine("Median: " + Statistics.Median(temp));
    Console.WriteLine("Typvärde: " + Statistics.Mode(temp));
    Console.WriteLine("Variationsbredd: " + Statistics.Range(temp));
    Console.WriteLine("Standardavvikelse: "+Statistics.StandardDeviation(temp));

    int menuChoice;
    Console.WriteLine("Välkommen!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("Välj ett alternativ: ");
    Console.WriteLine("1. Presentera uträkning av data.json.");
    Console.WriteLine("2. Välj en annan json fil att räkna ut ifrån");
    Console.WriteLine("3. Generera en json fil med nummer.");
    Console.WriteLine("4. Avsluta");
    Console.WriteLine("--------------------------------------------");
    
    
    while (!int.TryParse(Console.ReadLine(), out menuChoice));
    switch (menuChoice)
    {
        case 1:
            //Presentera data
            break;
        case 2:
            //Välj json fil och presentera data
            break;
        case 3:
            //Skapa en json fil och fyll med data
            break;
        default:
            break;
    }
    if (menuChoice == 4)
        break;
}
