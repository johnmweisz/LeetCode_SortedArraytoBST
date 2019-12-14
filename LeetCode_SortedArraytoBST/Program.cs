using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_SortedArraytoBST
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0) return null;
            return RecursiveHelper(nums, 0, nums.Length - 1);
        }

        public TreeNode RecursiveHelper(int[] nums, int left, int right)
        {
            if (left > right) return null;
            var mid = left + (right - left) / 2;
            var node = new TreeNode(nums[mid])
            {
                left = RecursiveHelper(nums, left, mid - 1), right = RecursiveHelper(nums, mid + 1, right)
            };
            return node;
        }
    }
}
