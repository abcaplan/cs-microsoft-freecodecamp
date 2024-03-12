// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// // Sort Array Values in alphabetical order
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// // Reverse Elements from Lenght Array - 1 to 0
// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// 
// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
// 
// pallets[4] = "C01";
// pallets[5] = "C02";
// 
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
// 
// // This removes last 3 elements, not first 3
// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
// 
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);
// 
// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }


//  string pangram = "The quick brown fox jumps over the lazy dog";
//  
//  // Split pangram string
//  string[] message = pangram.Split(' ');
//  
//  // Store a reversed copy of the "word" string
//  string[] newMessage = new string[message.Length];
//  
//  // Reverse, then combine the char array into a new string, then store
//  for (int i = 0; i < message.Length; i++)
//  {
//      char[] letters = message[i].ToCharArray();
//      Array.Reverse(letters);
//      newMessage[i] = new string(letters);
//  }
//  
//  string result = String.Join(" ", newMessage);
//  Console.WriteLine(result);


// Complete a challenge to parse a string of orders, sort the orders and tag possible errors
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine($"{item}\t- Error");
    }
}

