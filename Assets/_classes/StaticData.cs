using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class StaticData
{
    private static byte _selectbook;
    private static List<string> _book = new List<string>();
    private static List<string> _books = new List<string>();
    private static List<short> _progress = new List<short>();


    public static List<string> Book
    {
        get { return _book; }
        set { _book = value; }
    }

    public static List<string> Books
    {
        get { return _books; }
        set { _books = value; }
    }

    public static byte SelectBook
    {
        get { return _selectbook; }
        set
        {
            _selectbook = value;
            ProcessBook();
        }
    }
    public static List<short> Progress
    {
        get { return _progress; }
        set { _progress = value; }
    }

    public static int CurrPage { get; set; }




    private static void ProcessBook()
    {
        string temp = LoadBook();

        short symbols = (short)(SetingsData.SymbolsSize * (SetingsData.SymbolsSize + 4) - 1);
        short end;
        int start;

        for (start = 0, end = symbols; start + end < temp.Length;)
        {
            if (temp[end] == ' ' | temp[end] == '\n')
            {
                Book.Add(temp.Substring(start, end));
                start += end;
                end = symbols;
            }
            else
            {
                end--;
            }
        }
        Book.Add(temp.Substring(start));
    }


    public static void SaveProgress()
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string fileName = "data:/001";
        FileStream file = File.Create(fileName);
        binaryFormatter.Serialize(file, Progress);
        file.Close();
    }


    public static bool LoadProgress()
    {
        bool temp = false;

        if (File.Exists("data:/001"))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = File.Open("data:/001", FileMode.Open, FileAccess.Read);
            Progress = ((List<short>)binaryFormatter.Deserialize(file));
            file.Close();

            temp = true;
        }
        return temp;
    }


    public static string LoadBook()
    {
        string temp = string.Format("data:/00{0}", SelectBook), bookT;

        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream file = File.Open(temp, FileMode.Open, FileAccess.Read);
        bookT = (string)binaryFormatter.Deserialize(file);
        file.Close();

        return bookT;
    }
}
