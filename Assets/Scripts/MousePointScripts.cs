using UnityEngine;
public class MousePointScripts : MonoBehaviour
{
    public Vector3 screenmousepoint;
    
    public Vector3 wordmousepoint;

    public GameObject bulletprefab;

    private float movespeed = 5;
    // Start is called before the first frame update
    void Start()
    {
　　　　　        
    }
    // Update is called once per frame
    void Update()
    {
        screenmousepoint = Input.mousePosition;
        screenmousepoint.z = 0;
        
            wordmousepoint = Camera.main.ScreenToViewportPoint(screenmousepoint);
            screenmousepoint.z = 0;
            //ポインターの座標にワールド座標を代入
            transform.position = wordmousepoint;
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 20;
        string log = "スクリーン" + screenmousepoint + "\nワールド" + wordmousepoint;
        GUI.Label(new Rect(0, 0, 200, 300), log, style);
        
    }
}
