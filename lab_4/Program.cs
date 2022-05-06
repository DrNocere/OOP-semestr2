namespace lab_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataReader myDir = new("D:/test/");

            myDir.PrintNodes();
            Console.WriteLine("Files:");
            ByType byType = new ByType(myDir.FilesList);
            byType.Print();
            ByExtensions byExtensions = new ByExtensions(myDir.FilesList);
            byExtensions.Print();
            BySize bySize = new BySize(myDir.FilesList);
            bySize.Print();
            CByLetters cByLetters = new CByLetters(myDir.FilesList);
            cByLetters.Print();
            OByName oByName = new OByName(myDir.FilesList);
            oByName.Print();
            OBySize oBySize = new OBySize(myDir.FilesList);
            oBySize.Print();
        }
    }
}