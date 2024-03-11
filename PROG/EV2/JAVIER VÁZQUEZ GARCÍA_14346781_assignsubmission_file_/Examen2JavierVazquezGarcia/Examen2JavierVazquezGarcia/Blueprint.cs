using System;

namespace Examen2JavierVazquezGarcia
{
    public delegate bool FilterDelegate(IShape shape);
    public class Blueprint : IBlueprint
    {
        List<IShape> shapes = new List<IShape>();
        public int ShapesCount => shapes.Count;
        public void AddShape(IShape shape)
        {
            if(shape == null)
                throw new Exception("Shape cannot be null");
            shapes.Add(shape);
        }

        public void Draw(ICanvas canvas)
        {
            // Javi: Y si canvas es null?
            for (int i = 0; i < ShapesCount; i++)
            {
                shapes[i].Draw(canvas);
            }
        }

        public List<IShape> GetShapes(FilterDelegate del)
        {
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Javi: MAL DE 0
            return shapes;
        }

        public IShape GetShapeWithName(string name)
        {
            if (name == null)
                throw new Exception("Name cannot be null");
            for (int i  = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Name == name)
                    return shapes[i];
            }
            return null;
        }

        public void RemoveShapeWithName(string name)
        {
            if (name == null)
                throw new Exception("Name cannot be null");
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].Name == name)
                    shapes.Remove(shapes[i]);
                // Javi: i--!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
            // Javi: No hace falta
            return;
        }
    }
}
