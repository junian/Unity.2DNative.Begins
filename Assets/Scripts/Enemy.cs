﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public Weapon[] weapon;
	public int touchDamage = 1;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 10.0f);
		weapon = this.GetComponentsInChildren<Weapon>();
	}
	
	// Update is called once per frame
	void Update () {
		if(weapon != null)
		{
			foreach(var w in weapon)
				w.Attack(true);
		}
	}
}
