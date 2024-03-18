using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
namespace tutorial1.Source;


public class AssetManager {
    public SpriteFont font;
    public Texture2D splashScreen;
    public Game1 game;
    public ContentManager content;
    public AssetManager(Game1 game) {
        this.game = game;
        content = game.Content;
        font = content.Load<SpriteFont>("File");
        splashScreen = content.Load<Texture2D>("splash");
        
    }

}