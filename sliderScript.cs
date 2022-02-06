using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sliderScript : MonoBehaviour
{
    GameObject playerstatus; //Unityちゃんそのものが入る変数
    
    statusScript statusScript;
    public Slider slider;
    public int ok;
    // Start is called before the first frame update
    void Start()
    {
        playerstatus = GameObject.Find("playerstatus"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        statusScript = playerstatus.GetComponent<statusScript>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.maxValue = statusScript.skillvalue;
        slider.value = statusScript.cost1;
    }
    public void Onclick1()
    {
        if (statusScript.skillvalue < statusScript.cost1 )
        {
            Debug.Log("保存されませんでした");

        }
        else
        {
            Debug.Log("保存されました");
            ok = 1;
        }
    }
}

