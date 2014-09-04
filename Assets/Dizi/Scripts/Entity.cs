using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour {
	private int _id;
	private string _name;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public string name{
		get{ return _name; } 
		set{ _name = value; }
	}
	/*public int id {
		get{ return _id; } 
		set{ _id = value; }
	}*/
}
