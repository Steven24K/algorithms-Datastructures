namespace algorithms_Datastructures.BinaryTree
{
    using System;

    public class MyTree
    {
        private Node root;
        private int count;
        public MyTree()
        {
            root = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Insert(int value)
        {
            if (this.IsEmpty())
            {
                root = new Node(value);
            }else{
                root.Insert(ref root, value);
            }
            count++;
        }

        public bool IsLeaf()
        {
            if(!this.IsEmpty())return this.root.IsLeaf(ref this.root);

            return true;
        }

        public void PretyPrint()
        {
            if(!this.IsEmpty())this.root.PretyPrint(this.root);
        }
    }
    public class Node
    {
        private int value;
        public Node right;
        public Node left;

        public Node(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }

        public bool IsLeaf(ref Node node){return(node.right == null && node.left == null);}

        public void Insert(ref Node node, int value)
        {
            if (node == null){
                node = new Node(value);
            }else if(node.value < value){
                Insert(ref node.right, value);
            }else if(node.value > value){
                Insert(ref node.left, value);
            }
        }

        public bool Search(Node node, int value)
        {
            if (node == null)return false;
            
            if (node.value == value){
                return true;
            }else if(node.value < value){
                return Search(node.right, value);
            }else if(node.value > value){
                return Search(node.left, value);
            }

            return false;
        }

        public void PretyPrint(Node node)
        {
            if(node == null)return;
            PretyPrint(node.left);
            System.Console.WriteLine(" " + node.value.ToString());
            PretyPrint(node.right);
        }
    }
}