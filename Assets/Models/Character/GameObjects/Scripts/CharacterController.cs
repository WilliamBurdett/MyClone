using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
    private float horizontalBaseTurnSpeed =50000f;
    private float verticalBaseTurnSpeed = 5000f;
    private float movementSpeed = 20f;

    // Use this for initialization
    void Start () {
        Cursor.lockState=CursorLockMode.Locked;
        Cursor.visible = true;
    }
	
	// Update is called once per frame
	void Update () {
        localMovementControl();
    }

    void localMovementControl() {
        transform.Translate(Vector3.forward*(InputManager.getForward()+(-1*InputManager.getBackwards()))*Time.deltaTime*movementSpeed);
        transform.Translate(Vector3.right*(InputManager.getStrafeRight()+(-1*InputManager.getStrafeLeft()))*Time.deltaTime*movementSpeed);
        float horizontalSpeed = InputManager.getHorizontalTurn() * horizontalBaseTurnSpeed * Time.deltaTime;
        float verticalSpeed = InputManager.getVerticalTurn() * verticalBaseTurnSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0F,horizontalSpeed,0f)*Time.deltaTime);
    }
}
