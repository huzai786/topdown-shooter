using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using tutorial1.States;

namespace tutorial1.Source;

public enum ScreenType {
    Splash,
    Menu,
    GamePlay,
}
public class ScreenManager {
    public AssetManager assetManager;
    public Game1 game;
    public Dictionary<ScreenType, ScreenBase> screens;
    public ScreenBase currentScreen;
    public InputManager input;

    public ScreenManager(Game1 game, AssetManager assetManager, InputManager input) {
        this.game = game;
        this.assetManager = assetManager;
        this.input = input;
        screens = new Dictionary<ScreenType, ScreenBase>() {
            {ScreenType.Splash, new SplashScreen(this, this.assetManager, this.input)},
            {ScreenType.GamePlay, new GameScreen(this, this.assetManager, this.input)},
        };
        currentScreen = screens[ScreenType.Splash];
    }

    public void Update(GameTime gameTime) {
        input.Update();
        currentScreen.Update(gameTime);
    
    }
    
    public void Draw(SpriteBatch spriteBatch) {
        currentScreen.Draw(spriteBatch);
    }
    public void ChangeScreen(ScreenType screenType) {
        currentScreen = screens[screenType];
    }

}