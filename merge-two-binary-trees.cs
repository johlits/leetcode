        }
        if (t1 != null && t2 == null) {
            return t1;
        }
        
        if (t1 == null && t2 == null) {
            return null;
        }
        t1.val += t2.val;
        if (t1.left == null && t2.left != null) {
            t1.left = t2.left;
        }
        else if (t1.left != null && t2.left != null) {
            t1.left = MergeTrees(t1.left, t2.left);
        }
        if (t1.right == null && t2.right != null) {
            t1.right = t2.right;
        }
        else if (t1.right != null && t2.right != null) {
            t1.right = MergeTrees(t1.right, t2.right);
        }
        return t1;
    }
}
