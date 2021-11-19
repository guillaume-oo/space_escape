using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
	public bool isMobileVersion;

	private GameObject[] mobileControls;
	private Player playerInput;

	private void OnEnable()
	{
		playerInput.Enable();
	}

	private void OnDisable()
	{
		playerInput.Disable();
	}

	void Awake()
	{
		playerInput = new Player();
	}

	void Start()
	{
		// Disable mobile controlls on screen 
		if (!isMobileVersion)
		{
      mobileControls = GameObject.FindGameObjectsWithTag("GameController");
			foreach (GameObject control in mobileControls)
			{
				control.SetActive(false);
			}
		}
	}

	void Update()
	{
		if (playerInput.PlayerMain.Exit.triggered)
		{
			Application.Quit();
		}
	}
}
