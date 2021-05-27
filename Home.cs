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
        // Config //

        static int containerCapacity = 20;

        bool updateNumberOnDequeue = true;
        Color emptyCellColor = Color.FromName("Control");
        Color occupiedCellColor = Color.FromName("LightSkyBlue");
        String directionOfVisualization = "LTR"; // Left To Right (LTR) or Right To Left (RTL)

        // Logic //

        Queue<int> container = new Queue<int>(containerCapacity);

        int headIndex = -1;
        int tailIndex = -1;

        int emptyCells = containerCapacity;
        int occupiedCells = 0;


        // UI //

        Label[] labelArray;

        public FORM_Home()
        {
            InitializeComponent();
            InitializeLabelArray(directionOfVisualization);
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {

        }

        // Logic //

        private bool IsEmpty()
        {
            return (container.Count == 0) ? true : false;
        }

        private bool IsFull()
        {
            return (container.Count == containerCapacity) ? true : false;
        }

        private void Queue()
        {
            if (container.Count == containerCapacity)
            {
                return;
            }

            headIndex++;

            if (headIndex > containerCapacity - 1)
            {
                headIndex = 0;
            }

            if (container.Count == 1 && headIndex == 0)
            {
                tailIndex = headIndex;
            }

            if (container.Count == 0)
            {
                headIndex = 0;
                tailIndex = headIndex;
                UpdateNumbers();
            }

            container.Enqueue(1);

            ChangeCellColor(headIndex, occupiedCellColor);
            ChangeCellCount(--emptyCells, ++occupiedCells);
        }

        private void Dequeue()
        {
            if (container.Count == 0)
            {
                return;
            }

            if (tailIndex > containerCapacity - 1)
            {
                tailIndex = 0;
            }

            container.Dequeue();

            ChangeCellColor(tailIndex, emptyCellColor);

            tailIndex++;

            if(container.Count == 0)
            {
                headIndex = 0;
                tailIndex = headIndex;
                UpdateNumbers();
            }

            ChangeCellCount(++emptyCells, --occupiedCells);

            if (updateNumberOnDequeue)
            {
                UpdateNumbers();
            }
        }

        // UI //

        private void InitializeLabelArray(String direction)
        {
            labelArray = new Label[containerCapacity];

            if (direction == "LTR")
            {
                for (int i = 0; i < containerCapacity; i++)
                {
                    Label temp = (Label)Controls.Find($"LBL_{i}", true).First();
                    temp.Text = (i + 1).ToString();
                    labelArray[i] = temp;
                }
            }

            else if (direction == "RTL")
            {
                int aux = containerCapacity - 1;

                for (int i = 0; i < containerCapacity; i++)
                {
                    Label temp = (Label)Controls.Find($"LBL_{aux}", true).First();
                    temp.Text = (i + 1).ToString();
                    labelArray[i] = temp;
                    aux--;
                }
            }
        }

        private void ChangeCellColor(int index, Color color)
        {
            labelArray[index].BackColor = color;
            this.Refresh();
        }
        private void ChangeCellNumber(int index, String number)
        {
            labelArray[index].Text = number;
            this.Refresh();
        }
        private void ChangeCellCount(int emptyCells, int occupiedCells)
        {

            LBL_Count.Text = $"Vacios: {emptyCells}     Llenos: {occupiedCells}";
            this.Refresh();
        }
        private void UpdateNumbers()
        {
            int counter = 1;
            int index = tailIndex;

            while (counter <= containerCapacity)
            {
                if (index > containerCapacity - 1)
                {
                    index = 0;
                }

                ChangeCellNumber(index, counter.ToString());

                index++;
                counter++;
            }
        }

        private void QUE_Click(object sender, EventArgs e)
        {
            Queue();
        }

        private void DEQ_Click(object sender, EventArgs e)
        {
            Dequeue();
        }
    }
}
