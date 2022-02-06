using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVtextScript : MonoBehaviour
{
    GameObject top; //Unityちゃんそのものが入る変数
    topScript2 topScript;
    // Start is called before the first frame update
    void Start()
    {

        top = GameObject.Find("playertop"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        topScript = top.GetComponent<topScript2>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = "LV." + topScript.playerLV.ToString("f0");
    }
}
