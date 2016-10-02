using UnityEngine;
using System.Collections;


public class ObjectGrab : MonoBehaviour 
{
	public GameObject puzzle;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Puzzle") 
		{
			
		}
	}

	void OnTriggerExit(Collider col)
	{
		if (col.gameObject.tag == "Puzzle") 
		{
			
		}
	}
}
