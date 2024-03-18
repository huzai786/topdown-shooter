using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using tutorial1.Source;

namespace tutorial1.States;


public abstract class ScreenBase {
    public abstract void Update(GameTime gameTime);
    public abstract void HandleEvent();
    public abstract void Draw(SpriteBatch spriteBatch);
}
