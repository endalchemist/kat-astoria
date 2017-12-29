using UnityEngine;
using System.Collections;

public class MainClassGUI : MonoBehaviour {

	private BaseToonClasses class1 = new BaseMainArcher
	private BaseToonClasses class2 = new BaseMainBrawler
	private BaseToonClasses class3 = new BaseMainDivineMage
	private BaseToonClasses class4 = new BaseMainElementalMage
	private BaseToonClasses class5 = new BaseMainKnight
	private BaseToonClasses class6 = new BaseMainScoundrel
	private BaseToonClasses class7 = new BaseMainWorker




	void Start (){


	}

	void Update () {


	}

	void OnGUI(){
		GUILayout.Label(class1.ToonName);
		GUILayout.Label(class1.ToonDetails);
		GUILayout.Label(class2.ToonName);
		GUILayout.Label(class2.ToonDetails);
		GUILayout.Label(class3.ToonName);
		GUILayout.Label(class3.ToonDetails);
		GUILayout.Label(class4.ToonName);
		GUILayout.Label(class4.ToonDetails);
		GUILayout.Label(class5.ToonName);
		GUILayout.Label(class5.ToonDetails);
		GUILayout.Label(class6.ToonName);
		GUILayout.Label(class6.ToonDetails);
		GUILayout.Label(class7.ToonName);
		GUILayout.Label(class7.ToonDetails);


	}
}
