using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class mainMovement : MonoBehaviour {


	public List<GameObject> tail = new List<GameObject>();
	public float z_offset = 0.5f;
	public float Speed;
	public float RotationSpeed;	public GameObject TailPrefab;
	public Text ScoreText;
	public int score = 0;
	public int highscore = 0;
	private int levelmultiplyer;
	void Start () {
		tail.Add(gameObject);
		highscore = PlayerPrefs.GetInt ("highscore");
		PlayerPrefs.SetInt ("score", score);
		levelmultiplyer = PlayerPrefs.GetInt ("level"); 
	}
	void Update () 
	{
		ScoreText.text = score.ToString();
		if (score < 50) {
			transform.Translate (Vector3.forward * Speed * Time.deltaTime * levelmultiplyer);
		} else {
			transform.Translate (Vector3.forward * Speed * score / 50 * Time.deltaTime * levelmultiplyer);
		}


		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(Vector3.up*RotationSpeed*Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(Vector3.up*-1*RotationSpeed*Time.deltaTime);
		}
	}

	public void AddTail()
	{
		score += Random.Range(1,10)+(10*levelmultiplyer);
		PlayerPrefs.SetInt ("score", score);
		if (highscore < score) {
			PlayerPrefs.SetInt ("highscore", score);
			highscore = score;
		}
		Vector3 newTailPos = tail[tail.Count-1].transform.position;
		newTailPos.z -= z_offset;
		tail.Add(GameObject.Instantiate(TailPrefab,newTailPos,Quaternion.identity) as GameObject);
	}
}