using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class levelupScript : MonoBehaviour
{
    GameObject top; //Unityちゃんそのものが入る変数
    topScript2 topScript;
    float originkeikenti;
    public Slider slider;		// シーンに配置したSlider格納用

    // Start is called before the first frame update
    void Start()
    {
        top = GameObject.Find("playertop"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        topScript = top.GetComponent<topScript2>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
    }

    // Update is called once per frame
    void Update()
    {
        //originkeikenti = topScript.keikenti;
        originkeikenti = topScript.PlayerHP;
        //slider.maxValue = topScript.hituyoukeikennti[topScript.j];
        slider.maxValue = 10;
        slider.value = originkeikenti;	// Sliderの初期状態を設定（HP満タン）
        
    }
    
}
