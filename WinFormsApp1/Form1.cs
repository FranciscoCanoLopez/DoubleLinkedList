using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DoublyLinkedList list = new DoublyLinkedList();

        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {
            lvDisplay.View = View.Details;
            lvDisplay.Columns.Add("Posición", 100, HorizontalAlignment.Left);
            lvDisplay.Columns.Add("Dato", 150, HorizontalAlignment.Left);
        }

        private void btnInsertStart_Click(object sender, EventArgs e)
        {
            try
            {
                int data = int.Parse(txtData.Text);
                list.InsertAtStart(data);
                UpdateDisplay();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnInsertEnd_Click(object sender, EventArgs e)
        {
            try
            {
                int data = int.Parse(txtData.Text);
                list.InsertAtEnd(data);
                UpdateDisplay();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnInsertMiddle_Click(object sender, EventArgs e)
        {
            try
            {
                int data = int.Parse(txtData.Text);
                int position = int.Parse(txtPosition.Text);
                list.InsertAtMiddle(data, position);
                UpdateDisplay();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

        private void btnDeleteStart_Click(object sender, EventArgs e)
        {
            list.DeleteFromStart();
            UpdateDisplay();
        }

        private void btnDeleteEnd_Click(object sender, EventArgs e)
        {
            list.DeleteFromEnd();
            UpdateDisplay();
        }

        private void btnDeleteMiddle_Click(object sender, EventArgs e)
        {
            try
            {
                int position = int.Parse(txtPosition.Text);
                list.DeleteFromMiddle(position);
                UpdateDisplay();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido para la posición.");
            }
        }

        private void UpdateDisplay()
        {
            txtData.Clear();
            txtPosition.Clear();
            lvDisplay.Items.Clear(); // Limpiar elementos anteriores
            Node temp = list.GetHead(); // Asumimos que tienes un método GetHead en DoublyLinkedList
            int position = 1;
            while (temp != null)
            {
                var listViewItem = new ListViewItem(position.ToString());
                listViewItem.SubItems.Add(temp.Data.ToString());
                lvDisplay.Items.Add(listViewItem);
                temp = temp.Next;
                position++;
            }

        }
    }
}
