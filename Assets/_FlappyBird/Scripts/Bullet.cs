using System;
using System.Collections;
using System.Collections.Generic;
using GameTool;
using UnityEngine;

public class Bullet : BasePooling {
	[SerializeField] private float          speed;
	[SerializeField] private Rigidbody2D    rb;
	[SerializeField] private SpriteRenderer sr;

	private void OnEnable() {
		rb.velocity = new Vector2(speed, 0);	
	}

	// private void Update() {
	// 	rb.velocity = new Vector2(speed, 0);
	// }
}
