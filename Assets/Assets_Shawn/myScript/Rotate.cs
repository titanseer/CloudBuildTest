using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//int i=0;
	//	i = Random.Range(-1,1);
		this.gameObject.transform.Rotate(Random.Range(-1,1),Random.Range(-1,1),Random.Range(-1,1));

	}
}
