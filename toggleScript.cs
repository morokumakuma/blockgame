using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleScript : MonoBehaviour
{
    GameObject slider; //Unity����񂻂̂��̂�����ϐ�

    sliderScript sliderScript;
    GameObject playerstatus; //Unity����񂻂̂��̂�����ϐ�
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
        playerstatus = GameObject.Find("playerstatus"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        statusScript = playerstatus.GetComponent<statusScript>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
        slider = GameObject.Find("Slider"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        sliderScript = slider.GetComponent<sliderScript>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
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
