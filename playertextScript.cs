using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertextScript : MonoBehaviour
{
    topScript2 topScript; //UnityChanScript������ϐ�
    GameObject playertop; //Unity����񂻂̂��̂�����ϐ�
    // Start is called before the first frame update
    void Start()
    {
        playertop = GameObject.Find("playertop"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        topScript = playertop.GetComponent<topScript2>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = topScript.PlayerHP.ToString("f0");
    }
}
