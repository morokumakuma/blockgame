using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript2 : MonoBehaviour
{
	GameObject player; //Unity����񂻂̂��̂�����ϐ�
	GameObject topwall2; //Unity����񂻂̂��̂�����ϐ�
	PlayerScript3 script; //UnityChanScript������ϐ�
	topScript2 scriptwall; //UnityChanScript������ϐ�
	public float speed = 3.5f;
	Rigidbody2D e_rigidbody2D;
	public  float tekiHP;
	public float tekiHPfack = 1;
	
	public float playerHP_enemy;
	void Start()
	{
		tekiHPfack = 1;
		tekiHP = Mathf.Floor(UnityEngine.Random.Range(1, 6));
		
		e_rigidbody2D = GetComponent<Rigidbody2D>();

		topwall2 = GameObject.Find("playertop"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
		scriptwall = topwall2.GetComponent<topScript2>(); //unitychan�̒��ɂ���UnityChanScript���擾���ĕϐ��Ɋi�[����
	}

	void Update()
	{

		Vector2 Position = transform.position;
		if (Position.y < -6.0)
		{
			Destroy(gameObject);
		}
		playerHP_enemy = scriptwall.PlayerHP; //�V�����ϐ���錾���Ă��̒���UnityChanScript�̕ϐ�HP��������


		if (playerHP_enemy <= 0)
		{

			e_rigidbody2D.velocity = new Vector2(0, 0);
		}
		else
		{
			
			if (scriptwall.topwall2 == 1)
			{
				
				e_rigidbody2D.velocity = new Vector2(0, 0);
				

			}
			else
			{
				e_rigidbody2D.velocity = new Vector2(e_rigidbody2D.velocity.x, -speed);

			}

		}

		
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "top"||col.tag =="right"||col.tag =="left")
		{

			tekiHPfack = 0;
			transform.position = new Vector3(0, -50, 0);




		}


	}

	
	
}