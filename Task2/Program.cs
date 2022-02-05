Console.WriteLine("Phonebook");

var telBook = new string[5][,]
                  {
                      new[,] { { "name1", "050", "name1@mail.com" } }, 
                      new[,] { { "name2", "051", "name2@mail.com" } },
                      new[,] { { "name3", "052", "name3@mail.com" } }, 
                      new[,] { { "name4", "053", "name4@mail.com" } },
                      new[,] { { "name5", "054", "name5@mail.com" } }
                  };

for (var i = 0; i < telBook.Length; i++)
{
    var userData = string.Empty;
    if (telBook[i] != null && telBook[i].GetType() == typeof(string[,]))
    {
        userData = $"{i + 1}. ";
        for (var j = 0; j < telBook[i].Length; j++) userData += telBook[i][0, j] + " ";
    }
    else
    {
        userData = "record is empty at given index";
    }

    Console.WriteLine(userData);
}