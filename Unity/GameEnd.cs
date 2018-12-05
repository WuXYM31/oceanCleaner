using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour {

	public int finalscore;
	public static int score;
	public float timeLeft;

	// Use this for initialization
	void Start () {
		timeLeft = 10.0f;
	}
		
	//Compare and Submit Score to Server
	public void GameOver(){
		//Switch to endscene  Application.LoadLevel ("endScene");
		Debug.Log ("Game ends！");
		Debug.Log ("Your score is:"+PlayerPrefs.GetInt ("MyScore"));
		//compare score with highest score
		//PlayerPrefs.SetInt("endScene",score);
		Application.LoadLevel("endscene");


		//if current score is higher, send it to server and save
		//if(){
			
		//}
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if ( timeLeft < 0 )
		{
			GameOver();
		}
		if (timeLeft >= 0) {
			Debug.Log ("real time score:"+PlayerPrefs.GetInt ("MyScore"));
		}
		
	}
}
