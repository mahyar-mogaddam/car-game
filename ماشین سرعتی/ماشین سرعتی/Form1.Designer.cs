namespace ماشین_سرعتی
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picBarrier = new System.Windows.Forms.PictureBox();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBarrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            this.SuspendLayout();
            // 
            // picBarrier
            // 
            this.picBarrier.Image = global::ماشین_سرعتی.Properties.Resources.icons8_obstacle_50;
            this.picBarrier.Location = new System.Drawing.Point(1426, 180);
            this.picBarrier.Name = "picBarrier";
            this.picBarrier.Size = new System.Drawing.Size(100, 83);
            this.picBarrier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarrier.TabIndex = 1;
            this.picBarrier.TabStop = false;
            // 
            // picCar
            // 
            this.picCar.Image = global::ماشین_سرعتی.Properties.Resources.icons8_car_50;
            this.picCar.Location = new System.Drawing.Point(12, 180);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(100, 83);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar.TabIndex = 0;
            this.picCar.TabStop = false;
            this.picCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.picCar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1541, 274);
            this.Controls.Add(this.picBarrier);
            this.Controls.Add(this.picCar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBarrier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.PictureBox picBarrier;
        private System.Windows.Forms.Timer timer1;
    }
}

