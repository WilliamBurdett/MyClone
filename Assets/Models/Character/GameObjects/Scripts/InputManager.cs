using UnityEngine;
using System.Collections;
using XboxCtrlrInput;

public class InputManager : MonoBehaviour {

    public static float getForward(XboxController controller) {
        if((int)controller==5) {
            if(Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S)) {
                return 1f;
            }
            if(!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S)) {
                return -1f;
            }
        }
        if(Mathf.Abs(XCI.GetAxis(XboxAxis.LeftStickY,controller))>0.05) {
            return XCI.GetAxis(XboxAxis.LeftStickY,controller);
        }
        return 0;
    }
    

    public static float getHorizontalTurn(XboxController controller) {
        if((int)controller==5) {
            if(Mathf.Abs(Input.GetAxis("Mouse X"))> 0.01) {
                return Input.GetAxis("Mouse X");
            }
        }
        if(Mathf.Abs(XCI.GetAxis(XboxAxis.RightStickX,controller))>0.01) {
            return XCI.GetAxis(XboxAxis.RightStickX,controller);
        }
        return 0;
    }

    public static float getVerticalTurn(XboxController controller) {
        if((int)controller==5) {
            if(Mathf.Abs(Input.GetAxis("Mouse Y"))> 0.01) {
                return Input.GetAxis("Mouse Y");
            }
        }
        if(Mathf.Abs(XCI.GetAxis(XboxAxis.RightStickY,controller))>0.01) {
            return XCI.GetAxis(XboxAxis.RightStickY,controller);
        }
        return 0;
    }

    public static float getStrafe(XboxController controller) {
        if((int)controller==5) {
            if(Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)) {
                return -1f;
            }
            if(!Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)) {
                return 1f;
            }
        }
        if(Mathf.Abs(XCI.GetAxis(XboxAxis.LeftStickX,controller))>0.05) {
            return XCI.GetAxis(XboxAxis.LeftStickX,controller);
        }
        return 0f;
        //Controller support
    }

    public static float getMainFire(XboxController controller) {
        if((int)controller==5) {
            if(Input.GetKeyDown(KeyCode.Mouse0)) {
                return 1f;
            }
        }
        if(XCI.GetAxis(XboxAxis.RightTrigger,controller)>0f) {
            return XCI.GetAxis(XboxAxis.RightTrigger,controller);
        }
        //Controller right trigger
        return 0f;
    }

    public static float getSecondaryFire(XboxController controller) {
        if((int)controller==5) {
            if(Input.GetKeyDown(KeyCode.Mouse1)) {
                return 1f;
            }
        }
        if(XCI.GetAxis(XboxAxis.LeftTrigger,controller)>0) {
            XCI.GetAxis(XboxAxis.LeftTrigger,controller);
        }
        //Controller left
        return 0f;
    }

    public static bool getSwitchWeapons(XboxController controller) {
        if((int)controller==5) {
            if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2)) {
                return true;
            }
        }
        if(XCI.GetButtonDown(XboxButton.Y,controller)) {
            return true;
        }
        return false;
    }

    public static bool getJump(XboxController controller) {
        if((int)controller==5) {
            if(Input.GetKeyDown(KeyCode.Space)) {
                return true;
            }
        }
        if(XCI.GetButtonDown(XboxButton.A,controller)) {
            return true;
        }
        return false;
    }

    public static bool getMelee(XboxController controller) {
        if((int)controller==5) {
            if(Input.GetKey(KeyCode.E)) {
                return true;
            }
        }
        if(XCI.GetButtonDown(XboxButton.B,controller)) {
            return true;
        }
        return false;
    }
}
