using UnityEngine;

public class SetingsLoader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (!SetingsData.Load())
        {

            SetingsData.TextColour = TextColour.White.TextColour;
            SetingsData.BackgroundColour = TextColour.White.BackgroundColour;
            SetingsData.TextPosition = TextPosition.Right.RightToLeft_Z;
            SetingsData.Previous = TextPosition.Right.Previous;
            SetingsData.Next = TextPosition.Right.Next;
            SetingsData.BigPrevious = TextPosition.Right.BigPrevious;
            SetingsData.BigNext = TextPosition.Right.BigNext;
            SetingsData.FontSize = FontSizes.S.Font;
            SetingsData.SymbolsSize = FontSizes.S.Symbols;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
