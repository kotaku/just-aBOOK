using UnityEngine;
using UnityEngine.UI;

public class ButtonListener : MonoBehaviour
{
    public Button _button1;
    public Button _button2;
    public Button _button3;
    public Button _button4;
    public Button _button5;
    public Button _button6;
    public Button _button7;
    public Button _button8;

    public Button Settings;

    // Use this for initialization
    void Start()
    {

        _button1.onClick.AddListener(() => Butt_1());
        _button2.onClick.AddListener(() => Butt_2());
        _button3.onClick.AddListener(() => Butt_3());
        _button4.onClick.AddListener(() => Butt_4());
        _button5.onClick.AddListener(() => Butt_5());
        _button6.onClick.AddListener(() => Butt_6());
        _button7.onClick.AddListener(() => Butt_7());
        _button8.onClick.AddListener(() => Butt_8());



        Settings.onClick.AddListener(() => OpenSett());
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void Butt_1()
    {
        OpenScene(0);
    }
    private void Butt_2()
    {
        OpenScene(1);
    }
    private void Butt_3()
    {
        OpenScene(2);
    }
    private void Butt_4()
    {
        OpenScene(3);
    }
    private void Butt_5()
    {
        OpenScene(4);
    }
    private void Butt_6()
    {
        OpenScene(5);
    }
    private void Butt_7()
    {
        OpenScene(6);
    }
    private void Butt_8()
    {
        OpenScene(7);
    }


    private void OpenScene(byte i)
    {
        StaticData.SelectBook = (byte)(i + 1);
        StaticData.CurrPage = i;
        StaticData.Books = null;
        Application.LoadLevel("ReadScreen");
    }

    private void OpenSett()
    {
        Application.LoadLevel("SetingsScreen");
    }
}
