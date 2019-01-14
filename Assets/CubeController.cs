using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    //キューブの移動速度
    private float speed = -0.2f;

    //消滅位置
    private float deadLine = -10;


    //ブロック音
    private AudioSource sound01;



    // Use this for initialization
    void Start () {

        
        //AudioSourceコンポーネントを取得
        sound01 = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {

        //キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        //画面外に出たら破棄する
        if(transform.position.x < this.deadLine){
            Destroy(gameObject);
        }
		
	}

    //音
    void OnCollisionEnter2D(Collision2D collision)
    {

        if((collision.gameObject.tag == "block" )|| (collision.gameObject.tag =="ground")){
            sound01.PlayOneShot(sound01.clip);

        }
        
       


    }
}

