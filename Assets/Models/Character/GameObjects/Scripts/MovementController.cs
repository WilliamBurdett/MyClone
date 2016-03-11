using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {
    private float horizontalBaseTurnSpeed =50000f;
    private float verticalBaseTurnSpeed = -500f;
    private float movementSpeed = 20f;
    private float jumpSpeed = 100f;
    private float stayOnGroundGravity = 1f;
    private Vector3 movementDirection;
    private CharacterController characterController;

    private bool jumping;
    private float currentAirTime;
    private float maxAirTime;
    private bool lastGrounded;
    private bool jumped;
    
    public Transform arm;

    // Use this for initialization
    void Start () {
        Cursor.lockState=CursorLockMode.Locked;
        Cursor.visible = true;

        characterController = gameObject.GetComponent<CharacterController>();

        maxAirTime = 0.25f;
        jumping = false;
    }

    void Update() {
        jumped = false;
        localTurnControl();
        jumped = InputManager.jump();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        movementDirection = Vector3.zero;

        localMovementControl();
        localJumpControl();
        
        characterController.Move(movementDirection * Time.fixedDeltaTime);


    }

    void localJumpControl() {
        if(characterController.isGrounded) {
            jumping = false;
            currentAirTime = maxAirTime;
        }
        jumpingControl();
        if(characterController.isGrounded) {
            movementDirection.y -= stayOnGroundGravity;
            if(jumped) {
                jumping = true;
                jumpingControl();
            }
        }
    }

    void jumpingControl() {
        if(jumping == true) {
            movementDirection.y = currentAirTime * jumpSpeed;
            currentAirTime -= Time.fixedDeltaTime;
        }
    }

    void localMovementControl() {
        movementDirection += transform.forward * InputManager.getForward();
        movementDirection += transform.right * InputManager.getStrafe();
        movementDirection *= movementSpeed;
    }


    void localTurnControl() {
        float horizontalSpeed = InputManager.getHorizontalTurn() * horizontalBaseTurnSpeed * Time.deltaTime;
        float verticalSpeed = InputManager.getVerticalTurn() * verticalBaseTurnSpeed * Time.deltaTime;
        arm.Rotate(new Vector3(verticalSpeed,0f,0f));
        transform.Rotate(new Vector3(0F,horizontalSpeed,0f)*Time.deltaTime);
    }
}