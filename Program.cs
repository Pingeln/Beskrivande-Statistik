﻿using Beskrivande_Statistik;

while (true)
{
    Console.Clear();
    Console.WriteLine(@"Välkommen!
---------------------------------------------
Välj ett alternativ:
1. Presentera uträkning av data.json.
2. Välj en annan json fil att räkna ut ifrån.
3. Generera en json fil med nummer.
4. Ta bort en json fil.
5. Avsluta.
---------------------------------------------");

    int menuChoice;
    while (!int.TryParse(Console.ReadLine(), out menuChoice));

    switch (menuChoice)
    {
        case 1: 
            //Presentera data från data.json
            Presentation_av_data.presentation_av_data(Statistics.DescriptiveStatistics(ReadJsonFile.Deserialize("data.json")));              
            break;
        case 2:
            //Välj json fil och presentera data
            ReadCustomJson.Open();
            break;
        case 3:
            //Skapa en json fil och fyll med data
            UserCreateJson.UserJson();
            break;
        case 4:
            //Ta bort en json fil
            DeleteJson.Delete();
            break;
        case 5:
            //Avsluta Programmet
            Environment.Exit(0);
            break;
        default:
            break;
    }
}