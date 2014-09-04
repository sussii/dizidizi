using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EntityManager : MonoBehaviour {

	private EntityManager instance;
	private Dictionary <int, DiziEntity> diziDict;
	private Dictionary <int, BuildingEntity> buildingDict; 
	private Dictionary <int, NPCEntity> npcDict;

	public static EntityManager GetInstance(){
		if (!instance) {
			instance = new EntityManager();
			return instance;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
