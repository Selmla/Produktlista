
List<string> productNumbers = new List<string>();

while (true)
{
    Console.Write("Vänligen ange ett nytt produktnummer: ");

    var userInput = Console.ReadLine();


    if (string.IsNullOrWhiteSpace(userInput))
    {
        Console.WriteLine("Ogiltig inmatning. Försök igen.");
        continue;
    }
    else if (userInput.Trim().ToLower() == "exit") //ha denna manipulationen utanför kanske
    {
        break;
    }
    else
    {
        string sanitizedInput = userInput.Trim().ToUpper(); // bygga ut denna
        bool isValid = Validate(sanitizedInput);

        if (isValid)
        {
            productNumbers.Add(sanitizedInput);
        }
    }

}

bool Validate(string sanitizedInput) //hantera edgecase om första delen är tom tex
{
    var parts = sanitizedInput.Split('-');

    if (parts.Length == 2)
    {
        string namePart = parts[0];
        string numberPart = parts[1];
        string errorMessageLeftPart = "Felaktigt format på vänstra delen av produktnamnet.";

        if (string.IsNullOrWhiteSpace(namePart))
        {
            Console.WriteLine(errorMessageLeftPart);
            return false;
        }

        foreach (char c in namePart)
        {
            if (!char.IsLetter(c))
            {
                Console.WriteLine(errorMessageLeftPart);
                return false;
            }
        }

        if (!int.TryParse(numberPart, out int number))
        {
            Console.WriteLine("Felaktigt format på högra delen av produktnumret");
            return false;
        }
        else if (number < 200 || number > 500)
        {
            Console.WriteLine("Den numeriska delen måste vara mellan 200-500");
            return false;
        }
    }
    else
    {
        Console.WriteLine("Felaktigt format. Ange produktnamn som TEXT-NUMMER.");
        return false;
    }

    return true;
}

productNumbers.Sort();

Console.WriteLine("Din sorterade produktlista:");
foreach (string product in productNumbers)
{
    Console.WriteLine(product);
}