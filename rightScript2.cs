using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightScript2 : MonoBehaviour
{
    GameObject topwall2; //Unity����񂻂̂��̂�����ϐ�
    EnemyScript2 enemyScript;
    topScript2 scriptwall; //UnityChanScript������ϐ�
    kaihukuScript KaihukuScript; //UnityChanScript������ϐ�
    public int leftwall2;
    public int rightwall2;
    private Vector3 SPEED = new Vector3(0, 0.2f, 0);
    private Vector3 SPEED2 = new Vector3(0.2f, 0, 0);
    private Vector3 SPEED3 = new Vector3(-0.2f, 0, 0);
    public bool wall = true;
    public float rightHP;
    GameObject player; //Unity����񂻂̂��̂�����ϐ�
    int abc;
    int mmm;
    public Vector3 Vecright;
    // Start is called before the first frame update
    void Start()
    {
        mmm = 100;
        player = GameObject.Find("Player"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        topwall2 = GameObject.Find("playertop"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        scriptwall = topwall2.GetComponent<topScript2>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "top")
        {
            transform.position = player.transform.position + SPEED;
        }
        if (tag == "right")
        {
            transform.position = player.transform.position + SPEED2;
        }
        if (tag == "left")
        {
            transform.position = player.transform.position + SPEED3;
        }
        if (abc == 1)
        {
            mmm--;
        }
        if (mmm == 0)
        {
            rightHP = 0;
            abc = 0;
            mmm = 100;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {


        if (col.tag == "wall" || col.tag == "Enemy")
        {
            if (tag == "top")
            {


            }
            if (tag == "left")
            {
                leftwall2 = 1;

            }
            if (tag == "right")
            {
                /*Vecright = this.transform.position;
                rightwall2 = 1;*/
                rightHP = col.GetComponent<EnemyScript2>().tekiHP;

                scriptwall.PlayerHP += rightHP;
                rightHP = 0;
            }



        }
        if (col.tag == "kaihuku")
        {
            KaihukuScript = col.GetComponent<kaihukuScript>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
            rightHP = KaihukuScript.portionHP;
            scriptwall.PlayerHP += rightHP;
            rightHP = 0;
            //abc = 1;
            
        }

    }
    void OnTriggerExit2D(Collider2D col)
    {


        if (col.tag == "wall" || col.tag == "Enemy")
        {
            if (tag == "top")
            {
            }
            if (tag == "left")
            {
                leftwall2 = 0;
              
            }
            if (tag == "right")
            {
                rightwall2 = 0;
                
            }



        }

    }
}
