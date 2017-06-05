using UnityEngine;


public class ProgressLoader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (!StaticData.LoadProgress())
        {
            for (int i = 0; i < 8; i++)
            {
                StaticData.Progress.Add(0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
