using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public static float getForward() {
        if(Input.GetKey(KeyCode.W)) {
            return 1f;
        }
        return 0;
        //Controller support
    }

    public static float getHorizontalTurn() {
        return Input.GetAxis("Mouse X");
    }

    public static float getVerticalTurn() {
        return Input.GetAxis("Mouse Y");
    }

    public static float getBackwards() {
        if(Input.GetKey(KeyCode.S)) {
            return 1f;
        }
        return 0;
        //Controller support
    }

    public static float getStrafeLeft() {
        if(Input.GetKey(KeyCode.A)) {
            return 1f;
        }
        return 0f;
        //Controller support
    }

    public static float getStrafeRight() {
        if(Input.GetKey(KeyCode.D)) {
            return 1f;
        }
        return 0f;
        //Controller support
    }

    public static bool getMainFire() {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            return true;
        }
        //Controller right trigger
        return false;
    }

    public static bool getSecondaryFire() {
        if(Input.GetKeyDown(KeyCode.Mouse1)) {
            return true;
        }
        //Controller left
        return false;
    }

    public static bool switchWeapons() {
        if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2)) {
            return true;
        }
        //Controller Y button
        return false;
    }

    public static bool jump() {
        if(Input.GetKey(KeyCode.Space)) {
            return true;
        }
        //Controller A button
        return false;
    }

    public static bool melee() {
        if(Input.GetKey(KeyCode.E)) {
            return true;
        }
        //Controller E button
        return false;
    }
}
