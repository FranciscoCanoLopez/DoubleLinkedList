using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DoublyLinkedList list = new DoublyLinkedList(); // Lista doblemente enlazada.

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtData.Text, out int value))
            {
                list.Add(value); // Agregar en orden numérico.
                UpdateListView(); // Actualizar el ListView.
                MessageBox.Show($"Se agregó {value} a la lista.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
            }
            txtData.Clear(); // Limpiar el TextBox.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtData.Text, out int value))
            {
                list.Delete(value); // Eliminar el nodo con el valor.
                UpdateListView(); // Actualizar el ListView.
                MessageBox.Show($"Se eliminó {value} de la lista (si existía).");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
            }
            txtData.Clear(); // Limpiar el TextBox.
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtData.Text, out int value))
            {
                bool found = list.Search(value); // Buscar el valor.
                if (found)
                    MessageBox.Show($"El número {value} se encuentra en la lista.");
                else
                    MessageBox.Show($"El número {value} no se encuentra en la lista.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.");
            }
            txtData.Clear(); // Limpiar el TextBox.
        }

        private void UpdateListView()
        {
            lvDisplay.Items.Clear(); // Limpiar el ListView.
            Node current = list.GetHead(); // Obtener la cabeza de la lista.
            int position = 1; // Iniciar la posición desde 1.

            while (current != null)
            {
                // Crear un ítem de ListView con la posición como primer subitem.
                ListViewItem item = new ListViewItem(position.ToString());

                // Añadir el dato del nodo como segundo subitem.
                item.SubItems.Add(current.Data.ToString());

                // Agregar el ítem al ListView.
                lvDisplay.Items.Add(item);

                // Avanzar al siguiente nodo.
                current = current.Next;
                position++;
            }
        }
    }
}
