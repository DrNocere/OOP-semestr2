﻿namespace lab_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            DataReader myNode = new("D:/test/");

            myNode.PrintNode();
            /*OrderByNameAndSize byName = new(myNode.files);
            byName.PrintByName();
            byName.PrintBySize();
            OrderByFirstLetter byFirstLetter = new(myNode.files);
            byFirstLetter.PrintByFirstLetter();
            ByTypes byTypes = new(myNode.files);
            byTypes.Print();
            */
        }
    }
}