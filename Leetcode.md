### 19. Remove Nth Node From End of List

> [leetcode link](https://leetcode.com/problems/remove-nth-node-from-end-of-list/)
> Given the head of a linked list, remove the nth node from the end of the list and return its head.
> Example 1:
> Input: head = [1,2,3,4,5], n = 2
> Output: [1,2,3,5]

#### version 1
```
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {

        // HEAD > 1 > 2 > 3
        // we can go throught the linked list 2 times 
        // 1st to determine the length
        // 2nd time to find the Nth element
        var dummy = new ListNode(0,head);
        int length = 0;
        if(head.next == null && n == 1)
            return null;
        var curr = dummy;
        while(curr!=null)
        {
            curr = curr.next;
            length++;    
        }
        curr = dummy;
        for(int i = 0; i < (length - n - 1); i++)
        {
            curr = curr.next;
        }
        curr.next = curr.next.next;
        return dummy.next;
        // or one time fast and slow pointer 
    }
}
```
#### version 2 with fast and slow

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        //fast and slow pointer 
        var dummy = new ListNode(0, head);
        var fast = dummy;
        var slow = dummy;
        int c = 0;
        while(c < n+1)
        {
            fast = fast.next;
            c++;
        }
        
        while(fast!=null)
        {
            slow = slow.next;
            fast = fast.next;
        }
        slow.next = slow.next.next;
        return dummy.next;
    }
}



