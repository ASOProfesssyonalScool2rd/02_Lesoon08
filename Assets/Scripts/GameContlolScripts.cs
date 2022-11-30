using UnityEngine;

public class GameContlolScripts : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Debug.Log("TargetframeRate 30FPS");
        Application.targetFrameRate = 30;
    }
}
