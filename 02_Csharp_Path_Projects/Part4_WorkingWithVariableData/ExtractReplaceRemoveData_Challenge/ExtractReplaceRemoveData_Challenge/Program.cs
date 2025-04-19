const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

//outputs 5000
char[] fiveChar = { '5'};
int index = input.IndexOfAny(fiveChar);
int newOpeningPostion = input.LastIndexOf("5");
int newClosingPosition = input.LastIndexOf("0");
newClosingPosition += 1;
int intQuantity = newClosingPosition - newOpeningPostion;
Console.WriteLine($"Quantity: {input.Substring(newOpeningPostion, intQuantity)}");


//Outputs altered HTML with trade and reg synbols
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);


Console.WriteLine(output);
