using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Node<T>
    {
        public T element;
        public Tree<T> gauche;
        public Tree<T> droit;
        
        public Node(T value)
        {
            gauche = null;
            droit = null;
            element = value;
        }
    }
}
