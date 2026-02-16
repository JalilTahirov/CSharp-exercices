<Query Kind="Statements" />

        
		
		// Create a sample BST:
        //         8
        //       /   \
        //      3     10
        //     / \      \
        //    1   6      14
        //       /
        //      4
        TreeNode root = new TreeNode(8);
        root.left = new TreeNode(3);
        root.right = new TreeNode(10);
        root.left.left = new TreeNode(1);
        root.left.right = new TreeNode(6);
        root.left.right.left = new TreeNode(4);
        root.right.right = new TreeNode(14);
		
		
		class TreeNode
		{
			public int val;
			public TreeNode left;
		    public TreeNode right;
			public TreeNode(int val)
			{
				this.val = val;
				this.left = null;
				this.right = null;
			}
		}
