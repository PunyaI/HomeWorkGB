using System.Collections;
using static HomeWorkGB.Program;

namespace HomeWorkGB
{
    public class NodeList : ILinkedList
    {

        Node startNode;
        Node endNode;


        public void AddNode(int value)
        {
            var node = new Node(value);
            if (startNode == null)
            {
                startNode = node;
            }
            else
            {
                endNode.NextNode = node;
                node.PrevNode = endNode;
            }
            endNode = node;
        }

        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node(value);
            newNode.PrevNode = node;
            newNode.NextNode = node.NextNode;
            node.NextNode.PrevNode = newNode;
            node.NextNode = newNode;
        }

        public Node FindNode(int searchValue)
        {
            var node = startNode;
            while (node.NextNode != null)
            {
                if (node.Value == searchValue)
                {
                    return node;
                }
                node = node.NextNode;
            }
            return null;
        }

        public int GetCount()
        {
            var node = startNode;
            int count = 0;
            while (node.NextNode != null)
            {
                count++;
                node = node.NextNode;
            }
            return count + 1;
        }



        public void RemoveNode(int index)
        {
            if (index == 0)
            {
                startNode = startNode.NextNode;
                startNode.PrevNode = null;
            }
            int curindex = 0;
            var currentNode = startNode;
            while (currentNode != null)
            {
                if (curindex == index - 1)
                {
                    RemoveNode(currentNode);
                    return;
                }
                currentNode = currentNode.NextNode;
                curindex++;
            }
        }

        public void RemoveNode(Node node)
        {
            if (node == endNode)
            {
                endNode = node.PrevNode;
                endNode.NextNode = null;
                return;
            }
            var nextnode = node.NextNode;
            var prevnode = node.PrevNode;
            prevnode.NextNode = nextnode;
            nextnode.PrevNode = prevnode;
        }
        public IEnumerator GetEnumerator()
        {
            Node current = startNode;
            while (current != null)
            {
                yield return current.Value;
                current = current.NextNode;
            }
        }
    }
}
