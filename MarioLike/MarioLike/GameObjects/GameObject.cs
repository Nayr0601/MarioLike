﻿using Microsoft.Xna.Framework;
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


        //Methods
        public abstract void Update(GameTime gameTime);
    }
}