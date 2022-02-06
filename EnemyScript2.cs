using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript2 : MonoBehaviour
{
	GameObject player; //Unityちゃんそのものが入る変数
	GameObject topwall2; //Unityちゃんそのものが入る変数
	PlayerScript3 script; //UnityChanScriptが入る変数
	topScript2 scriptwall; //UnityChanScriptが入る変数
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

		topwall2 = GameObject.Find("playertop"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
		scriptwall = topwall2.GetComponent<topScript2>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
	}

	void Update()
	{

		Vector2 Position = transform.position;
		if (Position.y < -6.0)
		{
			Destroy(gameObject);
		}
		playerHP_enemy = scriptwall.PlayerHP; //新しく変数を宣言してその中にUnityChanScriptの変数HPを代入する


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