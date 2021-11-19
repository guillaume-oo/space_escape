using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPlanetController : MonoBehaviour
{
	void OnTriggerEnter (Collider col)
	{
		// If the player enters the planet aboard of a spaceship
		if (col.gameObject.tag == "Player" && col.gameObject.name == "Ship")
		{
				GameObject.Find("Ship").transform.GetComponent<ShipController>().inAtmosphere = true;
		}
	}

	void OnTriggerExit (Collider col)
	{
		// If the player leaves the planet aboard of a spaceship
		if (col.gameObject.tag == "Player" && col.gameObject.name == "Ship")
		{
				GameObject.Find("Ship").transform.GetComponent<ShipController>().inAtmosphere = false;
		}
	}
}
