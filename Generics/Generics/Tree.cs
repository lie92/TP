using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Tree<T>
    {
        public Node<T> node;
        private CompType comp_type;
        public delegate int CompType(T a, T b);
        public Tree(CompType comp, T value)
        {
            comp_type = comp;
            node = new Node<T>(value);
        }
        public delegate void MapFunction(ref T elt);
        
        
        public void depth_first_traversal(MapFunction function)
        {
            function(ref node.element);
            if(node.gauche != null)
            {
                node.gauche.depth_first_traversal(function);
            }
            if(node.droit != null)
            {
                node.droit.depth_first_traversal(function);
            }
        }

        public void breadth_first_traversal(MapFunction function)
        {
            function(ref node.element);
            Queue<Tree<T>> parcours = new Queue<Tree<T>>();
            parcours.Enqueue(this);
            do
            {
                Tree<T> tree = parcours.Dequeue();
                if(tree.node.gauche != null)
                {
                    parcours.Enqueue(tree.node.gauche);
                }
                if(tree.node.droit != null)
                {
                    parcours.Enqueue(tree.node.droit);
                }
            }
            while (parcours.Count != 0);
        }

        private delegate bool BinFunc(ref Node<T> node, T val);

        private bool binary_traversal(ref Node<T> node, T val, BinFunc null_case, BinFunc equal_case)
        {
            if ((dynamic)node.element < val)
            {
                binary_traversal(node.gauche.node, val, null_case , null);
            }
            else
            {
                //binary_traversal();
            }
        }
    }
}
