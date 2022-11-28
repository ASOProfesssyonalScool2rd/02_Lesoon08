using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullletScripts : MonoBehaviour
{
    // === メンバ変数>>>

    private Vector3 direction;  //移動方向
    private float Power;　　　　　//移動速度
    public void Initialize()
    { //初期化処理関数
        direction = new Vector3(0, 0, 0);
        Power = 0;
    }
    // === Initialize()のオーバーロード >>>
    public void Initialize(Vector3 direction,float power)
    { //初期化処理関数(パラメーター設定)

        direction = direction;
        power = Power;
        Initialize();//普通のInitialize()を実行
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction*Power*Time.deltaTime);
    }
}
