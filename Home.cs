using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductorConsumidor
{
    public partial class FORM_Home : Form
    {
        // Config //

        static int containerCapacity = 20;

        int minSleepTime = 1000;
        int maxSleepTime = 5000;

        bool updateNumberOnDequeue = false;
        Color emptyCellColor = Color.FromName("Control");
        Color occupiedCellColor = Color.FromName("LightSkyBlue");
        String directionOfVisualization = "LTR"; // Left To Right (LTR) or Right To Left (RTL)

        // Logic //

        Queue<int> container = new Queue<int>(containerCapacity);

        int headIndex = -1;
        int tailIndex = -1;

        int emptyCells = containerCapacity;
        int occupiedCells = 0;

        Random getRandomNumber = new Random();

        bool workingOnContainerFlag = false;
        int amountToProduce = 0;
        int amountToConsume = 0;

        int producerSleepingTime = 0;
        int consumerSleepingTime = 0;

        // UI //

        Label[] labelArray;

        public FORM_Home()
        {
            InitializeComponent();
            InitializeLabelArray(directionOfVisualization);
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            BW_Producer.RunWorkerAsync();
            BW_Consumer.RunWorkerAsync();
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

                if (updateNumberOnDequeue)
                {
                    UpdateNumbers();
                }
            }

            container.Enqueue(1);
            BW_Producer.ReportProgress(1);
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

        private void UpdateProducerInfo(String state)
        {
            LBL_ProducerStatus.Text = state;
        }

        // BACKGROUND WORKER - PRODUCER //
        private void BW_Producer_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!IsFull() && !workingOnContainerFlag)
                {
                    amountToProduce = getRandomNumber.Next(1, emptyCells);
                    BW_Producer.ReportProgress(2);

                    for(int i = 0; i < amountToProduce; i++)
                    {
                        Queue();
                        Thread.Sleep(300);
                    }
                }
                else
                {
                    BW_Producer.ReportProgress(4);
                    Thread.Sleep(1000);
                }

                producerSleepingTime = getRandomNumber.Next(minSleepTime, maxSleepTime);
                BW_Producer.ReportProgress(3);

                Thread.Sleep(producerSleepingTime);
            }
        }

        private void BW_Producer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int state = e.ProgressPercentage;

            switch (state)
            {
                case 1:
                    ChangeCellColor(headIndex, occupiedCellColor);
                    ChangeCellCount(--emptyCells, ++occupiedCells);
                    break;
                case 2:
                    UpdateProducerInfo($"PRODUCIENDO {amountToProduce} ELEMENTOS");
                    break;
                case 3:
                    UpdateProducerInfo($"DURMIENDO POR {producerSleepingTime/1000} SEGUNDOS");
                    break;
                case 4:
                    UpdateProducerInfo($"DESPERTÓ E INTENTÓ PRODUCIR, PERO EL CONTENEDOR ESTÁ LLENO");
                    break;
            }
        }

        private void BW_Producer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        
        // BACKGROUND WORKER - CONSUMER //
        private void BW_Consumer_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void BW_Consumer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void BW_Consumer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
