using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sthickScript2 : MonoBehaviour
{
    topScript2 scriptwall; //UnityChanScriptが入る変数
    GameObject topwall2; //Unityちゃんそのものが入る変数
    
    
    GameObject player; //Unityちゃんそのものが入る変数
    
    PlayerScript2 script; //UnityChanScriptが入る変数
    public float speed = 3.5f;
    Rigidbody2D e_rigidbody2D;
    public float playerHP2;
    
    // Start is called before the first frame update
    void Start()
    {
        e_rigidbody2D = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        script = player.GetComponent<PlayerScript2>();
        topwall2 = GameObject.Find("playertop"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        scriptwall = topwall2.GetComponent<topScript2>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Position = transform.position;
        if (Position.y < -10.0)
        {
            Destroy(gameObject);
        }
        playerHP2 = scriptwall.PlayerHP; //新しく変数を宣言してその中にUnityChanScriptの変数HPを代入する

        if (playerHP2 <= 0)
        {
            e_rigidbody2D.velocity = new Vector2(0, 0);
        }
        else
        {
            if (scriptwall.topwall2 == 0)
            {
                e_rigidbody2D.velocity = new Vector2(e_rigidbody2D.velocity.x, -speed);
            }
            else
            {
                e_rigidbody2D.velocity = new Vector2(0, 0);
            }

        }
    }

}

