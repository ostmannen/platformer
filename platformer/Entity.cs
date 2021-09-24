using System;
using SFML.System;
using SFML.Window;
using SFML.Graphics;

namespace platformer
{
    public class Entity
    {
        private string textureName;
        protected Sprite sprite;
        public bool Dead;
        protected Entity(string textureName){

        }
        public Vector2f Position;
        public readonly FloatRect Bounds;
        public static void Create(Scene scene){

        }
        public static void Update(Scene scene, float deltaTime){

        }
        public static void render(RenderTarget target){
            
        }
        

    }
}
