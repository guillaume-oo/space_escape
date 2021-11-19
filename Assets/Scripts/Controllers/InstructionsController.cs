using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsController : MonoBehaviour
{

	private GameObject canvas;


	void Start()
	{
		canvas = GameObject.Find("Canvas");
	}

	// Update is called once per frame
	void Update()
	{
		Transform playerCamera;
		RaycastHit hit;
		playerCamera = Camera.main.transform;

		Vector3 forward = transform.TransformDirection(Vector3.forward) * 100;

		canvas.transform.Find("Instructions").GetComponent<Text>().text = "Find all 3 fragments hidden on this planet";

		if (Physics.Raycast(playerCamera.position, forward, out hit, 250f))
		{
			if (hit.collider.GetComponent<AtommItem>() != null  ) 
			{
				canvas.transform.Find("Instructions").GetComponent<Text>().text = "Press E to collect";
			}
			else if (hit.collider.GetComponent<AtommContainer>() != null)
			{
				canvas.transform.Find("Instructions").GetComponent<Text>().text = "Press E to open";
			}
			if (hit.collider.GetComponent<SwitchPlayer>() != null  ) 
			{
				canvas.transform.Find("Instructions").GetComponent<Text>().text = "Press U to use spaceship";
			}
		}
	}
}
