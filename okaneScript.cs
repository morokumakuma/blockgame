using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okaneScript : MonoBehaviour
{
    statusScript statusScript;
    GameObject status;
    GameObject playerstatus; //Unity����񂻂̂��̂�����ϐ�
    // Start is called before the first frame update
    void Start()
    {
        playerstatus = GameObject.Find("playerstatus"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        statusScript = playerstatus.GetComponent<statusScript>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        if (statusScript.money > 0)
        {
           statusScript.originplayerHP++;
           statusScript.money--;
        }

    }
}
