string GetUserInput()
{
    Console.WriteLine("Enter string");
    return Console.ReadLine();
}

void ReversString(string inputStr)
{
    for (var i = inputStr.Length - 1; i >= 0; i--) Console.Write(inputStr[i]);
}

var str = GetUserInput();
ReversString(str);