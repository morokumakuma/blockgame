using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class statusScript : MonoBehaviour
{
    public float money;
    public float originplayerHP;
    topScript2 topScript;
    GameObject playertop; //Unity����񂻂̂��̂�����ϐ�
    public float[,,] drop;
    public int nannkai;
    public int sss;
    public int yyy;
    public int cost1;
    public int skillvalue;
    public int onoff;
    public int[] basyo;
    public int plusHP;
    // Start is called before the first frame update
    void Start()
    {
        plusHP = 0;
        onoff = 0;
        skillvalue = 10;
        sss = 0;
        DontDestroyOnLoad(this);
        originplayerHP = 5;
        money = 10;
        cost1 = 0;
        basyo = new int[30];
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "game")
        {
            playertop = GameObject.Find("playertop"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
            topScript = playertop.GetComponent<topScript2>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
            if (topScript.dropkakunin == 1)
            {
                nannkai = topScript.syurui;
                //topScript.dropkakunin = 0;
                drop = topScript.dropitem;
            }
        }

    }
    public void OnClick()
    {
        if(money > 0)
        {
            originplayerHP++;
            money--;
        }
        
    }
    
}
