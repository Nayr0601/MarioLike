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
    class Player : GameObject
    {
        //Fields


        //Methods
        public override void Update(GameTime gameTime)
        {
            KeyboardState state = Keyboard.GetState();
            
            if (state.IsKeyDown(Keys.A))
            {
                
            }
        }
    }
}
