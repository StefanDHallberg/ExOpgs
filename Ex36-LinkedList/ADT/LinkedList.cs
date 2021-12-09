using System;
using System.Collections.Generic;

namespace ADT
{
    public class LinkedList
    {
        private class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }
            public override string ToString()
            {
                return Data.ToString();
            }
        }
        private Node head;
        //      head: privat felt, der peger på det første element (dvs.første instans af Node-klassen) i den lænkede liste.
        private int count;
        //      - count: privat felt, der angiver det aktuelle antal elementer (nodes) i den lænkede liste.
        //      + «get» Count: public property, der returnerer det aktuelle antal elementer i listen angivet i det private felt count; kan ikke sættes.
        public int Count
        {
            get { return count; }
        }
        public object First //Det første element har indeksværdien 0, 
        {
            get
            {
                if (count == 0)
                    return null;

                else
                    return ItemAt(0);
            }
        }
        public object Last //det sidste element værdien count-1. 
        {
            get
            {
                if (count == 0)
                    return null;

                else
                    return ItemAt(count - 1);
            }
        }
        private Node GetNodeAtIndex(int index)
        {
            Node CurrentNode = head;
            for (int i = 0; i <= index; i++)
            {
                if (i != index)
                    CurrentNode = CurrentNode.Next;
                else
                    break;
            }
            return CurrentNode;
        }



        public void InsertAt(int index, object o)
        {
            Node newNode = new Node();
            newNode.Data = o;

            if (count == 0)
                Insert(o);
            else
            {
                if (index <= count)
                {
                    Node prevNode = GetNodeAtIndex(index - 1);
                    newNode.Next = prevNode.Next;
                    prevNode.Next = newNode;
                    count++;
                }
                else
                    throw new IndexOutOfRangeException();

            }
        }

        //       InsertAt(index : int, o: object) : indsætter objektet på positionen angivet af index-parameteren; listen er 0-indekseret.
        //       Ønsker man at indsætte et element først i listen, angives 0 som index; hvis sidst i listen, angives værdien af Count som index.

        public void Insert(object o)
        {
            Node newNode = new Node();
            newNode.Data = o;

            newNode.Next = head;
            head = newNode;
            count++;
        }

        public void Append(object o)
        {
            Node newNode = new Node();
            newNode.Data = o;

            if (count == 0)
                Insert(o);
            else
            {
                Node prevNode = GetNodeAtIndex(count - 1);
                newNode.Next = prevNode.Next;
                prevNode.Next = newNode;
                count++;
            }
        }
        public void DeleteAt(int index)
        {
            if (index == 0)
            {
                head = head.Next;
                count--;
            }
            else
                if (index <= count)
            {
                Node prevNode = GetNodeAtIndex(index - 1);
                prevNode.Next = prevNode.Next.Next;
                count--;
            }
            else
                throw new IndexOutOfRangeException();
        }
        //      + DeleteAt(index : int): sletter det index’te element i listen (0-indekseret).
        public object ItemAt(int index)
        {
            object o;

            if (index == 0)
                o = head.Data;
            else
            {
                if (index <= count)
                {
                    Node currentnode = GetNodeAtIndex(index);
                    o = currentnode.Data;
                }
                else
                    throw new IndexOutOfRangeException();

            }
            return o;
        }
        //•	+ItemAt(index: int): returnerer data(af typen object) for det index’te element i listen(0 - indekseret).
        public override string ToString()
        {
            string result = head.Data.ToString();
            Node currentNode = head.Next;

            for (int i = 1; i < count; i++)
            {
                result += "\n" + currentNode.Data;
                currentNode = currentNode.Next;
            }
            return result;
        }
    }
}
//•	+ «override» ToString(): er en override af String() - metoden(fra Object - klassen), der beregner en string
//    repræsentation af hele listen ved at konkatenere alle ToString() - værdierne for hvert enkelt element i listen.
//    Hvis der er mere end ét element i listen, skal de enkelte tekstrepræsentationer for hvert objekt separeres med ”\n” (ny linje).
//    Se også senere i unit-testen, hvordan det skal se ud. 

