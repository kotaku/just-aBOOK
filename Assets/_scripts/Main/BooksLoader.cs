using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class BooksLoader : MonoBehaviour
{
    public Button _button1;
    public Button _button2;
    public Button _button3;
    public Button _button4;
    public Button _button5;
    public Button _button6;
    public Button _button7;
    public Button _button8;


    // Use this for initialization
    void Start()
    {

        StaticData.Books = GetBooks();

        _button1.GetComponentInChildren<Text>().text = StaticData.Books[0];
        _button2.GetComponentInChildren<Text>().text = StaticData.Books[1];
        _button3.GetComponentInChildren<Text>().text = StaticData.Books[2];
        _button4.GetComponentInChildren<Text>().text = StaticData.Books[3];
        _button5.GetComponentInChildren<Text>().text = StaticData.Books[4];
        _button6.GetComponentInChildren<Text>().text = StaticData.Books[5];
        _button7.GetComponentInChildren<Text>().text = StaticData.Books[6];
        _button8.GetComponentInChildren<Text>().text = StaticData.Books[7];
    }

    // Update is called once per frame
    void Update()
    {
    }


    public static List<string> GetBooks()
    {
        string temp;

        List<string> _books = new List<string>();
        for (int i = 1; i <= 8; i++)
        {
            temp = string.Format("data:/00{0}", i);

            if (File.Exists(temp))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream file = File.Open(temp, FileMode.Open, FileAccess.Read);
                StaticData.Books = (List<string>)binaryFormatter.Deserialize(file);
                file.Close();
            }
        }

        return _books;
    }
}
