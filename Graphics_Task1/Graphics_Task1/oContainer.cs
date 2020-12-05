using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_Task1
{
    public class oContainer : IEnumerable
    {
        Dictionary<oShape, Type> data = new Dictionary<oShape, Type>(); // data[0] is Shapes-container, data[1] is Types-container
        IEnumerator IEnumerable.GetEnumerator()
        {
            return data.Keys.GetEnumerator();
        }
        public void Add(oShape shape, Type type)
        {
            data.Add(shape, type);
            ShapeAdded?.Invoke();
        }
        public int Count
        {
            get { return data.Count; }
        }
        public KeyValuePair<oShape, Type> this[int index]
        {
            get { return data.ToArray()[index]; }
        }
        
        public delegate void OnShapeAdded();
        public event OnShapeAdded ShapeAdded;
    }
}
