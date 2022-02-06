using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyScript : MonoBehaviour
{
    statusScript statusScript;
    GameObject playerstatus;
    // Start is called before the first frame update
    void Start()
    {
        playerstatus = GameObject.Find("playerstatus"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        statusScript = playerstatus.GetComponent<statusScript>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = statusScript.money.ToString("f0");
    }
}
