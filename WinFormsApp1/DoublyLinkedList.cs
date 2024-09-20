using System;

namespace WinFormsApp1
{
    internal class DoublyLinkedList
    {
        private Node head; // Puntero al primer nodo de la lista.

        // Constructor que inicializa la lista como vacía (head es null).
        public DoublyLinkedList()
        {
            head = null!;
        }

        // Método para insertar un nodo al principio de la lista.
        public void InsertAtStart(int data)
        {
            Node newNode = new Node(data); // Crear un nuevo nodo con el dato.
            if (head != null) // Si la lista no está vacía:
            {
                newNode.Next = head; // El siguiente del nuevo nodo será la antigua cabeza.
                head.Prev = newNode; // El nodo anterior de la antigua cabeza será el nuevo nodo.
            }
            head = newNode; // El nuevo nodo se convierte en la nueva cabeza de la lista.
        }

        // Método para insertar un nodo al final de la lista.
        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data); // Crear un nuevo nodo con el dato.
            if (head == null) // Si la lista está vacía:
            {
                head = newNode; // El nuevo nodo es la cabeza de la lista.
            }
            else
            {
                Node temp = head;
                // Recorrer la lista hasta el último nodo.
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode; // Enlazar el último nodo con el nuevo nodo.
                newNode.Prev = temp; // El nodo anterior del nuevo nodo será el anterior último nodo.
            }
        }

        // Método para insertar un nodo en una posición específica.
        public void InsertAtMiddle(int data, int position)
        {
            if (position == 1) // Si la posición es 1, insertar al inicio.
            {
                InsertAtStart(data);
                return;
            }

            Node newNode = new Node(data); // Crear un nuevo nodo con el dato.
            Node temp = head;

            // Recorrer la lista hasta la posición deseada (o la más cercana si no existe).
            for (int i = 1; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }

            if (temp == null) // Si se alcanzó el final de la lista, insertar al final.
            {
                InsertAtEnd(data);
                return;
            }

            // Insertar el nuevo nodo entre temp y el siguiente nodo.
            newNode.Next = temp.Next; // El siguiente del nuevo nodo es el siguiente de temp.
            newNode.Prev = temp; // El anterior del nuevo nodo es temp.

            if (temp.Next != null) // Si hay un nodo después de temp, ajustar su nodo anterior.
            {
                temp.Next.Prev = newNode;
            }
            temp.Next = newNode; // Enlazar temp con el nuevo nodo.
        }

        // Método para eliminar el primer nodo de la lista.
        public void DeleteFromStart()
        {
            if (head == null) // Si la lista está vacía, no hacer nada.
            {
                return;
            }

            if (head.Next != null) // Si hay más de un nodo en la lista:
            {
                head = head.Next; // La nueva cabeza es el siguiente nodo.
                head.Prev = null!; // El nodo anterior de la nueva cabeza es nulo.
            }
            else
            {
                head = null!; // Si solo había un nodo, la lista queda vacía.
            }
        }

        // Método para eliminar el último nodo de la lista.
        public void DeleteFromEnd()
        {
            if (head == null) // Si la lista está vacía, no hacer nada.
            {
                return;
            }

            if (head.Next == null) // Si solo hay un nodo:
            {
                head = null!; // Eliminar el nodo y dejar la lista vacía.
            }
            else
            {
                Node temp = head;
                // Recorrer la lista hasta el último nodo.
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Prev.Next = null!; // Eliminar el enlace al último nodo.
            }
        }

        // Método para eliminar un nodo en una posición específica.
        public void DeleteFromMiddle(int position)
        {
            if (head == null) // Si la lista está vacía, no hacer nada.
            {
                return;
            }

            if (position == 1) // Si la posición es 1, eliminar desde el inicio.
            {
                DeleteFromStart();
                return;
            }

            Node temp = head;

            // Recorrer la lista hasta la posición deseada.
            for (int i = 1; temp != null && i < position; i++)
            {
                temp = temp.Next;
            }

            if (temp == null) // Si no se encontró la posición, no hacer nada.
            {
                return;
            }

            // Ajustar los punteros de los nodos adyacentes para eliminar temp.
            if (temp.Next != null) // Si hay un nodo después de temp:
            {
                temp.Next.Prev = temp.Prev;
            }

            if (temp.Prev != null) // Si hay un nodo antes de temp:
            {
                temp.Prev.Next = temp.Next!; // Saltarse el nodo temp.
            }
        }

        // Método para obtener la cabeza de la lista.
        public Node GetHead()
        {
            return head; // Devolver la cabeza de la lista.
        }
    }
}
