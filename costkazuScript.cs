using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class costkazuScript : MonoBehaviour
{
    GameObject playerstatus; //Unity����񂻂̂��̂�����ϐ�
    Text score_text;
    statusScript statusScript;
    // Start is called before the first frame update
    void Start()
    {
        score_text = this.GetComponent<Text>();
        playerstatus = GameObject.Find("playerstatus"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        statusScript = playerstatus.GetComponent<statusScript>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
    }

    // Update is called once per frame
    void Update()
    {
        if (statusScript.skillvalue < statusScript.cost1)
        {
            score_text.color = Color.red;
        }
        else
        {
            score_text.color = Color.white;
        }

        score_text.text = statusScript.cost1.ToString("f0")+"/" + statusScript.skillvalue.ToString("f0");
    }
}
