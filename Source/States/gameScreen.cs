using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using tutorial1.Source;

namespace tutorial1.States;


public class GameScreen : ScreenBase
{
    public ScreenManager screenManager;
    public AssetManager assetManager;
    public InputManager input;
    
    public GameScreen(ScreenManager screenManager, AssetManager assetManager, InputManager input) {
        this.screenManager = screenManager;
        this.assetManager = assetManager;
        this.input = input;
    }

    public override void Update(GameTime gameTime) {

    }
    public override void HandleEvent() {

    }
    public override void Draw(SpriteBatch spriteBatch) {

    }

}