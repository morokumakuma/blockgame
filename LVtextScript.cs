using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVtextScript : MonoBehaviour
{
    GameObject top; //Unity����񂻂̂��̂�����ϐ�
    topScript2 topScript;
    // Start is called before the first frame update
    void Start()
    {

        top = GameObject.Find("playertop"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        topScript = top.GetComponent<topScript2>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = "LV." + topScript.playerLV.ToString("f0");
    }
}
