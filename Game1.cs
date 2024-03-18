using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using tutorial1.Source;

namespace tutorial1;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private FrameCounter _frameCounter = new FrameCounter();
    public AssetManager assetManager;
    public ScreenManager screenManager;
    public InputManager input;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        _graphics.PreferredBackBufferHeight = Globals.screenHeight;
        _graphics.PreferredBackBufferWidth = Globals.screenWidth;
    }

    protected override void Initialize()
    {
        base.Initialize();
        assetManager = new AssetManager(this);
        input = new InputManager();
        screenManager = new ScreenManager(this, assetManager, input);
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        
    }

    protected override void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        screenManager.Update(gameTime);
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.White);
        _spriteBatch.Begin();
        var deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        _frameCounter.Update(deltaTime);
        var fps = string.Format("FPS: {0}", _frameCounter.AverageFramesPerSecond);
        _spriteBatch.DrawString(assetManager.font, fps, new Vector2(1, 1), Color.Black);
        screenManager.Draw(_spriteBatch);
        _spriteBatch.End();
        base.Draw(gameTime);
    }
}
