public class Node<T>
{
    public T Data {get; set;}
    public Node<T> Next {get; set;}

    public Node (T data)
    {
        Data = data;
        Next = null;
    }
}

public class SinglyLinkedList<T>
{
    private Node<T> head;

    public SinglyLinkedList()
    {
        head = null;
    }

    public void AddFirst(T data)
    {
        Node<T> newNode = new Node<T>(data);

        newNode.Next = head;
        head = newNode;
    }

    public void RemoveFirst()
    {
        if(head == null)
        {
            return;
        }

        head = head.Next;
    }

    public void RemoveLast()
    {
        if(head == null)
        {
            return;
        }

        if(head.Next == null)
        {
            head = null;
            return;
        }

        Node<T> currentNode = head;
        while (currentNode.Next.Next != null)
        {
            currentNode = currentNode.Next;
        }

        currentNode.Next = null;
    }

    public void Remove(T data)
    {
        if(head == null)
        {
            return;
        }

        if(head.Data.Equals(data))
        {
            head = head.Next;
            return;
        }

        Node<T> currentNode = head;
        while(currentNode.Next != null && !currentNode.Next.Data.Equals(data))
        {
            currentNode = currentNode.Next;
        }

        if (currentNode.Next != null)
        {
            currentNode.Next = currentNode.Next.Next;
        }

        
    }

    public void CLear()
    {
        head = null;
    }

    public bool Contains (T data)
    {
        Node<T> currentNode = head;

        while (currentNode != null)
        {
            if (currentNode.Data.Equals(data))
            {
                return true;
            }
            currentNode = currentNode.Next;
        }

        return false;
    }
    
    public Node<T> Find (T data)
    {
        Node<T> currentNode = head;

        while (currentNode != null)
        {
            if(currentNode.Data.Equals(data))
            {
                return currentNode;
            }
            currentNode = currentNode.Next
        }
        return null;      
    }

    public void Traverse()
    {
        Node<T> currentNode = head;

        while (currentNode != null)
        {
            //Perform operation on the current node
            Console.Write(currentNode.Data + " ");

            // Move to the next node
            currentNode = currentNode.Next;
        }
    }
    


}