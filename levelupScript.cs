using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class levelupScript : MonoBehaviour
{
    GameObject top; //Unity����񂻂̂��̂�����ϐ�
    topScript2 topScript;
    float originkeikenti;
    public Slider slider;		// �V�[���ɔz�u����Slider�i�[�p

    // Start is called before the first frame update
    void Start()
    {
        top = GameObject.Find("playertop"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        topScript = top.GetComponent<topScript2>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
    }

    // Update is called once per frame
    void Update()
    {
        //originkeikenti = topScript.keikenti;
        originkeikenti = topScript.PlayerHP;
        //slider.maxValue = topScript.hituyoukeikennti[topScript.j];
        slider.maxValue = 10;
        slider.value = originkeikenti;	// Slider�̏�����Ԃ�ݒ�iHP���^���j
        
    }
    
}
