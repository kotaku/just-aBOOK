using UnityEngine;
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public static class SetingsData
{
    public static Color TextColour { get; set; }
    public static Color BackgroundColour { get; set; }
    private static string TColourSer { get; set; }
    private static string BColourSer { get; set; }
    public static float TextPosition { get; set; }
    public static N3dsButton Previous { get; set; }
    public static N3dsButton Next { get; set; }
    public static N3dsButton BigPrevious { get; set; }
    public static N3dsButton BigNext { get; set; }
    public static byte FontSize { get; set; }
    public static byte SymbolsSize { get; set; }



    public static void Save()
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string fileName = "data:/000";
        FileStream file = File.Create(fileName);
        binaryFormatter.Serialize(file, GetList());
        file.Close();
    }


    public static bool Load()
    {
        bool temp = false;

        if (File.Exists("data:/000"))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = File.Open("data:/000", FileMode.Open, FileAccess.Read);
            SetList((ArrayList)binaryFormatter.Deserialize(file));
            file.Close();

            temp = true;
        }
        return temp;
    }


    private static ArrayList GetList()
    {
        TColourSer = TextColour.r.ToString() + "," + TextColour.b.ToString() + "," + TextColour.g.ToString();
        BColourSer = BackgroundColour.r.ToString() + "," + BackgroundColour.b.ToString() + "," + BackgroundColour.g.ToString();

        return new ArrayList { TColourSer, BColourSer, TextPosition, Previous, Next, BigPrevious, BigNext, FontSize, SymbolsSize };
    }
    private static void SetList(ArrayList list)
    {
        string[] temp = ((string)list[0]).Split(',');
        TextColour = new Color(Convert.ToSingle(temp[0]), Convert.ToSingle(temp[1]), Convert.ToSingle(temp[2]));
        temp = ((string)list[1]).Split(',');
        BackgroundColour = new Color(Convert.ToSingle(temp[0]), Convert.ToSingle(temp[1]), Convert.ToSingle(temp[2]));
        TextPosition = (float)list[2];
        Previous = (N3dsButton)list[3];
        Next = (N3dsButton)list[4];
        BigPrevious = (N3dsButton)list[5];
        BigNext = (N3dsButton)list[6];
        FontSize = (byte)list[7];
        SymbolsSize = (byte)list[8];
    }
}
