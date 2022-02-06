using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour
{
	GameObject topwall2; //Unityちゃんそのものが入る変数
	topScript2 scriptwall; //UnityChanScriptが入る変数
	EnemyScript2 enemyScript2; //UnityChanScriptが入る変数
	PlayerScript2 script; //UnityChanScriptが入る変数
	
	GameObject enemy; //Unityちゃんそのものが入る変数
	public float timeLimit = 0.30f;
    public TextAlignment timerText;
	Rigidbody2D e_rigidbody2D;
	float timer3;
	float HPP = 1;
	public float speed = 3.5f;
	float timerV;
	Vector3 tyousei = new Vector3(-0.15f, 0.25f, 0.0f);
	int p;
	int s;
	// Start is called before the first frame update
	void Start()
    {
		e_rigidbody2D = GetComponent<Rigidbody2D>();
		topwall2 = GameObject.Find("playertop"); //Unityちゃんをオブジェクトの名前から取得して変数に格納する
		scriptwall = topwall2.GetComponent<topScript2>(); //unitychanの中にあるUnityChanScriptを取得して変数に格納する
		timeLimit = 3.0f;
        timer3 = timeLimit;
		p = (int)Mathf.Floor(UnityEngine.Random.Range(1, 101));
		s = (int)Mathf.Floor(UnityEngine.Random.Range(1, 30));

	}

    

    // Update is called once per frame
    void Update()
    {
        if (timerV < 200)
        {
			timerV++;
		}
		
		Vector2 Position = transform.position;
		if (Position.y < -5.0)
		{
			Destroy(gameObject);
		}
		if (timerV >= 100)
		{


			if (enemyScript2.tekiHPfack == 0)
			{
				Destroy(gameObject);
			}
		}
	}
    void OnTriggerStay2D(Collider2D col)
	{
		
		
		if(col.tag == "Enemy")
        {
			enemyScript2 = col.GetComponent<EnemyScript2>();
			
			if (timer3 > 0f)
			{
				timer3 = enemyScript2.tekiHP;
				if(timer3 == 5)
                {
					
                    if (p < 20)
                    {
						timer3 = s;
						enemyScript2.tekiHP = s;
					}
				}
				GetComponent<TextMesh>().text = timer3.ToString("f0");
				//timerText.text = timer.ToString("f1");
			}
			Vector2 Position = transform.position;
			if (Position.y < -6.0)
			{
				Destroy(gameObject);
			}
			enemyScript2.playerHP_enemy = scriptwall.PlayerHP; //新しく変数を宣言してその中にUnityChanScriptの変数HPを代入する


			if (enemyScript2.playerHP_enemy <= 0)
			{

				e_rigidbody2D.velocity = new Vector2(0, 0);

			}
			else
			{

				if (scriptwall.topwall2 == 1)
				{
					
					transform.position = col.transform.position + tyousei;
					

				}
				else
				{
					//e_rigidbody2D.velocity = new Vector2(e_rigidbody2D.velocity.x, -speed);
					transform.position = col.transform.position + tyousei;
				}

			}


		}
		

	}
	


}
