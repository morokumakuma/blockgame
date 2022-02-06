using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lavelScript : MonoBehaviour
{
    GameObject obj;
    Text score_text;
    toggleScript toggleScript;
    string text1 = "";
    // Start is called before the first frame update
    void Start()
    {
        score_text = this.GetComponent<Text>();
        obj = this.transform.parent.gameObject;
        if(this.transform.parent.tag == "toggle1")
        {
            text1 = "1";
        }else if (this.transform.parent.tag == "toggle2")
        {
            text1 = "2";
        }
        else if (this.transform.parent.tag == "toggle3")
        {
            text1 = "3";
        }
        else if (this.transform.parent.tag == "toggle4")
        {
            text1 = "4";
        }
        else if (this.transform.parent.tag == "toggle5")
        {
            text1 = "5";
        }
    }

    // Update is called once per frame
    void Update()
    {
        toggleScript = obj.GetComponent<toggleScript>(); //unitychanÇÃíÜÇ…Ç†ÇÈUnityChanScriptÇéÊìæÇµÇƒïœêîÇ…äiî[Ç∑ÇÈ
        score_text.text = text1+" r;"+toggleScript.rank+" c:"+toggleScript.cost.ToString("f0");
    }
}
