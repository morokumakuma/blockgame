using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okaneScript : MonoBehaviour
{
    statusScript statusScript;
    GameObject status;
    GameObject playerstatus; //Unityちゃんそのものが入る変数
    // Start is called before the first frame update
    void Start()
    {
        playerstatus = GameObject.Find("playerstatus"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        statusScript = playerstatus.GetComponent<statusScript>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        if (statusScript.money > 0)
        {
           statusScript.originplayerHP++;
           statusScript.money--;
        }

    }
}
