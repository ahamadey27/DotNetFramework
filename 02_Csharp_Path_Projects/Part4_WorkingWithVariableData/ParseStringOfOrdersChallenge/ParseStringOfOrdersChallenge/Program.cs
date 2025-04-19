//Data comes in many formats. In this challenge you have to parse the individual "Order IDs", and
//output the "OrderIDs" sorted and tagged as "Error" if they aren't exactly four characters in length.

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIds = orderStream.Split(',');
Array.Sort(orderIds);

foreach(var orderID in orderIds)
{
    if (orderID.Length == 4)
    {
        Console.WriteLine(orderID);
    }
    else
    {
        Console.WriteLine(orderID + "\t- Error");
    }

}

