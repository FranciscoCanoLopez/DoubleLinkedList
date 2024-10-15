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

        // Método para agregar un nodo manteniendo el orden numérico ascendente.
        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (head == null || head.Data >= data) // Insertar al inicio si está vacía o el valor es menor.
            {
                newNode.Next = head!;
                if (head != null) head.Prev = newNode;
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null && current.Next.Data < data)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next!;
                if (current.Next != null) current.Next.Prev = newNode;
                current.Next = newNode;
                newNode.Prev = current;
            }
        }

        // Método para eliminar un nodo por su valor.
        public void Delete(int data)
        {
            if (head == null) // Si la lista está vacía, no hacer nada.
                return;

            Node current = head;

            // Buscar el nodo con el valor especificado.
            while (current != null && current.Data != data)
            {
                current = current.Next;
            }

            if (current == null) // Si no se encontró el valor, salir.
                return;

            // Ajustar los punteros de los nodos adyacentes.
            if (current.Prev != null)
            {
                current.Prev.Next = current.Next;
            }
            else
            {
                head = current.Next; // Si el nodo a eliminar es la cabeza, mover la cabeza.
            }

            if (current.Next != null)
            {
                current.Next.Prev = current.Prev!;
            }
        }

        // Método para buscar un número en la lista.
        public bool Search(int data)
        {
            Node current = head;

            // Recorrer la lista buscando el dato.
            while (current != null)
            {
                if (current.Data == data)
                    return true;
                current = current.Next;
            }
            return false; // Retornar false si no se encontró el dato.
        }
        public Node GetHead()
        {
            return head;
        }
    }
}
