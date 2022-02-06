using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sthickScript2 : MonoBehaviour
{
    topScript2 scriptwall; //UnityChanScript������ϐ�
    GameObject topwall2; //Unity����񂻂̂��̂�����ϐ�
    
    
    GameObject player; //Unity����񂻂̂��̂�����ϐ�
    
    PlayerScript2 script; //UnityChanScript������ϐ�
    public float speed = 3.5f;
    Rigidbody2D e_rigidbody2D;
    public float playerHP2;
    
    // Start is called before the first frame update
    void Start()
    {
        e_rigidbody2D = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        script = player.GetComponent<PlayerScript2>();
        topwall2 = GameObject.Find("playertop"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        scriptwall = topwall2.GetComponent<topScript2>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Position = transform.position;
        if (Position.y < -10.0)
        {
            Destroy(gameObject);
        }
        playerHP2 = scriptwall.PlayerHP; //�V�����ϐ���錾���Ă��̒���UnityChanScript�̕ϐ�HP��������

        if (playerHP2 <= 0)
        {
            e_rigidbody2D.velocity = new Vector2(0, 0);
        }
        else
        {
            if (scriptwall.topwall2 == 0)
            {
                e_rigidbody2D.velocity = new Vector2(e_rigidbody2D.velocity.x, -speed);
            }
            else
            {
                e_rigidbody2D.velocity = new Vector2(0, 0);
            }

        }
    }

}

