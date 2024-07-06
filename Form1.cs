using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string[] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            array = txtInput.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show("Array ingresado.");
        }

        private void btnMostrarDesordenado_Click(object sender, EventArgs e)
        {
            // Mostrar el array desordenado
            listBoxOutput.Items.Clear();
            foreach (var item in array)
            {
                listBoxOutput.Items.Add(item);
            }
        }

        private void btnMostrarOrdenado_Click(object sender, EventArgs e)
        {
            // Ordenar el array usando recursividad y mostrarlo
            var sortedArray = SortArray(array);
            listBoxOutput.Items.Clear();
            foreach (var item in sortedArray)
            {
                listBoxOutput.Items.Add(item);
            }
        }
        private string[] SortArray(string[] arr)
        {
            // Implementar la recursión para ordenar el array
            if (arr.Length <= 1)
            {
                return arr;
            }

            var pivot = arr[0];
            var less = arr.Skip(1).Where(x => string.Compare(x, pivot) <= 0).ToArray();
            var greater = arr.Skip(1).Where(x => string.Compare(x, pivot) > 0).ToArray();

            return SortArray(less).Concat(new[] { pivot }).Concat(SortArray(greater)).ToArray();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
