using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rankScript : MonoBehaviour
{
    toggleScript toggleScript;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = this.transform.parent.gameObject;
        toggleScript = obj.GetComponent<toggleScript>(); //unitychan‚Ì’†‚É‚ ‚éUnityChanScript‚ğæ“¾‚µ‚Ä•Ï”‚ÉŠi”[‚·‚é
        if (this.tag == "rank1")
        {
            toggleScript.rank = 1;

        }
        else if (this.tag == "rank2")
        {
            toggleScript.rank = 2;

        }
        else if (this.tag == "rank3")
        {
            toggleScript.rank = 3;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
