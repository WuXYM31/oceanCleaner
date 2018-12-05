using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UI : MonoBehaviour
{
	public string path = "http://www.666wxy.com/unity/RankingUpdate.php";
	public string downloadPath = "http://www.666wxy.com/unity/RankingDownload.php";

	public string name;
	public string score;

	void OnGUI()
	{
		name = GUILayout.TextField(name, 10);
		score = GUILayout.TextField(score, 10);

		if(GUILayout.Button("Update"))
		{
			StartCoroutine("ScoreUpdate");
		}

		if(GUILayout.Button("Download"))
		{	
			StartCoroutine("ScoreDownload");	
		}
	}


	public IEnumerator ScoreUpdate()
	{		
		WWWForm form = new WWWForm();

		Dictionary<string,string> data = new Dictionary<string, string>();
		data.Add("name", name);
		data.Add("score", score);

		foreach(KeyValuePair<string,string> post in data)
		{
			form.AddField( post.Key, post.Value );
		}

		WWW www = new WWW(path, form);

		yield return www;

		Debug.Log(www.text);
		Debug.Log("uploadpath is "+ path);

	}

	public IEnumerator ScoreDownload()
	{
		WWWForm form = new WWWForm();

		Dictionary<string,string> data = new Dictionary<string, string>();
		data.Add("download", "1");

		foreach(KeyValuePair<string,string> post in data)
		{
			form.AddField( post.Key, post.Value );

		}

		WWW www = new WWW(downloadPath, form);

		yield return www;

		Debug.Log(www.text);
		Debug.Log("downloadpath is "+ downloadPath);
	}
}