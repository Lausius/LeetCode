// var head = new ListNode(1,
//     new ListNode(2,
//         new ListNode(3,
//             new ListNode(4,
//                 new ListNode(5,
//                 new ListNode(6))
//             )
//         )
//     )
// );

// var head = new ListNode(1,
//     new ListNode(2)
// );

var head = new ListNode(65,
    new ListNode(66,
        new ListNode(26,
            new ListNode(77,
                new ListNode(96,
                    new ListNode(86,
                        new ListNode(11,
                            new ListNode(21,
                                new ListNode(13,
                                    new ListNode(80
                                        )
                                    )
                                )
                            )
                        )
                    )
                )
            )
        )
);

var solution = new Solution();
var result = solution.MiddleNode(head);
while (result != null)
{
    Console.WriteLine(result.val + " -> ");
    result = result.next;
}
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    // public ListNode MiddleNode(ListNode head)
    // {
    //     // traverse list
    //     var last = head;
    //     var nodeCount = 1;

    //     while (last.next != null)
    //     {
    //         last = last.next;
    //         nodeCount++;
    //     }

    //     if (nodeCount == 2)
    //     {
    //         return last;
    //     }

    //     var slicePoint = 0;

    //     // if uneven number
    //     if (nodeCount % 2 == 1)
    //     {
    //         slicePoint = (nodeCount + 1) / 2;
    //     }

    //     // if even number
    //     if (nodeCount % 2 == 0)
    //     {
    //         slicePoint = (nodeCount / 2) + 1; // if two middle nodes, return the second one.
    //     }

    //     var current = head;
    //     nodeCount = 1;
    //     while (current.next != null)
    //     {
    //         if (nodeCount == slicePoint)
    //         {
    //             return current;
    //         }

    //         current = current.next;
    //         nodeCount++;
    //     }

    //     return head;
    // }
    // public ListNode MiddleNode(ListNode head)
    // {
    //     int nodeCount = 0;
    //     ListNode current = head;

    //     // Count nodes in one pass
    //     while (current != null)
    //     {
    //         nodeCount++;
    //         current = current.next;
    //     }

    //     // Find the middle node in second pass
    //     int slicePoint = nodeCount / 2; // No need to add +1, index starts at 0
    //     Console.WriteLine(slicePoint);
    //     current = head;

    //     for (int i = 0; i < slicePoint; i++)
    //     {
    //         current = current.next;
    //     }

    //     return current;
    // }

    // Tortoise and Hare Algorithm (Most optimized)
    public ListNode MiddleNode(ListNode head)
    {
        ListNode middleNode = head;
        ListNode lastNode = head;

        while (lastNode != null && lastNode.next != null)
        {
            middleNode = middleNode.next;
            lastNode = lastNode.next.next;
        }

        return middleNode;
    }
}
