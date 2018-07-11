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
		Transform PickedUpTransform = ((VRTK_InteractableObject)sender).gameObject.transform;
		GameObject NewObj = Instantiate(startingIngredient, PickedUpTransform.position, PickedUpTransform.rotation) as GameObject;
		NewObj.transform.parent = startingIngredient.transform.parent;
		NewObj.transform.localScale = PickedUpTransform.localScale;
		NewObj.GetComponent<VRTK_InteractableObject>().isGrabbable = true;
		//NewObj.GetComponent<Renderer>().enabled=false;
	}
}
