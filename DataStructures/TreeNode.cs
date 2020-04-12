using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class TreeNode
    {
        private int _data;
        private TreeNode _left, _right;

        public TreeNode(int data)
        {
            _data = data;
        }

        public void Insert(int value)
        {
            if(value <= _data)
            {
                if(_left == null)
                {
                    _left = new TreeNode(value);
                }
                else
                {
                    _left.Insert(value);
                }
            }
            else
            {
                if(_right == null)
                {
                    _right = new TreeNode(value);
                }
                else
                {
                    _right.Insert(value);
                }
            }
        }

        public bool Contains(int value)
        {
            if (_data == value)
                return true;
            else if(value < _data)
            {
                if (_left == null)
                    return false;
                else
                    return _left.Contains(value);
            }
            else
            {
                if (_right == null)
                    return false;
                else
                    return _right.Contains(value);
            }
            
        }

        public void PrintInOrder()
        {
            if (_left != null)
                _left.PrintInOrder();
            Console.WriteLine(_data.ToString());
            if (_right != null)
                _right.PrintInOrder();
        }
    }
}
