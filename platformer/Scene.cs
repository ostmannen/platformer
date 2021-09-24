using System;
using SFML.System;
using SFML.Window;
using SFML.Graphics;
using System.Collections.Generic;

namespace platformer
{
    public class Scene
    {
        private Dictionary<string, Texture> textures = new Dictionary<string, Texture>();
        private List<Entity> entities = new List<Entity>();
        public static void spawn(Entity entity)
        {

        }
        public static Texture LoadTexture(string name){
            
        }
        public static void UpdateAll(float deltaTime){

        }
        public static void renderAll(RenderTarget target){

        }
    }
}
