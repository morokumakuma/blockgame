using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateScript2 : MonoBehaviour
{
    topScript2 scriptwall; //UnityChanScriptが入る変数
    GameObject player; //Unityちゃんそのものが入る変数
    GameObject topwall2; //Unityちゃんそのものが入る変数
    PlayerScript3 script; //UnityChanScriptが入る変数
    GameObject canvas; //Unityちゃんそのものが入る変数
    public int[] dokonidasuka;
    GameObject enemybox; //Unityちゃんそのものが入る変数
    public GameObject clone2;
    public GameObject clone22;
    public GameObject clone23;
    public GameObject clone24;
    public GameObject clone25;
    public GameObject clone26;
    public GameObject clone27;
    int timer = 1;
    int timer2 = 825;
    int timer3 = 450;
    int timer4 = 10;
    int timer5 = 1000;
    int nankaime = 0;
    // Use this for initialization
    float playerHP;
    void Start()
    {
        timer3 = 125;
        timer = 75;
        timer2 = 900;
        timer5 = 2000;
   

        dokonidasuka = new int[5];
        for(var i = 1; i < 6; i++)
        {
            dokonidasuka[i-1] = i;
        }

        /*InvokeRepeating("generate", 1, 2);
        InvokeRepeating("generate2", 5, 6);*/
        topwall2 = GameObject.Find("playertop"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        canvas = GameObject.Find("iremono"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        enemybox = GameObject.Find("enemybox"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        scriptwall = topwall2.GetComponent<topScript2>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }

    // Update is called once per frame
    void Update()
    {
        if (scriptwall.topwall2 == 0)
        {
            timer2--;
            timer--;
            timer3--;
            timer4--;
            timer5--;
        }

        if (timer == 0)
        {
            Invoke("generate", 0);
            timer = 75;
        }

        if (timer2 == 0)
        {
            Invoke("generate2", 0);
            timer2 = 900;

        }
        if (timer3 == 0)
        {
            Invoke("generate3", 0);
            timer3 = 300;
        }
        if (timer4 == 0)
        {
            Invoke("generate4", 0);
            timer4 = 30;
        }
        if (timer5 == 0)
        {
            Invoke("generate5", 0);
            timer5 = 2000;
        }
    }
    void generate()
    {
        playerHP = scriptwall.PlayerHP;
        if (playerHP > 0)
        {
            nankaime++;
            if (nankaime % 12 != 0)
            {
                for (var i = 0; i < 10; i++)
                {
                    int j = (int)Mathf.Floor(Random.Range(0, 5));
                    int k = (int)Mathf.Floor(Random.Range(0, 5));
                    var kari = dokonidasuka[j];
                    dokonidasuka[j] = dokonidasuka[k];
                    dokonidasuka[k] = kari;

                }
                int p = (int)Mathf.Floor(Random.Range(1, 5));
                for (int i = 0; i < p; i++)
                {
                    Instantiate(clone2.gameObject, new Vector3(-2.3f + dokonidasuka[i] * 0.8f, 10, 0), Quaternion.identity,enemybox.transform);
                    Instantiate(clone24.gameObject, new Vector3(-2.2f + dokonidasuka[i] * 0.8f, 10, 0), Quaternion.identity,enemybox.transform);
                    //Instantiate(clone3.gameObject, new Vector3(-2.5f + i+0.5f, 9, 0), Quaternion.identity);
                }

            }
            
            /*float i = Mathf.Floor(Random.Range(1, 6));
            Instantiate(clone2.gameObject, new Vector3(-2.3f + i * 0.8f, 10, 0), Quaternion.identity);
            Instantiate(clone24.gameObject, new Vector3(-2.2f + i * 0.8f, 10, 0), Quaternion.identity);
            */
            //Instantiate(clone2.gameObject, new Vector3(-2.5f + i-0.5f, 10, 0), Quaternion.identity);
            //Instantiate(clone3.gameObject, new Vector3(-2.5f + i+0.5f, 10, 0), Quaternion.identity);
            //clone.gameObject.GetComponent<countBall>().ballID = i;
        }

    }
    void generate2()
    {

        if (playerHP > 0)
        {
            for (float i = 1; i < 6; i++)
            {
                Instantiate(clone2.gameObject, new Vector3(-2.3f + i * 0.8f, 10, 0), Quaternion.identity,enemybox.transform);
                Instantiate(clone24.gameObject, new Vector3(-2.2f + i * 0.8f, 10, 0), Quaternion.identity,enemybox.transform);
                //Instantiate(clone3.gameObject, new Vector3(-2.5f + i+0.5f, 9, 0), Quaternion.identity);
            }
            {
                float i = Mathf.Floor(Random.Range(2, 6));

                //Instantiate(clone22.gameObject, new Vector3(-2.3f + i * 0.8f - 0.4f, 8, 0), Quaternion.identity);

                //clone.gameObject.GetComponent<countBall>().ballID = i;
            }
        }

    }
    void generate3()
    {
        
        if (playerHP > 0)
        {
            
            
            float i = Mathf.Floor(Random.Range(1, 6));
           
            Instantiate(clone25.gameObject, new Vector3(-2.4f + i * 0.8f, 10, 0), Quaternion.identity);
            //Instantiate(clone2.gameObject, new Vector3(-2.5f + i-0.5f, 10, 0), Quaternion.identity);
            //Instantiate(clone3.gameObject, new Vector3(-2.5f + i+0.5f, 10, 0), Quaternion.identity);
            //clone.gameObject.GetComponent<countBall>().ballID = i;
        }


    }
    void generate4()
    {

        if (playerHP > 0)
        {


            float i =Random.Range(-3.0f, 3.0f);

            Instantiate(clone26.gameObject, new Vector3(i, 10, 2), Quaternion.identity,canvas.transform);
            
        }


    }
    void generate5()
    {

        if (playerHP > 0)
        {


            float i = Random.Range(-3.0f, 3.0f);

            Instantiate(clone27.gameObject, new Vector3(i, 10, 1), Quaternion.identity);

        }


    }
}