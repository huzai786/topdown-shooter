using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using tutorial1.Source;

namespace tutorial1.States;


public class SplashScreen : ScreenBase
{
    public ScreenManager screenManager;
    public AssetManager assetManager;
    public InputManager input;
    public Rectangle screenRect;

    public SplashScreen(ScreenManager screenManager, AssetManager assetManager, InputManager input) {
        this.screenManager = screenManager;
        this.assetManager = assetManager;
        this.input = input;
        screenRect = new Rectangle(0,0,Globals.screenWidth, Globals.screenHeight);
    }
    public override void Update(GameTime gameTime) {
        HandleEvent();
    }
    public override void HandleEvent() {
        if (input.keyboardCurrent.IsKeyDown(Keys.Enter)) {
            screenManager.ChangeScreen(ScreenType.GamePlay);
        }
    }
    public override void Draw(SpriteBatch spriteBatch) {
        spriteBatch.Draw(assetManager.splashScreen, screenRect, Color.White );
    }

}