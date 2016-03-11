using UnityEngine;
using System.Collections;
using XboxCtrlrInput;

public class InputManager : MonoBehaviour {

    public static float getForward() {
        if(Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S)) {
            return 1f;
        }
        if(!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S)) {
            return -1f;
        }
        if(Mathf.Abs(XCI.GetAxis(XboxAxis.LeftStickY))>0.05) {
            return XCI.GetAxis(XboxAxis.LeftStickY);
        }
        return 0;
    }
    

    public static float getHorizontalTurn() {
        if(Mathf.Abs(Input.GetAxis("Mouse X"))> 0.01) {
            return Input.GetAxis("Mouse X");
        }
        if(Mathf.Abs(XCI.GetAxis(XboxAxis.RightStickX))>0.01) {
            return XCI.GetAxis(XboxAxis.RightStickX);
        }
        return 0;
    }

    public static float getVerticalTurn() {
        if(Mathf.Abs(Input.GetAxis("Mouse Y"))> 0.01) {
            return Input.GetAxis("Mouse Y");
        }
        if(Mathf.Abs(XCI.GetAxis(XboxAxis.RightStickY))>0.01) {
            return XCI.GetAxis(XboxAxis.RightStickY);
        }
        return 0;
    }

    public static float getStrafe() {
        if(Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)) {
            return -1f;
        }
        if(!Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)) {
            return 1f;
        }
        if(Mathf.Abs(XCI.GetAxis(XboxAxis.LeftStickX))>0.05) {
            return XCI.GetAxis(XboxAxis.LeftStickX);
        }
        return 0f;
        //Controller support
    }

    public static bool getMainFire() {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            return true;
        }
        if(XCI.GetButtonDown(XboxButton.RightStick)) {
            return true;
        }
        //Controller right trigger
        return false;
    }

    public static bool getSecondaryFire() {
        if(Input.GetKeyDown(KeyCode.Mouse1)) {
            return true;
        }
        if(XCI.GetButtonDown(XboxButton.LeftStick)) {
            return true;
        }
        //Controller left
        return false;
    }

    public static bool switchWeapons() {
        if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2)) {
            return true;
        }
        if(XCI.GetButtonDown(XboxButton.Y)) {
            return true;
        }
        return false;
    }

    public static bool jump() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            return true;
        }
        if(XCI.GetButtonDown(XboxButton.A)) {
            return true;
        }
        return false;
    }

    public static bool melee() {
        if(Input.GetKey(KeyCode.E)) {
            return true;
        }
        if(XCI.GetButtonDown(XboxButton.B)) {
            return true;
        }
        return false;
    }
}
