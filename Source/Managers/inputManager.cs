using Microsoft.Xna.Framework.Input;

namespace tutorial1;


public class InputManager {
    public MouseState mouseCurrent;
    public MouseState mousePrev;
    public KeyboardState keyboardCurrent;
    public KeyboardState keyboardPrev;

    public bool mousePressed;
    public bool mouseClicked;

    public void Update() {
        keyboardCurrent = Keyboard.GetState();
        mouseCurrent = Mouse.GetState(); 
        if (mouseCurrent.LeftButton == ButtonState.Pressed) {
            mousePressed = true;
            if (mousePrev.LeftButton == ButtonState.Released) {
                mouseClicked = true;
            } else {
                mouseClicked = false;
            }
        } else {
            mousePressed = false;
        }
        mousePrev = mouseCurrent;
    }
}