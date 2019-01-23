using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{

    class AVL
    {
        public Node root;
        public AVL()
        {
        }

        public bool IsEmpty()
        {
            if (root == null)
            {
                return true;
            }
            return false;
        }

        public void Add(int data)
        {
            Node newItem = new Node(data);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                root = RecursiveInsert(root, newItem);
            }
        }

        private Node RecursiveInsert(Node current, Node n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (n.data < current.data)
            {
                current.left = RecursiveInsert(current.left, n);
                current = Balance_tree(current);
            }
            else if (n.data > current.data)
            {
                current.right = RecursiveInsert(current.right, n);
                current = Balance_tree(current);
            }
            return current;
        }

        private Node Balance_tree(Node current)
        {
            int b_factor = Balance_factor(current);
            if (b_factor > 1)
            {
                if (Balance_factor(current.left) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (Balance_factor(current.right) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }

        public void Delete(int target)
        {
            root = Delete(root, target);
        }

        public void Delete()
        {
            root = null;
        }

        private Node Delete(Node current, int target)
        {
            
            Node parent;
            if (current == null)
            { return null; }
            else
            {
                //left subtree
                if (target < current.data)
                {
                    current.left = Delete(current.left, target);
                    if (Balance_factor(current) == -2)//here
                    {
                        if (Balance_factor(current.right) <= 0)
                        {
                            current = RotateRR(current);
                        }
                        else
                        {
                            current = RotateRL(current);
                        }
                    }
                }
                //right subtree
                else if (target > current.data)
                {
                    current.right = Delete(current.right, target);
                    if (Balance_factor(current) == 2)
                    {
                        if (Balance_factor(current.left) >= 0)
                        {
                            current = RotateLL(current);
                        }
                        else
                        {
                            current = RotateLR(current);
                        }
                    }
                }
                //if target is found
                else
                {
                    if (current.right != null)
                    {
                        //delete its inorder successor
                        parent = current.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        current.data = parent.data;
                        current.right = Delete(current.right, parent.data);
                        if (Balance_factor(current) == 2)//rebalancing
                        {
                            if (Balance_factor(current.left) >= 0)
                            {
                                current = RotateLL(current);
                            }
                            else { current = RotateLR(current); }
                        }
                    }
                    else
                    {   //if current.left != null
                        return current.left;
                    }
                }
            }
            return current;
        }

        public Node Find(int key)
        {
            Node temp = null;
            try
            {
                if (Find(key, root, ref temp).data == key)
                {
                    if (temp != null)
                        return temp;
                    else return null;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Node Find(int target, Node current, ref Node res)
        {
            if (current == null)
                throw new Exception("Указанного элемента нет в дереве");
            res = null;
            if (target < current.data)
            {
                if (target == current.data)
                {
                    res = current;
                    return current;
                }
                else
                    return Find(target, current.left, ref res);
            }
            else
            {
                if (target == current.data)
                {
                    res = current;
                    return current;
                }
                else
                    return Find(target, current.right, ref res);
            }

        }

        private int Max(int l, int r)
        {
            return l > r ? l : r;
        }

        public int GetHeight(Node current)
        {
            int height = 0;
            if (current != null)
            {
                int l = GetHeight(current.left);
                int r = GetHeight(current.right);
                int m = Max(l, r);
                height = m + 1;
            }
            return height;
        }

        private int Balance_factor(Node current)
        {
            int l = GetHeight(current.left);
            int r = GetHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }

        private Node RotateRR(Node parent)
        {
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }

        private Node RotateLL(Node parent)
        {
            Node pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }

        private Node RotateLR(Node parent)
        {
            Node pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }

        private Node RotateRL(Node parent)
        {
            Node pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }
    }
}
