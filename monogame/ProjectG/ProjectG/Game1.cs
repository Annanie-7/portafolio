using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;

namespace ProjectG;

public class Game1 : Core
{
    private Texture2D _escenarioVotio;
    private Texture2D _votio;
    public Game1() : base("ProjectG", 1280, 720, false)
    {


    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _escenarioVotio = Content.Load<Texture2D>("Escenas/escenario1");
        _votio = Content.Load<Texture2D>("Animals/votio");
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        SpriteBatch.Begin();

        // Draw the logo texture
        SpriteBatch.Draw(_escenarioVotio,
            new Vector2(    // position
            (Window.ClientBounds.Width * 0.4f) - (_escenarioVotio.Width * 0.5f),
            (Window.ClientBounds.Height * 0.3f) - (_escenarioVotio.Height * 0.5f)),
            null,               // sourceRectangle
            Color.White,        // color
            0.0f,               // rotation
            Vector2.Zero,       // origin
            1.6f,               // scale
            SpriteEffects.None, // effects
            0.0f   // layerDepth
            );

        SpriteBatch.Draw(_votio,
            new Vector2(    // position
            Window.ClientBounds.Width * 0.4f ,
            Window.ClientBounds.Height * 0.6f),
            null,               // sourceRectangle
            Color.White,        // color
            0.0f,               // rotation
            Vector2.Zero,       // origin
            0.2f,               // scale
            SpriteEffects.None, // effects
            0.0f   // layerDepth
        );

        // Always end the sprite batch when finished.
        SpriteBatch.End();
        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
