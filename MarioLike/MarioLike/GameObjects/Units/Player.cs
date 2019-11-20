using MarioLike.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioLike
{
    class Player : Unit
    {
        //Fields

        //Constructor
        public Player()
        {
            speed = 200;
        }


        //Methods
        public override void Update(GameTime gameTime)
        {
            HandleInput();
            Move(gameTime);
        }

        private void HandleInput()
        {
            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.A))
            {
                velocity.X += -1;
            }
            if (state.IsKeyDown(Keys.D))
            {
                velocity.X += 1;
            }
            if (state.IsKeyDown(Keys.Space))
            {
                //jump
            }
        }


    }
}
