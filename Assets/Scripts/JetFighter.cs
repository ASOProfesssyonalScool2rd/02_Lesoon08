using UnityEngine;

public class JetFighter : MonoBehaviour
{
    public GameObject BulletPrefub; //プレファブのデータ
    private float DeltaSpeed = 2;  //移動速度の基本値
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0,DeltaSpeed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(DeltaSpeed*Time.deltaTime,0,0); 
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,0,-DeltaSpeed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-DeltaSpeed*Time.deltaTime,0,0);
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 shortpoint = transform.position;
            GameObject clone = Instantiate(BulletPrefub, shortpoint, transform.rotation);
            clone.GetComponent<BullletScripts>().Initialize();
        }

        
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(-90*Time.deltaTime, 0, 0);
            Debug.Log("HeloWord!!");
        }
        else
        {
            transform.Rotate(90*Time.deltaTime, 0, 0);
            Debug.Log("ReturnHeloWord!!");
        }
    }
}
