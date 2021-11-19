using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchPlayer : MonoBehaviour
{
	public bool canUse = false;
	public AudioSource audioSource;
	public AudioClip doorAction;

	private bool use = false;
	private GameObject player;
	private GameObject homePlanet;
	private GameObject canvas;
	private AtommInventory playerInventory;
	private AtommContainer chest;

	void Start ()
	{
		homePlanet = GameObject.Find("HomePlanet");
		playerInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<AtommInventory>();
		chest = GameObject.FindGameObjectWithTag("ShipChest").GetComponent<AtommContainer>();
		canvas = GameObject.Find("Canvas");
    audioSource = GetComponent<AudioSource>();
	}

	void OnTriggerEnter (Collider col)
	{
		// Set the variable canUse to true only if the collider is the player
		if (col.gameObject.tag == "Player")
		{
			player = col.gameObject;
			canUse = true;
			// Updateinstruction text
			// canvas.transform.Find("Instructions").GetComponent<Text>().text = "Press U to use the spaceship";
		}
	}

	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			canUse = false;
		}
	}

	public void UseSpaceship()
	{
		if (canUse || use)
		{
			audioSource.PlayOneShot(doorAction);
			use = !use;
			if (use)
			{
				// Show Spaceship buttons
				canvas.transform.Find("Fire").gameObject.active = true;
				canvas.transform.Find("HoverUp").gameObject.active = true;
				canvas.transform.Find("HoverDown").gameObject.active = true;
				// Hide Inventory buttons
				canvas.transform.Find("Inventory").gameObject.active = false;
				canvas.transform.Find("Collect").gameObject.active = false;
				// Activate Ship Controls on planet (hovering controls and detect if ship leaves planet)
				homePlanet.transform.Find("PlanetCollider").GetComponent<ShipPlanetController>().enabled = true;
				// Disable spaceship collider's trigger (used to detect the player approaching the spaceship esssentially)
				GetComponent<BoxCollider>().isTrigger = false;
				// Enable spaceship gun
				GetComponent<Gun>().enabled = true;
				GetComponent<ShipController>().enabled = true;
				// Enable spaceship camera
				transform.Find("CameraShip").GetComponent<Camera>().enabled = true;

				// Enable the planet Atmosphere collider. Used to detect when the Spaceship leaves the planet's orbit
				homePlanet.transform.Find("PlanetCollider").GetComponent<SphereCollider>().enabled = true;

				// Disable player controls
				player.GetComponent<PlayerController>().enabled = false;
				// Disable inventory controls
				player.GetComponent<AtommInventory>().enabled = false;
				// Disable cosmonaut's Camera
				player.transform.Find("CameraPlayer").GetComponent<Camera>().enabled = false;
				// Disbale player
				player.active = false;
			}
			else
			{
				// Hide Spaceship buttons
				canvas.transform.Find("Fire").gameObject.active = false;
				canvas.transform.Find("HoverUp").gameObject.active = false;
				canvas.transform.Find("HoverDown").gameObject.active = false;
				// Show Inventory buttons
				canvas.transform.Find("Inventory").gameObject.active = true;
				canvas.transform.Find("Collect").gameObject.active = true;
				// Desactivate Ship Controls on planet (hovering controls and detect if ship leaves planet)
				homePlanet.transform.Find("PlanetCollider").GetComponent<ShipPlanetController>().enabled = false;
				// Enable spaceship collider's trigger 
				GetComponent<BoxCollider>().isTrigger = true;
				// Disable spaceship gun
				GetComponent<Gun>().enabled = false;
				// Disable spaceship camera
				transform.Find("CameraShip").GetComponent<Camera>().enabled = false;

				// Disable the planet Atmosphere collider. Avoid having the player walking on the atmosphere's collider
				homePlanet.transform.Find("PlanetCollider").GetComponent<SphereCollider>().enabled = false;

				// Enable player controls
				player.GetComponent<PlayerController>().enabled = true;
				// Enable inventory controls
				player.GetComponent<AtommInventory>().enabled = true;
				// Teleport the player to the ship's position
				player.transform.position = transform.position;
				// Enable cosmonaut's Camera
				player.transform.Find("CameraPlayer").GetComponent<Camera>().enabled = true;    
				// Enable player    
				player.active = true;            
			}

		}
  }
}
