using UnityEngine;
using UnityEngine.UI;


public class Setings : MonoBehaviour
{
    public Toggle White;
    public Toggle Sepia;
    public Toggle Night;

    public Toggle Right;
    public Toggle Left;

    public Toggle S;
    public Toggle M;
    public Toggle L;
    public Toggle XL;


    public Button Back;


    // Use this for initialization
    void Start()
    {
        White.onValueChanged.AddListener((bool value) => ColourChWhite(White.isOn));
        Sepia.onValueChanged.AddListener((bool value) => ColourChSepia(Sepia.isOn));
        Night.onValueChanged.AddListener((bool value) => ColourChNight(Night.isOn));

        Right.onValueChanged.AddListener((bool value) => PositionChRight(Right.isOn));
        Left.onValueChanged.AddListener((bool value) => PositionChLeft(Left.isOn));

        S.onValueChanged.AddListener((bool value) => SizeChS(S.isOn));
        M.onValueChanged.AddListener((bool value) => SizeChM(M.isOn));
        L.onValueChanged.AddListener((bool value) => SizeChL(L.isOn));
        XL.onValueChanged.AddListener((bool value) => SizeChXL(XL.isOn));


        Back.onClick.AddListener(() => Save());
    }


    // Update is called once per frame
    void Update()
    {
    }


    private void ColourChWhite(bool value)
    {
        SetingsData.TextColour = TextColour.White.TextColour;
        SetingsData.BackgroundColour = TextColour.White.BackgroundColour;
    }
    private void ColourChSepia(bool value)
    {
        SetingsData.TextColour = TextColour.Sepia.TextColour;
        SetingsData.BackgroundColour = TextColour.Sepia.BackgroundColour;
    }
    private void ColourChNight(bool value)
    {
        SetingsData.TextColour = TextColour.Night.TextColour;
        SetingsData.BackgroundColour = TextColour.Night.BackgroundColour;
    }


    private void PositionChRight(bool value)
    {
        SetingsData.TextPosition = TextPosition.Right.RightToLeft_Z;
        SetingsData.Previous = TextPosition.Right.Previous;
        SetingsData.Next = TextPosition.Right.Next;
        SetingsData.BigPrevious = TextPosition.Right.BigPrevious;
        SetingsData.BigNext = TextPosition.Right.BigNext;

    }
    private void PositionChLeft(bool value)
    {
        SetingsData.TextPosition = TextPosition.Left.LeftToRight_Z;
        SetingsData.Previous = TextPosition.Left.Previous;
        SetingsData.Next = TextPosition.Left.Next;
        SetingsData.BigPrevious = TextPosition.Left.BigPrevious;
        SetingsData.BigNext = TextPosition.Left.BigNext;
    }


    private void SizeChS(bool value)
    {
        SetingsData.FontSize = FontSizes.S.Font;
        SetingsData.SymbolsSize = FontSizes.S.Symbols;
    }
    private void SizeChM(bool value)
    {
        SetingsData.FontSize = FontSizes.M.Font;
        SetingsData.SymbolsSize = FontSizes.M.Symbols;
    }
    private void SizeChL(bool value)
    {
        SetingsData.FontSize = FontSizes.L.Font;
        SetingsData.SymbolsSize = FontSizes.L.Symbols;
    }
    private void SizeChXL(bool value)
    {
        SetingsData.FontSize = FontSizes.XL.Font;
        SetingsData.SymbolsSize = FontSizes.XL.Symbols;
    }


    private void Save()
    {
        SetingsData.Save();
        Application.LoadLevel("MainScene");
    }
}
