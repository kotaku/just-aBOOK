using UnityEngine;
using UnityEngine.UI;


public class TimeOrganize : MonoBehaviour
{
    public Text _time;

    // Use this for initialization
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        _time.text = System.DateTime.Now.ToString("H:mm");
    }
}
