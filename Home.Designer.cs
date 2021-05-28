
namespace ProductorConsumidor
{
    partial class FORM_Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GB_Container = new System.Windows.Forms.GroupBox();
            this.LBL_Count = new System.Windows.Forms.Label();
            this.LBL_19 = new System.Windows.Forms.Label();
            this.LBL_18 = new System.Windows.Forms.Label();
            this.LBL_17 = new System.Windows.Forms.Label();
            this.LBL_16 = new System.Windows.Forms.Label();
            this.LBL_15 = new System.Windows.Forms.Label();
            this.LBL_14 = new System.Windows.Forms.Label();
            this.LBL_13 = new System.Windows.Forms.Label();
            this.LBL_12 = new System.Windows.Forms.Label();
            this.LBL_11 = new System.Windows.Forms.Label();
            this.LBL_10 = new System.Windows.Forms.Label();
            this.LBL_9 = new System.Windows.Forms.Label();
            this.LBL_8 = new System.Windows.Forms.Label();
            this.LBL_7 = new System.Windows.Forms.Label();
            this.LBL_6 = new System.Windows.Forms.Label();
            this.LBL_5 = new System.Windows.Forms.Label();
            this.LBL_4 = new System.Windows.Forms.Label();
            this.LBL_3 = new System.Windows.Forms.Label();
            this.LBL_2 = new System.Windows.Forms.Label();
            this.LBL_1 = new System.Windows.Forms.Label();
            this.LBL_0 = new System.Windows.Forms.Label();
            this.GB_Producer = new System.Windows.Forms.GroupBox();
            this.LBL_ProducerInfo = new System.Windows.Forms.Label();
            this.LBL_ProducerStatus = new System.Windows.Forms.Label();
            this.GB_Consumer = new System.Windows.Forms.GroupBox();
            this.LBL_ConsumerInfo = new System.Windows.Forms.Label();
            this.LBL_ConsumerStatus = new System.Windows.Forms.Label();
            this.GB_Flags = new System.Windows.Forms.GroupBox();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.BW_Producer = new System.ComponentModel.BackgroundWorker();
            this.BW_Consumer = new System.ComponentModel.BackgroundWorker();
            this.GB_Container.SuspendLayout();
            this.GB_Producer.SuspendLayout();
            this.GB_Consumer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Container
            // 
            this.GB_Container.Controls.Add(this.LBL_Count);
            this.GB_Container.Controls.Add(this.LBL_19);
            this.GB_Container.Controls.Add(this.LBL_18);
            this.GB_Container.Controls.Add(this.LBL_17);
            this.GB_Container.Controls.Add(this.LBL_16);
            this.GB_Container.Controls.Add(this.LBL_15);
            this.GB_Container.Controls.Add(this.LBL_14);
            this.GB_Container.Controls.Add(this.LBL_13);
            this.GB_Container.Controls.Add(this.LBL_12);
            this.GB_Container.Controls.Add(this.LBL_11);
            this.GB_Container.Controls.Add(this.LBL_10);
            this.GB_Container.Controls.Add(this.LBL_9);
            this.GB_Container.Controls.Add(this.LBL_8);
            this.GB_Container.Controls.Add(this.LBL_7);
            this.GB_Container.Controls.Add(this.LBL_6);
            this.GB_Container.Controls.Add(this.LBL_5);
            this.GB_Container.Controls.Add(this.LBL_4);
            this.GB_Container.Controls.Add(this.LBL_3);
            this.GB_Container.Controls.Add(this.LBL_2);
            this.GB_Container.Controls.Add(this.LBL_1);
            this.GB_Container.Controls.Add(this.LBL_0);
            this.GB_Container.Location = new System.Drawing.Point(207, 407);
            this.GB_Container.Name = "GB_Container";
            this.GB_Container.Size = new System.Drawing.Size(851, 166);
            this.GB_Container.TabIndex = 0;
            this.GB_Container.TabStop = false;
            this.GB_Container.Text = "Contenedor";
            // 
            // LBL_Count
            // 
            this.LBL_Count.Location = new System.Drawing.Point(21, 122);
            this.LBL_Count.Name = "LBL_Count";
            this.LBL_Count.Size = new System.Drawing.Size(809, 28);
            this.LBL_Count.TabIndex = 20;
            this.LBL_Count.Text = "Vacios: 20     Llenos: 0";
            this.LBL_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_19
            // 
            this.LBL_19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_19.Location = new System.Drawing.Point(795, 37);
            this.LBL_19.Name = "LBL_19";
            this.LBL_19.Size = new System.Drawing.Size(35, 70);
            this.LBL_19.TabIndex = 19;
            this.LBL_19.Text = "20";
            this.LBL_19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_18
            // 
            this.LBL_18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_18.Location = new System.Drawing.Point(754, 37);
            this.LBL_18.Name = "LBL_18";
            this.LBL_18.Size = new System.Drawing.Size(35, 70);
            this.LBL_18.TabIndex = 18;
            this.LBL_18.Text = "19";
            this.LBL_18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_17
            // 
            this.LBL_17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_17.Location = new System.Drawing.Point(713, 37);
            this.LBL_17.Name = "LBL_17";
            this.LBL_17.Size = new System.Drawing.Size(35, 70);
            this.LBL_17.TabIndex = 17;
            this.LBL_17.Text = "18";
            this.LBL_17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_16
            // 
            this.LBL_16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_16.Location = new System.Drawing.Point(672, 37);
            this.LBL_16.Name = "LBL_16";
            this.LBL_16.Size = new System.Drawing.Size(35, 70);
            this.LBL_16.TabIndex = 16;
            this.LBL_16.Text = "17";
            this.LBL_16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_15
            // 
            this.LBL_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_15.Location = new System.Drawing.Point(631, 37);
            this.LBL_15.Name = "LBL_15";
            this.LBL_15.Size = new System.Drawing.Size(35, 70);
            this.LBL_15.TabIndex = 15;
            this.LBL_15.Text = "16";
            this.LBL_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_14
            // 
            this.LBL_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_14.Location = new System.Drawing.Point(590, 37);
            this.LBL_14.Name = "LBL_14";
            this.LBL_14.Size = new System.Drawing.Size(35, 70);
            this.LBL_14.TabIndex = 14;
            this.LBL_14.Text = "15";
            this.LBL_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_13
            // 
            this.LBL_13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_13.Location = new System.Drawing.Point(549, 37);
            this.LBL_13.Name = "LBL_13";
            this.LBL_13.Size = new System.Drawing.Size(35, 70);
            this.LBL_13.TabIndex = 13;
            this.LBL_13.Text = "14";
            this.LBL_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_12
            // 
            this.LBL_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_12.Location = new System.Drawing.Point(508, 37);
            this.LBL_12.Name = "LBL_12";
            this.LBL_12.Size = new System.Drawing.Size(35, 70);
            this.LBL_12.TabIndex = 12;
            this.LBL_12.Text = "13";
            this.LBL_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_11
            // 
            this.LBL_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_11.Location = new System.Drawing.Point(467, 37);
            this.LBL_11.Name = "LBL_11";
            this.LBL_11.Size = new System.Drawing.Size(35, 70);
            this.LBL_11.TabIndex = 11;
            this.LBL_11.Text = "12";
            this.LBL_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_10
            // 
            this.LBL_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_10.Location = new System.Drawing.Point(426, 37);
            this.LBL_10.Name = "LBL_10";
            this.LBL_10.Size = new System.Drawing.Size(35, 70);
            this.LBL_10.TabIndex = 10;
            this.LBL_10.Text = "11";
            this.LBL_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_9
            // 
            this.LBL_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_9.Location = new System.Drawing.Point(385, 37);
            this.LBL_9.Name = "LBL_9";
            this.LBL_9.Size = new System.Drawing.Size(35, 70);
            this.LBL_9.TabIndex = 9;
            this.LBL_9.Text = "10";
            this.LBL_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_8
            // 
            this.LBL_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_8.Location = new System.Drawing.Point(344, 37);
            this.LBL_8.Name = "LBL_8";
            this.LBL_8.Size = new System.Drawing.Size(35, 70);
            this.LBL_8.TabIndex = 8;
            this.LBL_8.Text = "9";
            this.LBL_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_7
            // 
            this.LBL_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_7.Location = new System.Drawing.Point(303, 37);
            this.LBL_7.Name = "LBL_7";
            this.LBL_7.Size = new System.Drawing.Size(35, 70);
            this.LBL_7.TabIndex = 7;
            this.LBL_7.Text = "8";
            this.LBL_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_6
            // 
            this.LBL_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_6.Location = new System.Drawing.Point(262, 37);
            this.LBL_6.Name = "LBL_6";
            this.LBL_6.Size = new System.Drawing.Size(35, 70);
            this.LBL_6.TabIndex = 6;
            this.LBL_6.Text = "7";
            this.LBL_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_5
            // 
            this.LBL_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_5.Location = new System.Drawing.Point(221, 37);
            this.LBL_5.Name = "LBL_5";
            this.LBL_5.Size = new System.Drawing.Size(35, 70);
            this.LBL_5.TabIndex = 5;
            this.LBL_5.Text = "6";
            this.LBL_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_4
            // 
            this.LBL_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_4.Location = new System.Drawing.Point(180, 37);
            this.LBL_4.Name = "LBL_4";
            this.LBL_4.Size = new System.Drawing.Size(35, 70);
            this.LBL_4.TabIndex = 4;
            this.LBL_4.Text = "5";
            this.LBL_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_3
            // 
            this.LBL_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_3.Location = new System.Drawing.Point(139, 37);
            this.LBL_3.Name = "LBL_3";
            this.LBL_3.Size = new System.Drawing.Size(35, 70);
            this.LBL_3.TabIndex = 3;
            this.LBL_3.Text = "4";
            this.LBL_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_2
            // 
            this.LBL_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_2.Location = new System.Drawing.Point(98, 37);
            this.LBL_2.Name = "LBL_2";
            this.LBL_2.Size = new System.Drawing.Size(35, 70);
            this.LBL_2.TabIndex = 2;
            this.LBL_2.Text = "3";
            this.LBL_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_1
            // 
            this.LBL_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_1.Location = new System.Drawing.Point(57, 37);
            this.LBL_1.Name = "LBL_1";
            this.LBL_1.Size = new System.Drawing.Size(35, 70);
            this.LBL_1.TabIndex = 1;
            this.LBL_1.Text = "2";
            this.LBL_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_0
            // 
            this.LBL_0.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_0.Location = new System.Drawing.Point(16, 37);
            this.LBL_0.Name = "LBL_0";
            this.LBL_0.Size = new System.Drawing.Size(35, 70);
            this.LBL_0.TabIndex = 0;
            this.LBL_0.Text = "1";
            this.LBL_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GB_Producer
            // 
            this.GB_Producer.Controls.Add(this.LBL_ProducerInfo);
            this.GB_Producer.Controls.Add(this.LBL_ProducerStatus);
            this.GB_Producer.Location = new System.Drawing.Point(207, 100);
            this.GB_Producer.Name = "GB_Producer";
            this.GB_Producer.Size = new System.Drawing.Size(256, 268);
            this.GB_Producer.TabIndex = 1;
            this.GB_Producer.TabStop = false;
            this.GB_Producer.Text = "Productor";
            // 
            // LBL_ProducerInfo
            // 
            this.LBL_ProducerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_ProducerInfo.Location = new System.Drawing.Point(16, 196);
            this.LBL_ProducerInfo.Name = "LBL_ProducerInfo";
            this.LBL_ProducerInfo.Size = new System.Drawing.Size(221, 50);
            this.LBL_ProducerInfo.TabIndex = 22;
            this.LBL_ProducerInfo.Text = "Info";
            this.LBL_ProducerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_ProducerStatus
            // 
            this.LBL_ProducerStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_ProducerStatus.Location = new System.Drawing.Point(16, 48);
            this.LBL_ProducerStatus.Name = "LBL_ProducerStatus";
            this.LBL_ProducerStatus.Size = new System.Drawing.Size(221, 148);
            this.LBL_ProducerStatus.TabIndex = 21;
            this.LBL_ProducerStatus.Text = "Status";
            this.LBL_ProducerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GB_Consumer
            // 
            this.GB_Consumer.Controls.Add(this.LBL_ConsumerInfo);
            this.GB_Consumer.Controls.Add(this.LBL_ConsumerStatus);
            this.GB_Consumer.Location = new System.Drawing.Point(802, 100);
            this.GB_Consumer.Name = "GB_Consumer";
            this.GB_Consumer.Size = new System.Drawing.Size(256, 268);
            this.GB_Consumer.TabIndex = 23;
            this.GB_Consumer.TabStop = false;
            this.GB_Consumer.Text = "Consumidor";
            // 
            // LBL_ConsumerInfo
            // 
            this.LBL_ConsumerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_ConsumerInfo.Location = new System.Drawing.Point(16, 196);
            this.LBL_ConsumerInfo.Name = "LBL_ConsumerInfo";
            this.LBL_ConsumerInfo.Size = new System.Drawing.Size(221, 50);
            this.LBL_ConsumerInfo.TabIndex = 22;
            this.LBL_ConsumerInfo.Text = "Info";
            this.LBL_ConsumerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_ConsumerStatus
            // 
            this.LBL_ConsumerStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_ConsumerStatus.Location = new System.Drawing.Point(16, 48);
            this.LBL_ConsumerStatus.Name = "LBL_ConsumerStatus";
            this.LBL_ConsumerStatus.Size = new System.Drawing.Size(221, 148);
            this.LBL_ConsumerStatus.TabIndex = 21;
            this.LBL_ConsumerStatus.Text = "Status";
            this.LBL_ConsumerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GB_Flags
            // 
            this.GB_Flags.Location = new System.Drawing.Point(504, 145);
            this.GB_Flags.Name = "GB_Flags";
            this.GB_Flags.Size = new System.Drawing.Size(256, 178);
            this.GB_Flags.TabIndex = 24;
            this.GB_Flags.TabStop = false;
            this.GB_Flags.Text = "Semáforos";
            // 
            // BTN_Start
            // 
            this.BTN_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Start.FlatAppearance.BorderSize = 0;
            this.BTN_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Start.Location = new System.Drawing.Point(571, 614);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(123, 35);
            this.BTN_Start.TabIndex = 25;
            this.BTN_Start.Text = "INICIAR";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // BW_Producer
            // 
            this.BW_Producer.WorkerReportsProgress = true;
            this.BW_Producer.WorkerSupportsCancellation = true;
            this.BW_Producer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_Producer_DoWork);
            this.BW_Producer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BW_Producer_ProgressChanged);
            this.BW_Producer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_Producer_RunWorkerCompleted);
            // 
            // BW_Consumer
            // 
            this.BW_Consumer.WorkerReportsProgress = true;
            this.BW_Consumer.WorkerSupportsCancellation = true;
            this.BW_Consumer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_Consumer_DoWork);
            this.BW_Consumer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BW_Consumer_ProgressChanged);
            this.BW_Consumer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_Consumer_RunWorkerCompleted);
            // 
            // FORM_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.GB_Flags);
            this.Controls.Add(this.GB_Consumer);
            this.Controls.Add(this.GB_Producer);
            this.Controls.Add(this.GB_Container);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FORM_Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productor-Consumidor";
            this.GB_Container.ResumeLayout(false);
            this.GB_Producer.ResumeLayout(false);
            this.GB_Consumer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Container;
        private System.Windows.Forms.Label LBL_19;
        private System.Windows.Forms.Label LBL_18;
        private System.Windows.Forms.Label LBL_17;
        private System.Windows.Forms.Label LBL_16;
        private System.Windows.Forms.Label LBL_15;
        private System.Windows.Forms.Label LBL_14;
        private System.Windows.Forms.Label LBL_13;
        private System.Windows.Forms.Label LBL_12;
        private System.Windows.Forms.Label LBL_11;
        private System.Windows.Forms.Label LBL_10;
        private System.Windows.Forms.Label LBL_9;
        private System.Windows.Forms.Label LBL_8;
        private System.Windows.Forms.Label LBL_7;
        private System.Windows.Forms.Label LBL_6;
        private System.Windows.Forms.Label LBL_5;
        private System.Windows.Forms.Label LBL_4;
        private System.Windows.Forms.Label LBL_3;
        private System.Windows.Forms.Label LBL_2;
        private System.Windows.Forms.Label LBL_1;
        private System.Windows.Forms.Label LBL_0;
        private System.Windows.Forms.Label LBL_Count;
        private System.Windows.Forms.GroupBox GB_Producer;
        private System.Windows.Forms.Label LBL_ProducerInfo;
        private System.Windows.Forms.Label LBL_ProducerStatus;
        private System.Windows.Forms.GroupBox GB_Consumer;
        private System.Windows.Forms.Label LBL_ConsumerInfo;
        private System.Windows.Forms.Label LBL_ConsumerStatus;
        private System.Windows.Forms.GroupBox GB_Flags;
        private System.Windows.Forms.Button BTN_Start;
        private System.ComponentModel.BackgroundWorker BW_Producer;
        private System.ComponentModel.BackgroundWorker BW_Consumer;
    }
}

