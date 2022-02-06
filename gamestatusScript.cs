using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamestatusScript : MonoBehaviour
{
    GameObject playerstatus;

    statusScript statusScript;
    public float[,,] status2;
    int o;
    int s;
    int syu;
    int kosuto;
    int ranku;
    public int addHP;
    public float addSPEED;
    // Start is called before the first frame update
    void Start()
    {
        s = 0;
        playerstatus = GameObject.Find("playerstatus");
        statusScript = playerstatus.GetComponent<statusScript>();
        o = 0;
        for (int i = 0; i < statusScript.nannkai; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (statusScript.drop[i, j, k] >= 1)
                    {
                        syu = i;
                        kosuto = j;
                        ranku = k;
                        
                        for (int t = 0; t < statusScript.drop[i, j, k]; t++)
                        {
                            Debug.Log(statusScript.basyo[o]);

                            if (statusScript.basyo[o] == 1)
                            {
                                if (syu == 0)
                                {

                                    if (ranku == 0)
                                    {
                                        addHP += 30;

                                    }
                                    else if (ranku == 1)
                                    {
                                        addHP += 20;

                                    }
                                    else if (ranku == 2)
                                    {
                                        addHP += 10;

                                    }
                                }
                                else if (syu == 1)
                                {

                                    if (ranku == 0)
                                    {
                                        addSPEED += 2;

                                    }
                                    else if (ranku == 1)
                                    {
                                        addSPEED += 4;

                                    }
                                    else if (ranku == 2)
                                    {
                                        addSPEED += 6;

                                    }
                                }
                                else if (syu == 1)
                                {

                                    if (ranku == 0)
                                    {


                                    }
                                    else if (ranku == 1)
                                    {


                                    }
                                    else if (ranku == 2)
                                    {


                                    }
                                }
                                else if (syu == 1)
                                {

                                    if (ranku == 0)
                                    {


                                    }
                                    else if (ranku == 1)
                                    {


                                    }
                                    else if (ranku == 2)
                                    {


                                    }
                                }
                                else if (syu == 1)
                                {

                                    if (ranku == 0)
                                    {


                                    }
                                    else if (ranku == 1)
                                    {


                                    }
                                    else if (ranku == 2)
                                    {


                                    }
                                }
                                else if (syu == 1)
                                {

                                    if (ranku == 0)
                                    {


                                    }
                                    else if (ranku == 1)
                                    {


                                    }
                                    else if (ranku == 2)
                                    {


                                    }
                                }
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
        public void Onclick()
        {
        statusScript.plusHP = addHP;
        }
    
}
