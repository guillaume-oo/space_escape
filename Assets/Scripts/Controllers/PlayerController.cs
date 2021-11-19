using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	// Public variables
	public float mouseSensitivity = 1f;
	public float walkSpeed = 60;
	public LayerMask groundedMask;

	// Scripts variables
	private Player playerInput;
	private CharacterController controller;
	private AtommInventory atommInventory;
	private SwitchPlayer switchPlayer;
	
	// System variables
	private bool grounded;
	private Vector3 moveAmount;
	private Vector3 smoothMoveVelocity;
	private float verticalLookRotation;
	private Transform cameraTransform;
	private Rigidbody rigidbody;

	
	private void OnEnable()
	{
		playerInput.Enable();
	}

	private void OnDisable()
	{
		playerInput.Disable();
	}

	void Awake() {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		cameraTransform = Camera.main.transform;
		rigidbody = GetComponent<Rigidbody> ();
		atommInventory = GetComponent<AtommInventory> ();

		switchPlayer = GameObject.Find("Ship").transform.GetComponent<SwitchPlayer> ();

		playerInput = new Player();
		controller = GetComponent<CharacterController>();
	}
	
	void Update() {
		// Open inventory on Tab keypress
		if (playerInput.PlayerMain.OpenInventory.triggered)
		{
			atommInventory.ActionInventory();
		}

		// Collect object on E keypress
		if (playerInput.PlayerMain.Collect.triggered)
		{
			atommInventory.CheckRaycast();
		}

		// Use spaceship on U keypress
		if (playerInput.PlayerMain.Use.triggered)
		{
			switchPlayer.UseSpaceship();
		}

		Rotate();
		Translate();		
	}

	private void Rotate()
	{
		//Get command input values
		Vector2 lookInput = playerInput.PlayerMain.Look.ReadValue<Vector2>(); 
		float lookX = lookInput.x * mouseSensitivity;

		// TODO: multiply Y value by -1 ofor mobile version
		float lookY = lookInput.y * mouseSensitivity;
        
		//Rotate player along Y axis
		transform.Rotate(0, lookX, 0, Space.Self);

    //Rotate camera verticaly
		verticalLookRotation += lookY;
		verticalLookRotation = Mathf.Clamp(verticalLookRotation,-60,60);
		cameraTransform.localEulerAngles = Vector3.left * verticalLookRotation;
	}

	private void Translate()
	{
		//Get command input values 
		Vector2 movementInput = playerInput.PlayerMain.Move.ReadValue<Vector2>();
		float inputX = movementInput.x * Time.deltaTime * walkSpeed;
		// TODO: multiply Y value by -1 ofor mobile version
		float inputY = movementInput.y * Time.deltaTime * walkSpeed;

		//Translate player 
		Vector3 moveDir = new Vector3(inputX, 0, inputY).normalized;
		Vector3 targetMoveAmount = moveDir * walkSpeed;
		moveAmount = Vector3.SmoothDamp(moveAmount,targetMoveAmount,ref smoothMoveVelocity,.15f);
	}
	
	private void FixedUpdate() {
		// Apply movement to rigidbody
		Vector3 localMove = transform.TransformDirection(moveAmount) * Time.fixedDeltaTime;
		rigidbody.MovePosition(rigidbody.position + localMove);
	}
}
