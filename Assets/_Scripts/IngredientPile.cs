using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class IngredientPile : MonoBehaviour {

	//public Object IngredientPrefab;
	public GameObject startingIngredient;

	
	// Use this for initialization
	void Start () {
		//GameObject NewObj = Instantiate(startingIngredient, startingIngredient.transform.position, startingIngredient.transform.rotation) as GameObject;
		//startingIngredient.GetComponent<Renderer>().enabled=false;
		//NewObj.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnIngredient(object sender, InteractableObjectEventArgs e) {
		//((VRTK_InteractableObject)sender).gameObject.GetComponent<Renderer>().enabled = true;
		GameObject NewObj = Instantiate(startingIngredient, startingIngredient.transform.position, startingIngredient.transform.rotation) as GameObject;
		NewObj.transform.parent = startingIngredient.transform.parent;
		NewObj.transform.localScale = startingIngredient.transform.localScale;
		//NewObj.GetComponent<Renderer>().enabled=false;
	}
}
