// string message = "What is the value <span>between the tags</span>?";
// 
// const string openSpan = "<span>";
// const string closeSpan = "</span>";
// 
// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);
// 
// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));


// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// 
// int openingPosition = message.LastIndexOf('('); // LastIndexOf()
// int closingPosition = message.LastIndexOf(')');
// 
// openingPosition += 1;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;
// 
//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// 
//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }



//   string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
//   
//   // The IndexOfAny() helper method requires a char array of characters. 
//   // You want to look for:
//   
//   char[] openSymbols = { '[', '{', '(' };
//   
//   // You'll use a slightly different technique for iterating through 
//   // the characters in the string. This time, use the closing 
//   // position of the previous iteration as the starting index for the 
//   // next open symbol.
//   //
//   // So, you need to initialize the closingPosition variable to zero:
//   
//   int closingPosition = 0;
//   
//   while (true)
//   {
//       int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
//   
//       if (openingPosition == -1) break;
//   
//       string currentSymbol = message.Substring(openingPosition, 1);
//   
//       // Now  find the matching closing symbol
//       char matchingSymbol = ' ';
//   
//       switch (currentSymbol)
//       {
//           case "[":
//               matchingSymbol = ']';
//               break;
//           case "{":
//               matchingSymbol = '}';
//               break;
//           case "(":
//               matchingSymbol = ')';
//               break;
//       }
//   
//       // To find the closingPosition, use an overload of the IndexOf method to specify 
//       // that the search for the matchingSymbol should start at the openingPosition in the string. 
//   
//       openingPosition += 1;
//       closingPosition = message.IndexOf(matchingSymbol, openingPosition);
//   
//       // Finally, use the techniques you've already learned to display the sub-string:
//   
//       int length = closingPosition - openingPosition;
//       Console.WriteLine(message.Substring(openingPosition, length));
//   }



// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);
// 
// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);


const string input_message = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Quantity - span
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input_message.IndexOf(openSpan) + openSpan.Length;
int quantityEnd = input_message.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input_message.Substring(quantityStart, quantityLength);
Console.WriteLine($"Quantity: {quantity}");

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input_message.Replace(tradeSymbol, regSymbol);

//  // Output - div - Option 1
//  const string openDiv = "<div>";
//  const string closeDiv = "</div>";
//  
//  int openingPosition = input_message.IndexOf(openDiv) + openDiv.Length;
//  int closingPosition = input_message.IndexOf(closeDiv);
//  int length = closingPosition - openingPosition;
//  output = input_message.Substring(openingPosition, length);
//  Console.WriteLine($"Output: {output}");

// Output - div - Option 2

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(output);