﻿using UnityEngine;
using System.Collections;

public class MixingElementsMedium : MonoBehaviour {
	public GameObject[] elements;
	public int rand,x=0;
	bool[] availablility={true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true,true};
	public Sprite a1,a2,a3,a4,a5,a6,a7,a8,a9,a10;
	// Use this for initialization
	void Start () {
		rand = Random.Range (0, 20);

		elements = GameObject.FindGameObjectsWithTag ("Box");

		SetSprite ();
	}

	// Update is called once per frame
	void Update () {

	}

	void SetSprite(){

		for (int i = 0; i < elements.Length; i++) {
			if (i == 0) {
				rand = Random.Range (0, 20);
				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a1;
				availablility [rand] = false;
			}
			else if (i == 1) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a1;
				availablility [rand] = false;

			}
			else if (i == 2) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a2;
				availablility [rand] = false;

			}
			else if (i == 3) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a2;
				availablility [rand] = false;

			}
			else if (i == 4) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a3;
				availablility [rand] = false;

			}
			else if (i == 5) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a3;
				availablility [rand] = false;
			}
			else if (i == 6) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a4;
				availablility [rand] = false;

			}
			else if (i == 7) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a4;
				availablility [rand] = false;

			}
			else if (i == 8) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a5;
				availablility [rand] = false;

			}
			else if (i == 9) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a5;
				availablility [rand] = false;

			}
			else if (i == 10) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a6;
				availablility [rand] = false;

			}
			else if (i == 11) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a6;
				availablility [rand] = false;
			}
			else if (i == 12) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a7;
				availablility [rand] = false;
			}
			else if (i == 13) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a7;
				availablility [rand] = false;
			}
			else if (i == 14) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a8;
				availablility [rand] = false;
			}
			else if (i == 15) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a8;
				availablility [rand] = false;
			}
			else if (i == 16) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a9;
				availablility [rand] = false;
			}
			else if (i == 17) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a9;
				availablility [rand] = false;
			}
			else if (i == 18) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a10;
				availablility [rand] = false;
			}
			else if (i == 19) {
				while (!availablility [rand])
					rand = Random.Range (0, 20);

				elements [rand].gameObject.GetComponentInChildren<SpriteRenderer> ().sprite = a10;
				availablility [rand] = false;
			}

		}
	}
}