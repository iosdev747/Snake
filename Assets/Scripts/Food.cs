using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {

	public float XSize = 8.8f;
	public float ZSize = 8.8f;
	public GameObject foodPrefab1;
	public GameObject foodPrefab2;
	public GameObject foodPrefab3;
	public Vector3 position;
	public GameObject foodposition;
	private int random;
	void addFood()
	{
		random = Random.Range (1, 12);
		if (random >= 5) {
			position = new Vector3(Random.Range(XSize*-1,XSize),0.25f,Random.Range(ZSize*-1,ZSize));
			foodPrefab1.GetComponent<MeshRenderer> ().sharedMaterial.SetColor ("_Color", Color.red);
			foodposition = GameObject.Instantiate (foodPrefab1, position, Quaternion.identity) as GameObject;
		}
		else if (random < 5 && random >= 9) {
			position = new Vector3(Random.Range(XSize*-1,XSize),0.25f,Random.Range(ZSize*-1,ZSize));
			foodPrefab2.GetComponent<MeshRenderer> ().sharedMaterial.SetColor ("_Color", Color.white);
			foodposition = GameObject.Instantiate (foodPrefab2, position, Quaternion.identity) as GameObject;
		}
		else {
			position = new Vector3(Random.Range(XSize*-1,XSize),0.25f,Random.Range(ZSize*-1,ZSize));
			foodPrefab3.GetComponent<MeshRenderer> ().sharedMaterial.SetColor ("_Color", Color.green);
			foodposition = GameObject.Instantiate (foodPrefab3, position, Quaternion.identity) as GameObject;
		}
			
	}
		
	void Update()
	{
		if(!foodposition)
		{
			addFood();
		}
		else
		{
			return;
		}
	}
}
