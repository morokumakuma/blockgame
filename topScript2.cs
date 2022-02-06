using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class topScript2 : MonoBehaviour
{
    statusScript statusScript;
    gamestatusScript statusScript2;
    rightScript2 rightScript;
    leftScript2 leftScript;
    kaihukuScript KaihukuScript; //UnityChanScriptが入る変数
    public int topwall2;
    public int leftwall2;
    public int rightwall2;
    private Vector3 SPEED = new Vector3(0, -0.1f, 0);
    private Vector3 SPEED2 = new Vector3(0.4f, 0, 0);
    private Vector3 SPEED3 = new Vector3(-0.4f, 0, 0);
    public float PlayerHP = 5;
    GameObject player; //Unityちゃんそのものが入る変数
    GameObject playerstatus; //Unityちゃんそのものが入る変数
    GameObject right; //Unityちゃんそのものが入る変数
    GameObject left; //Unityちゃんそのものが入る変数
    GameObject GM;
    EnemyScript2 enemyScript;
    public float kaisuu;
    public float kaisuu2;
    int abc;
    int ABC;
    public float keikenti;
    public float[] hituyoukeikennti;
    
    int keikenntitable;
    public int j;
    public int playerLV;
    public float[,,] dropitem ;
    public int syurui;
    public int dropkakunin;

    // Start is called before the first frame update
    void Start()
    {
        
        syurui = 5;
        player = GameObject.Find("Player"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        //right = GameObject.Find("playerright"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        //rightScript = right.GetComponent<rightScript2>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
        //GM = GameObject.Find("GM"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        //statusScript2 = GM.GetComponent<gamestatusScript>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
        //left = GameObject.Find("playerleft"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        //leftScript = left.GetComponent<leftScript2>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
        playerstatus = GameObject.Find("playerstatus"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        statusScript = playerstatus.GetComponent<statusScript>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
        PlayerHP = statusScript.originplayerHP +statusScript.plusHP;
        keikenntitable = 20;
        hituyoukeikennti = new float[keikenntitable];
        playerLV = 1;
        for (int i = 0; i < keikenntitable; i++)
        {
            hituyoukeikennti[i] = Mathf.Floor((i + 10)*1.2f);
            
        }
        dropitem = new float[syurui, 3,3];
        if (statusScript.yyy == 1)
        {
            dropitem = statusScript.drop;
        }
        
            
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (hituyoukeikennti[j] <=keikenti )
        {
            keikenti -= hituyoukeikennti[j];
            j++;
            playerLV++;
        }
        
        
        
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
        /*if(rightScript.rightHP != 0)
        {
            if (kaisuu == 0)
            {
                PlayerHP += rightScript.rightHP;
                kaisuu++;
            }
        }*/
        if (kaisuu == 1)
        {
            abc++;
        }
        if (abc == 100)
        {
            kaisuu = 0;
            abc = 0;
        }

        /*if (leftScript.leftHP != 0)
        {
            if (kaisuu2 == 0)
            {
                PlayerHP += leftScript.leftHP;
                kaisuu2++;
            }
        }*/
        if (kaisuu2 == 1)
        {
            ABC++;
        }
        if (ABC == 100)
        {
            kaisuu2 = 0;
            ABC = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "kaihuku")
        {
            KaihukuScript = col.GetComponent<kaihukuScript>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
            PlayerHP += KaihukuScript.portionHP;
            
        }
        
        if (col.tag == "Enemy")
        {

            enemyScript  = col.GetComponent<EnemyScript2>();
            PlayerHP+= enemyScript.tekiHP;
            keikenti += enemyScript.tekiHP;
            //ドロップアイテム
            int a = Random.Range(0, syurui);
            int b = Random.Range(0, 100);
            int c = Random.Range(0, 100);
            int d = Random.Range(0, 100);
            
            if (c <= 10)
            {
                if (b <= 10)
                {
                    b = 0;
                }
                else if (b <= 40)
                {
                    b = 1;
                }
                else
                {
                    b = 2;
                }

                if (d <= 10)
                {
                    d = 0;
                }else if (d<=40)
                {
                    d = 1;
                }
                else if (d <= 100)
                {
                    d = 2;
                }
                Debug.Log("drop");
                dropitem[a, b,d] += 1;
                
            }
            else if (c <= 100)
            {
                statusScript.money++;
            }
            
            
            if(PlayerHP <= 0)
            {
                Debug.Log("sww");
                dropkakunin = 1;
                statusScript.yyy = 1;
                SceneManager.LoadScene("status");
            }
        }
        if ( col.tag == "Enemy")
        {
            if (tag == "top")
            {
                topwall2 = 1;

                
            }
            if (tag == "left")
            {
                leftwall2 = 1;

            }
            if (tag == "right")
            {
                rightwall2 = 1;

            }
            topwall2 = 0;


        }
        if (col.tag == "wall" )
        {
            if (tag == "top")
            {
                topwall2 = 1;


            }
            if (tag == "left")
            {
                leftwall2 = 1;

            }
            if (tag == "right")
            {
                rightwall2 = 1;

            }
            


        }

    }

    void OnTriggerExit2D(Collider2D col)
    {


        if (col.tag == "wall" || col.tag == "Enemy")
        {
            if (tag == "top")
            {
                topwall2 = 0;
                
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
