using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour {

	private BaseToonClass class1 = new BaseMainArcher();
	private BaseToonClass class2 = new BaseMainDivineMage();


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI (){
		GUILayout.Label();

	}
}
