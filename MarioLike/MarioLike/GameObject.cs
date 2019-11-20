using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioLike.GameObjects
{
    public abstract class GameObject
    {
        //Fields
        protected Vector2 velocity;
        protected Vector2 position;
        protected float speed;
        protected Texture2D sprite;


        //Methods
        public abstract void Update(GameTime gameTime);

        protected virtual void LoadContent(ContentManager content)
        {
            //load your game content here
            sprite = content.Load<Texture2D>("Individual Sprites/adventurer-idle-00");
        }

        protected void Move(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            position += velocity * speed * deltaTime;
        }
    }
}
