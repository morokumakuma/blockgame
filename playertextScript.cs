using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertextScript : MonoBehaviour
{
    topScript2 topScript; //UnityChanScriptが入る変数
    GameObject playertop; //Unityちゃんそのものが入る変数
    // Start is called before the first frame update
    void Start()
    {
        playertop = GameObject.Find("playertop"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        topScript = playertop.GetComponent<topScript2>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = topScript.PlayerHP.ToString("f0");
    }
}
