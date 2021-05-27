using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductorConsumidor
{
    public partial class FORM_Home : Form
    {
        // Logic //

        Queue<int> container = new Queue<int>(20);

        int headIndex = -1;
        int tailIndex = -1;

        int emptyCells = 20;
        int occupiedCells = 0;


        // UI //

        Label[] labelArray;

        Color emptyCellColor = Color.FromName("Control");
        Color occupiedCellColor = Color.FromName("LightSkyBlue");

        public FORM_Home()
        {
            InitializeComponent();
            InitializeLabelArray();

        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            
        }

        // Logic //

        private void Queue()
        {
           if(container.Count == 20)
            {
                MessageBox.Show("CONTAINER LLENO");
                return;
            }

            headIndex++;
           
            if(headIndex > 19)
            {
                headIndex = 0;
            }

            if(container.Count == 1 && headIndex == 0)
            {
                tailIndex = headIndex;
            }

            if(container.Count == 0)
            {
                headIndex = 0;
                tailIndex = headIndex;
            }

            container.Enqueue(1);

            ChangeCellColor(headIndex, occupiedCellColor);
            ChangeCellCount(--emptyCells, ++occupiedCells);
        }

        private void Dequeue()
        {
            if (container.Count == 0)
            {
                MessageBox.Show("CONTAINER VACIO");
                return;
            }

            if(tailIndex > 19)
            {
                tailIndex = 0;
            }

            container.Dequeue();

            ChangeCellColor(tailIndex, emptyCellColor);

            tailIndex++;

            ChangeCellCount(++emptyCells, --occupiedCells);
        }

        // UI //

        private void InitializeLabelArray()
        {
            labelArray = new Label[20];

            for(int i = 0; i < 20; i++)
            {
                Label temp = (Label)Controls.Find($"LBL_{i}", true).First();
                labelArray[i] = temp;
            }
        }

        private void ChangeCellColor(int index, Color color)
        {
            labelArray[index].BackColor = color;
            this.Refresh();
        }

        private void ChangeCellCount(int emptyCells, int occupiedCells)
        {

            LBL_Count.Text = $"Vacios: {emptyCells}     Llenos: {occupiedCells}";
            this.Refresh();
        }
    }
}
