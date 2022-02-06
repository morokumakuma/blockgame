using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateskillScript : MonoBehaviour
{
    GameObject playerstatus; //Unityちゃんそのものが入る変数
    public GameObject Cost1;
    public GameObject Cost2;
    public GameObject Cost3;
    public GameObject rank1;
    public GameObject rank2;
    public GameObject rank3;
    public GameObject on1;
    statusScript statusScript;
    GameObject status;
    public GameObject[] clone1 = new GameObject[5];
    Transform parent;
    int o;
    // Start is called before the first frame update
    void Start()
    {
        o = 0;
        parent = this.transform;
        playerstatus = GameObject.Find("playerstatus"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
        statusScript = playerstatus.GetComponent<statusScript>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
        
        for (int i = 0; i < statusScript.nannkai;i++)
        {
            for(int j = 0; j < 3; j++)
            {
                for(int k = 0; k < 3; k++)
                {
                    
                    if (statusScript.drop[i, j, k] >= 1)
                    {
                        for (int t = 0; t < statusScript.drop[i, j, k]; t++)
                        {
                            
                            GameObject a = Instantiate(clone1[i], new Vector3(i, j, 0), Quaternion.identity, parent);
                            if (j == 0)
                            {
                                Instantiate(Cost1.gameObject, new Vector3(i, j, 0), Quaternion.identity, a.transform);
                            }else if (j == 1)
                            {
                                Instantiate(Cost2.gameObject, new Vector3(i, j, 0), Quaternion.identity, a.transform);
                            }
                            else if (j == 2)
                            {
                                Instantiate(Cost3.gameObject, new Vector3(i, j, 0), Quaternion.identity, a.transform);
                            }
                           
                            if (k == 0)
                            {
                                Instantiate(rank1.gameObject, new Vector3(i, j, 0), Quaternion.identity, a.transform);
                            }
                            else if (k == 1)
                            {
                                Instantiate(rank2.gameObject, new Vector3(i, j, 0), Quaternion.identity, a.transform);
                            }
                            else if (k == 2)
                            {
                                Instantiate(rank3.gameObject, new Vector3(i, j, 0), Quaternion.identity, a.transform);
                            }
                            if(statusScript.basyo[o] == 1){
                                Instantiate(on1.gameObject, new Vector3(i, j, 0), Quaternion.identity, a.transform);
                            }
                            o++;
                        }
                    }
                }
                
               
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
