using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sliderScript : MonoBehaviour
{
    GameObject playerstatus; //Unity����񂻂̂��̂�����ϐ�
    
    statusScript statusScript;
    public Slider slider;
    public int ok;
    // Start is called before the first frame update
    void Start()
    {
        playerstatus = GameObject.Find("playerstatus"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        statusScript = playerstatus.GetComponent<statusScript>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
        
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
            Debug.Log("�ۑ�����܂���ł���");

        }
        else
        {
            Debug.Log("�ۑ�����܂���");
            ok = 1;
        }
    }
}

