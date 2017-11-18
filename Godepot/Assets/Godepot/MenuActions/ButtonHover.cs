using UnityEngine;
using System.Collections;

public class ButtonHover : MonoBehaviour {

	SpriteRenderer s;
	public Color[] buttonColor;

	void Start() {
		s = GetComponent<SpriteRenderer>();
	}

	void OnMouseEnter() {
		s.color = FixColor(1);
	}

	void OnMouseExit(){
		s.color = FixColor(0);
	}
	
	// Update is called once per frame
	void OnMouseDown() {
		s.color = FixColor(2);
	}

	void OnMouseUp() {
		s.color = FixColor(0);
	}

	Color FixColor(int i) {
		Color pre = buttonColor[i];
		return new Color(pre.r, pre.g, pre.b, 1);
	}
}
