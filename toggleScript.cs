using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleScript : MonoBehaviour
{
    GameObject slider; //Unityちゃんそのものが入る変数

    sliderScript sliderScript;
    GameObject playerstatus; //Unityちゃんそのものが入る変数
    public int cost;
    statusScript statusScript;
    public int rank;
    int doko;
    Vector3 ebi;
    // Start is called before the first frame update
    void Start()
    {
        cost = 0;
        rank = 0;
        playerstatus = GameObject.Find("playerstatus"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        statusScript = playerstatus.GetComponent<statusScript>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
        slider = GameObject.Find("Slider"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        sliderScript = slider.GetComponent<sliderScript>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
        //this.transform.position  = new Vector3(27, 166 - statusScript.sss * 18, 0);
        
        ebi = new Vector3(24, 240 - statusScript.sss * 18, 0);
        this.GetComponent<RectTransform>().anchoredPosition3D = ebi;
        doko = statusScript.sss;
        statusScript.sss++;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (sliderScript.ok >= 1)
        {
            if (GetComponent<Toggle>().isOn == true)
            {
                statusScript.basyo[doko] = 1;
                sliderScript.ok++;
                
            }
            else
            {
                statusScript.basyo[doko] = 0;
            }
                
        }
       
    }
    public void OnClick()
    {
        if(GetComponent<Toggle>().isOn == true)
        {
            if(statusScript.skillvalue < statusScript.cost1 + cost)
            {
                statusScript.cost1 += cost;
                
            }
            else
            {
                statusScript.cost1 += cost;
            }
            
            
        }else if (GetComponent<Toggle>().isOn == false)
        {
            statusScript.cost1 -= cost;
        }

    }
    


    }
