
namespace appLoteria
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbcartas = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcartas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbcartas);
            this.groupBox1.Location = new System.Drawing.Point(632, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cartas";
            // 
            // pbcartas
            // 
            this.pbcartas.Location = new System.Drawing.Point(9, 19);
            this.pbcartas.Name = "pbcartas";
            this.pbcartas.Size = new System.Drawing.Size(220, 290);
            this.pbcartas.TabIndex = 4;
            this.pbcartas.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(995, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 336);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(226, 296);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(878, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 97);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "restan";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 78);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Siguiente carta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(983, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 80);
            this.button2.TabIndex = 3;
            this.button2.Text = "Barajear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            this.imageList1.Images.SetKeyName(1, "2.jpg");
            this.imageList1.Images.SetKeyName(2, "3.jpg");
            this.imageList1.Images.SetKeyName(3, "4.jpg");
            this.imageList1.Images.SetKeyName(4, "5.jpg");
            this.imageList1.Images.SetKeyName(5, "6.jpg");
            this.imageList1.Images.SetKeyName(6, "7.jpg");
            this.imageList1.Images.SetKeyName(7, "8.jpg");
            this.imageList1.Images.SetKeyName(8, "9.jpg");
            this.imageList1.Images.SetKeyName(9, "10.jpg");
            this.imageList1.Images.SetKeyName(10, "11.jpg");
            this.imageList1.Images.SetKeyName(11, "12.jpg");
            this.imageList1.Images.SetKeyName(12, "13.jpg");
            this.imageList1.Images.SetKeyName(13, "14.jpg");
            this.imageList1.Images.SetKeyName(14, "15.jpg");
            this.imageList1.Images.SetKeyName(15, "16.jpg");
            this.imageList1.Images.SetKeyName(16, "17.jpg");
            this.imageList1.Images.SetKeyName(17, "18.jpg");
            this.imageList1.Images.SetKeyName(18, "19.jpg");
            this.imageList1.Images.SetKeyName(19, "20.jpg");
            this.imageList1.Images.SetKeyName(20, "21.jpg");
            this.imageList1.Images.SetKeyName(21, "22.jpg");
            this.imageList1.Images.SetKeyName(22, "23.jpg");
            this.imageList1.Images.SetKeyName(23, "24.jpg");
            this.imageList1.Images.SetKeyName(24, "25.jpg");
            this.imageList1.Images.SetKeyName(25, "26.jpg");
            this.imageList1.Images.SetKeyName(26, "27.jpg");
            this.imageList1.Images.SetKeyName(27, "28.jpg");
            this.imageList1.Images.SetKeyName(28, "29.jpg");
            this.imageList1.Images.SetKeyName(29, "30.jpg");
            this.imageList1.Images.SetKeyName(30, "31.jpg");
            this.imageList1.Images.SetKeyName(31, "32.jpg");
            this.imageList1.Images.SetKeyName(32, "33.jpg");
            this.imageList1.Images.SetKeyName(33, "34.jpg");
            this.imageList1.Images.SetKeyName(34, "35.jpg");
            this.imageList1.Images.SetKeyName(35, "36.jpg");
            this.imageList1.Images.SetKeyName(36, "37.jpg");
            this.imageList1.Images.SetKeyName(37, "38.jpg");
            this.imageList1.Images.SetKeyName(38, "39.jpg");
            this.imageList1.Images.SetKeyName(39, "40.jpg");
            this.imageList1.Images.SetKeyName(40, "41.jpg");
            this.imageList1.Images.SetKeyName(41, "42.jpg");
            this.imageList1.Images.SetKeyName(42, "43.jpg");
            this.imageList1.Images.SetKeyName(43, "44.jpg");
            this.imageList1.Images.SetKeyName(44, "45.jpg");
            this.imageList1.Images.SetKeyName(45, "46.jpg");
            this.imageList1.Images.SetKeyName(46, "47.jpg");
            this.imageList1.Images.SetKeyName(47, "48.jpg");
            this.imageList1.Images.SetKeyName(48, "49.jpg");
            this.imageList1.Images.SetKeyName(49, "50.jpg");
            this.imageList1.Images.SetKeyName(50, "51.jpg");
            this.imageList1.Images.SetKeyName(51, "52.jpg");
            this.imageList1.Images.SetKeyName(52, "53.jpg");
            this.imageList1.Images.SetKeyName(53, "54.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.From_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbcartas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbcartas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
    }
}

