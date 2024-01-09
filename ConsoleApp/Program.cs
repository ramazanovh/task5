Create.Directory(@".\DataBase");

if (!File.Exists(@".\DataBase\info.txt"))
{
    File.Create(@".\DataBase\info.txt");
}
bool isContinue = true;
while (isContinue)
{
    Console.WriteLine("\n1)Product yarat");
    Console.WriteLine("2)Product u goster");
    Console.WriteLine("--------------------");
    Console.WriteLine("0)Cixmaq\n");
    Console.WriteLine("\nChoose an option:\n");

    string? option = Console.ReadLine();
    int intOption;
    bool isInt = int.TryParse(option, out intOption);
    if (isInt)
    {
        if (intOption >= 0 && intOption <= 2)
        {
            switch (intOption)
            {
                case (int)ConsoleApp.Create:
                    Console.WriteLine("Mehsulun ID ni daxil edin");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mehsulun Adini daxil edin");
                    string? name = Console.ReadLine();
                    Console.WriteLine("Mehsulun qiymetini daxil edin");
                    decimal price = Convert.ToDecimal(Console.ReadLine());
                    StreamWriter sw = new StreamWriter(@".\DataBase\product.txt", true);
                    sw.WriteLine($"Id:{id}, Name: {product.Name}, Price {product.Price}");
                    sw.Close();
                    break;
                case (int)ConsoleApp.GetAll:
                    StreamReader sr = new StreamReader(@".\DataBas\product.txt");
                    Console.WriteLine(sr.ReadToEnd());
                    break;
                case (int)ConsoleApp.Exit:
                    isContinue = true;
                    break;
            }
        }
    }
}