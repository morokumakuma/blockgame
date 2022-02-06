using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.parent.GetComponent<Toggle>().isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
