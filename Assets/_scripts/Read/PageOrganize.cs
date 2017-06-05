using UnityEngine;
using UnityEngine.UI;
using UnityEngine.N3DS;
using System.Collections.Generic;

public class PageOrganize : MonoBehaviour
{
    private List<string> _text;
    private short _upNumber;
    private short _lowNumber;
    private N3dsButton _previous;
    private N3dsButton _next;
    private N3dsButton _bigPrevious;
    private N3dsButton _bigNext;

    private bool isRight;

    public GameObject UpperUI;
    public GameObject LowerUI;
    public Camera UpperCamera;
    public Camera LowerCamera;
    public Text UpperTextLink;
    public Text LowerTextLink;
    public Text CurrPage;
    public Text Time;



    // Use this for initialization
    void Start()
    {
        _text = StaticData.Book;

        _previous = SetingsData.Previous;
        _next = SetingsData.Next;
        _bigPrevious = SetingsData.BigPrevious;
        _bigNext = SetingsData.BigNext;
        UpperUI.transform.rotation = Quaternion.Euler(0, 0, SetingsData.TextPosition);
        LowerUI.transform.rotation = Quaternion.Euler(0, 0, SetingsData.TextPosition);

        UpperCamera.backgroundColor = SetingsData.BackgroundColour;
        LowerCamera.backgroundColor = SetingsData.BackgroundColour;
        UpperTextLink.color = SetingsData.TextColour;
        LowerTextLink.color = SetingsData.TextColour;
        CurrPage.color = SetingsData.TextColour;
        Time.color = SetingsData.TextColour;

        UpperTextLink.fontSize = SetingsData.FontSize;
        LowerTextLink.fontSize = SetingsData.FontSize;

        isRight = true;
        if (SetingsData.TextPosition != 0)
        {
            isRight = false;
        }


        _upNumber = StaticData.Progress[StaticData.CurrPage];
        _lowNumber = (short)(_upNumber + 1);
        SetPages();

        CurrPage.text = string.Format("{0} - {1} - {2}", _upNumber + 1, _text.Count - 1, _lowNumber + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (GamePad.GetButtonRelease(_previous))
        {
            SwithThePage(-2);
        }

        if (GamePad.GetButtonRelease(_next))
        {
            SwithThePage(2);
        }

        if (GamePad.GetButtonRelease(_bigPrevious))
        {
            SwithThePage(-10);
        }

        if (GamePad.GetButtonRelease(_bigNext))
        {
            SwithThePage(10);
        }

        if (GamePad.GetButtonRelease(N3dsButton.Start))
        {
            StaticData.Progress[StaticData.CurrPage] = _upNumber;
            StaticData.SaveProgress();
            StaticData.Books = null;
            UnityEngine.Application.LoadLevel("MainScene");
        }
    }

    private void SwithThePage(sbyte param)
    {
        _upNumber += param;
        _lowNumber += param;

        if (_upNumber < 0)
        {
            _upNumber = 0;
            _lowNumber = 1;
        }
        else if (_upNumber >= _text.Count - 1)
        {
            _upNumber = (short)(_text.Count - 2);
            _lowNumber = (short)(_text.Count - 1);
        }

        SetPages();

        CurrPage.text = string.Format("{0} - {1} - {2}", _upNumber + 1, _text.Count - 1, _lowNumber + 1);
    }

    private void SetPages()
    {
        if (isRight)
        {
            UpperTextLink.text = _text[_upNumber];
            LowerTextLink.text = _text[_lowNumber];
        }
        else
        {
            UpperTextLink.text = _text[_lowNumber];
            LowerTextLink.text = _text[_upNumber];
        }
    }
}
