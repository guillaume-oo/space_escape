using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
	// Speed for movements
	public float forwardSpeed = 25000f, horizontalSpeed = 7000f, hoverSpeed = 5000f;
	public float forwardAcceleration = 1f, horizontalAcceleration = 1f, hoverAcceleration = 1f;
	public float mouseSensitivity = .1f;
	public bool inAtmosphere = true;

	private Player playerInput;
	private CharacterController controller;
	private Gun gun;
	private SwitchPlayer switchPlayer;

	private Transform cameraTransform;
	private float activeForwardSpeed, activeHorizontalSpeed, activeHoverSpeed;
	private float verticalLookRotation, hoverDirection;

	public AudioSource audioSource;
	public AudioClip spaceshipMotor;

	private void OnEnable()
	{
		playerInput = new Player();
		playerInput.Enable();
	}

	private void OnDisable()
	{
		playerInput.Disable();
	}

	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

		gun = GetComponent<Gun>();
		switchPlayer = GetComponent<SwitchPlayer>();
		cameraTransform = transform.Find("CameraShip").GetComponent<Camera>().transform;
		controller = GetComponent<CharacterController>();
    audioSource = GetComponent<AudioSource>();
		audioSource.PlayOneShot(spaceshipMotor);
	}

	void Update()
	{
		if (playerInput.SpaceshipMain.Fire.ReadValue<float>() > 0)
		{
			gun.Fire();
		}
		if (playerInput.SpaceshipMain.Use.triggered)
		{
			// Get out of spaceship
			switchPlayer.UseSpaceship();
		}
		if (!inAtmosphere)
		// Spaceship movments that are available only when out of atmosphere 
		{
			Rotate();
			Translate();
		}

		// Hover movement, always available
		if (playerInput.SpaceshipMain.HoverUp.ReadValue<float>() != 0)
		{
			hoverDirection = playerInput.SpaceshipMain.HoverUp.ReadValue<float>() - playerInput.SpaceshipMain.HoverDown.ReadValue<float>();
			activeHoverSpeed = Mathf.Lerp(activeHoverSpeed, hoverDirection  * hoverSpeed, hoverAcceleration * Time.deltaTime);
			transform.position += transform.up * activeHoverSpeed * Time.deltaTime;
		}
	}

	private void Rotate()
	{

		//Get command input values 
		Vector2 lookInput = playerInput.PlayerMain.Look.ReadValue<Vector2>();
		float lookX = lookInput.x * mouseSensitivity;
		// TODO: multiply Y value by -1 for mobile version
		float lookY = lookInput.y * mouseSensitivity;

		//Rotate player
		transform.Rotate(0, lookX, 0, Space.Self);
		transform.Rotate(lookY, 0, 0, Space.Self);
	}

	private void Translate()
	{
		//Get command input values 
		Vector2 movementInput = playerInput.PlayerMain.Move.ReadValue<Vector2>();

		float inputX = movementInput.x * Time.deltaTime * horizontalSpeed;
		// TODO: multiply Y value by -1 ofor mobile version
		// We use the clamp funtion here to minimize the backward speed to a value that is 100 times slower than the forward speed
		float inputY = Mathf.Clamp(movementInput.y * Time.deltaTime * forwardSpeed, - forwardSpeed / 100,  forwardSpeed);

		//Smooth move values
		activeForwardSpeed = Mathf.Lerp(activeForwardSpeed, inputY, forwardAcceleration * Time.deltaTime);
		activeHorizontalSpeed = Mathf.Lerp(activeHorizontalSpeed, inputX, horizontalAcceleration * Time.deltaTime);

		//Translate player 
		transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;
		transform.position += transform.right * activeHorizontalSpeed * Time.deltaTime;
	}
}
