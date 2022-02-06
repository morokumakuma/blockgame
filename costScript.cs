using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class costScript : MonoBehaviour
{
    toggleScript toggleScript;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = this.transform.parent.gameObject;
        toggleScript = obj.GetComponent<toggleScript>(); //unitychan‚Ì’†‚É‚ ‚éUnityChanScript‚ğæ“¾‚µ‚Ä•Ï”‚ÉŠi”[‚·‚é
        if(this.tag == "cost1")
        {
            toggleScript.cost = 1;
            
        }
        else if(this.tag == "cost2")
        {
            toggleScript.cost = 2;
            
        }
        else if (this.tag == "cost3")
        {
            toggleScript.cost = 3;
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
