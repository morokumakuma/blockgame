using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightScript2 : MonoBehaviour
{
    GameObject topwall2; //Unityちゃんそのものが入る変数
    EnemyScript2 enemyScript;
    topScript2 scriptwall; //UnityChanScriptが入る変数
    kaihukuScript KaihukuScript; //UnityChanScriptが入る変数
    public int leftwall2;
    public int rightwall2;
    private Vector3 SPEED = new Vector3(0, 0.2f, 0);
    private Vector3 SPEED2 = new Vector3(0.2f, 0, 0);
    private Vector3 SPEED3 = new Vector3(-0.2f, 0, 0);
    public bool wall = true;
    public float rightHP;
    GameObject player; //Unityちゃんそのものが入る変数
    int abc;
    int mmm;
    public Vector3 Vecright;
    // Start is called before the first frame update
    void Start()
    {
        mmm = 100;
        player = GameObject.Find("Player"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        topwall2 = GameObject.Find("playertop"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        scriptwall = topwall2.GetComponent<topScript2>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "top")
        {
            transform.position = player.transform.position + SPEED;
        }
        if (tag == "right")
        {
            transform.position = player.transform.position + SPEED2;
        }
        if (tag == "left")
        {
            transform.position = player.transform.position + SPEED3;
        }
        if (abc == 1)
        {
            mmm--;
        }
        if (mmm == 0)
        {
            rightHP = 0;
            abc = 0;
            mmm = 100;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {


        if (col.tag == "wall" || col.tag == "Enemy")
        {
            if (tag == "top")
            {


            }
            if (tag == "left")
            {
                leftwall2 = 1;

            }
            if (tag == "right")
            {
                /*Vecright = this.transform.position;
                rightwall2 = 1;*/
                rightHP = col.GetComponent<EnemyScript2>().tekiHP;

                scriptwall.PlayerHP += rightHP;
                rightHP = 0;
            }



        }
        if (col.tag == "kaihuku")
        {
            KaihukuScript = col.GetComponent<kaihukuScript>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
            rightHP = KaihukuScript.portionHP;
            scriptwall.PlayerHP += rightHP;
            rightHP = 0;
            //abc = 1;
            
        }

    }
    void OnTriggerExit2D(Collider2D col)
    {


        if (col.tag == "wall" || col.tag == "Enemy")
        {
            if (tag == "top")
            {
            }
            if (tag == "left")
            {
                leftwall2 = 0;
              
            }
            if (tag == "right")
            {
                rightwall2 = 0;
                
            }



        }

    }
}
