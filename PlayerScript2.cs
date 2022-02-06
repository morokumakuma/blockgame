using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript2 : MonoBehaviour
{
	private int SPEED2 = 10;
	GameObject wall;//Unityちゃんそのものが入る変数
	GameObject wall2;
	GameObject wall3;
	EnemyScript2 script2;
	leftScript2 scriptwall;
	rightScript2 scriptwall2;
	topScript2 scriptwall3;
	//UnityChanScriptが入る変数
	private Vector3 mouse;
	private Vector3 target;
	int tyu = 0;
	float xzahyo = 0.0f;
	private Vector2 SPEED = new Vector2(0.05f, 0.05f);
	int timer;
	float timerx = 0;
	Vector3 azahyo;
	Rigidbody2D rb;
	Vector2 Position;
	void Start()
	{
		timerx = 2;
		wall = GameObject.Find("playerleft");
		scriptwall = wall.GetComponent<leftScript2>();
		wall2 = GameObject.Find("playerright");
		scriptwall2 = wall2.GetComponent<rightScript2>();
		wall3 = GameObject.Find("playertop");
		scriptwall3 = wall3.GetComponent<topScript2>();
		timer = 10;
		rb = this.transform.GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		//PlayerHP = script2.playerHP;
		mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		target = new Vector3(mouse.x, mouse.y, 10);
		target.y = transform.position.y;
		Vector2 Position = transform.position;
		rb.velocity = new Vector2(mouse.x - this.Position.x, 0).normalized * SPEED2;
		
		// 左キーを押し続けていたら
		if (timer >= 0)
		{
			if (timer == 100)
			{

			}
			timer--;
			if (timer == 0)
			{
				timer = 10;
			}
		}
		if (scriptwall3.PlayerHP >= 1)
		{
			if (scriptwall.leftwall2 == 0)
			{
				if (scriptwall2.rightwall2 == 0)
				{

					/*if (Input.GetMouseButton(0))
					{
						Debug.Log("たっぷしてるよ！");

						if (tyu == 0)
						{
							*/
					/*Vector2 direction = new Vector2(azahyo.x - xzahyo, 0).normalized;
					rb.velocity = direction * SPEED2;*/
					/*float posi = this.transform.position.x + azahyo.x - xzahyo;
					transform.position = new Vector3(posi, this.transform.position.y, 0);
					mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
					xzahyo = mouse.x;


					tyu = 1;


				}
				if (tyu == 1)
				{
					timerx--;
					if (timerx <= 0)
					{
						azahyo = yobidasi();
						Debug.Log("wwwwwwwww");
					}
				}
			}
			if (mouse.x < -1.6f)
			{

				this.transform.position = new Vector3(-1.64f, this.transform.position.y, 0);

			}
			else if (mouse.x > 1.6f)
			{
				this.transform.position = new Vector3(1.64f, this.transform.position.y, 0);
			}*/
					/*else
					{
						this.transform.position = target;
					}*/
					



					}
					else
					{
						/*if (scriptwall2.Vecright.x-0.5f > mouse.x)
						{
							this.transform.position = target;
						}*/
					}

					// 代入したPositionに対して加算減算を行う

				}
				else
				{
					/*if (scriptwall.vecleft.x+0.5f < mouse.x)
					{
						this.transform.position = target;
					}*/
				}


				/*if (Input.GetKey("left"))
				{
					if (scriptwall.leftwall2 == 0)
					{


						// 代入したPositionに対して加算減算を行う
						if (Position.x > -1.6)
						{
							Position.x -= SPEED.x;
						}
					}
				}
				else if (Input.GetKey("right"))
				{ // 右キーを押し続けていたら
				  // 代入したPositionに対して加算減算を行う
					if (scriptwall2.rightwall2 == 0)
					{
						if (Position.x < 1.6)
						{

							Position.x += SPEED.x;

						}
					}



				}

				// 現在の位置に加算減算を行ったPositionを代入する
				//transform.position = Position;*/
			}

		}



		void OnTriggerEnter2D(Collider2D col)
		{




		}
		Vector3 yobidasi()
		{
			tyu = 0;
			timerx = 2;
			return Camera.main.ScreenToWorldPoint(Input.mousePosition);

		}



	}