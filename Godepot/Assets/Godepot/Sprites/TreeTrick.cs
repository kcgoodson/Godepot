using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTrick : MonoBehaviour {

	public GameObject backTree;
	bool isSet = false;

	public void SetTree() {
		if (!isSet) {
			isSet = true;
			backTree.GetComponent<SpriteRenderer> ().enabled = true;
		}
	}
}
