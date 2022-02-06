using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class titleScript : MonoBehaviour
{
    GameObject playerstatus; //Unityちゃんそのものが入る変数

    statusScript statusScript;
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
        SceneManager.LoadScene("status");
        statusScript.sss = 0;

    }
}
