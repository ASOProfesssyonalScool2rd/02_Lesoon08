using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContlolScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("TargetframeRate 30FPS");
        Application.targetFrameRate = 30;
    }
}
