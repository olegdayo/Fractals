namespace Fractals
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            //Size.
            int a = 900;
            int b = 400;
            //Creating picture box.
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            //Creating buttons.
            this.snow = new System.Windows.Forms.Button();
            this.carpet = new System.Windows.Forms.Button();
            this.tree = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.set = new System.Windows.Forms.Button();
            this.oof = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            //Creating track bars.
            this.trackBarIter = new System.Windows.Forms.TrackBar();
            this.trackBarWidth = new System.Windows.Forms.TrackBar();
            //Creating labels for track bars.
            this.labelIter = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1.
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 750);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Snow.
            // 
            this.snow.Location = new System.Drawing.Point(a + 50, b);
            this.snow.Name = "Snow";
            this.snow.Size = new System.Drawing.Size(100, 38);
            this.snow.TabIndex = 2;
            this.snow.Text = "Snow";
            this.snow.UseVisualStyleBackColor = true;
            this.snow.Click += new System.EventHandler(this.snowButtonClick);
            // 
            // Carpet.
            // 
            this.carpet.Location = new System.Drawing.Point(a + 50, b + 38);
            this.carpet.Name = "Carpet";
            this.carpet.Size = new System.Drawing.Size(100, 38);
            this.carpet.TabIndex = 2;
            this.carpet.Text = "Carpet";
            this.carpet.UseVisualStyleBackColor = true;
            this.carpet.Click += new System.EventHandler(this.carpetButtonClick);
            // 
            // Tree.
            // 
            this.tree.Location = new System.Drawing.Point(a + 50, b + 76);
            this.tree.Name = "Tree";
            this.tree.Size = new System.Drawing.Size(100, 38);
            this.tree.TabIndex = 2;
            this.tree.Text = "Tree";
            this.tree.UseVisualStyleBackColor = true;
            this.tree.Click += new System.EventHandler(this.treeButtonClick);
            // 
            // Line.
            // 
            this.line.Location = new System.Drawing.Point(a + 50, b + 114);
            this.line.Name = "Line";
            this.line.Size = new System.Drawing.Size(100, 38);
            this.line.TabIndex = 2;
            this.line.Text = "Line";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.lineButtonClick);
            // 
            // Triangle.
            // 
            this.triangle.Location = new System.Drawing.Point(a + 50, b + 152);
            this.triangle.Name = "Triangle";
            this.triangle.Size = new System.Drawing.Size(100, 38);
            this.triangle.TabIndex = 2;
            this.triangle.Text = "Triangle";
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.triangleButtonClick);
            // 
            // Set.
            // 
            this.set.Location = new System.Drawing.Point(a + 50, b + 190);
            this.set.Name = "Set";
            this.set.Size = new System.Drawing.Size(100, 38);
            this.set.TabIndex = 2;
            this.set.Text = "Set";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.setButtonClick);
            // 
            // Oof.
            // 
            this.oof.Location = new System.Drawing.Point(a + 50, b + 228); //Ыыы 228.
            this.oof.Name = "Oof";
            this.oof.Size = new System.Drawing.Size(100, 38);
            this.oof.TabIndex = 2;
            this.oof.Text = "Oof";
            this.oof.UseVisualStyleBackColor = true;
            this.oof.Click += new System.EventHandler(this.oofButtonClick);
            //
            // buttonColor.
            //
            this.buttonColor.Location = new System.Drawing.Point(a + 50, 720);
            this.buttonColor.Name = "Color";
            this.buttonColor.Size = new System.Drawing.Size(100, 100);
            this.buttonColor.TabIndex = 2;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.colorButtonClick);
            //
            // saveButton.
            //
            this.saveButton.Location = new System.Drawing.Point(a + 50, 820);
            this.saveButton.Name = "Save";
            this.saveButton.Size = new System.Drawing.Size(100, 100);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            //
            // trackBarIter.
            //
            this.trackBarIter.Location = new System.Drawing.Point(a, 13);
            this.trackBarIter.Name = "Iter";
            this.trackBarIter.Size = new System.Drawing.Size(200, 10);
            trackBarIter.Maximum = 10;
            trackBarIter.TickFrequency = 1;
            trackBarIter.LargeChange = 2;
            trackBarIter.SmallChange = 1;
            this.trackBarIter.Scroll += new System.EventHandler(this.trackBarScrollIter);
            //
            // labelIter.
            //
            this.labelIter.Name = "Iter";
            this.labelIter.Text = "Depth of recursion";
            this.labelIter.Size = new System.Drawing.Size(200, 50);
            this.labelIter.Location = new System.Drawing.Point(a, 113);
            //
            // trackBarWidth.
            //
            this.trackBarWidth.Location = new System.Drawing.Point(a, 213);
            this.trackBarWidth.Name = "Width";
            this.trackBarWidth.Size = new System.Drawing.Size(200, 10);
            trackBarWidth.Maximum = 10;
            trackBarWidth.TickFrequency = 1;
            trackBarWidth.LargeChange = 2;
            trackBarWidth.SmallChange = 1;
            this.trackBarWidth.Scroll += new System.EventHandler(this.trackBarScrollWidth);
            //
            // labelWidth.
            //
            this.labelWidth.Name = "Width";
            this.labelWidth.Text = "Line width";
            this.labelWidth.Size = new System.Drawing.Size(200, 50);
            this.labelWidth.Location = new System.Drawing.Point(a + 45, 313);
            // 
            // Form1.
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1252, 992);
            //Adding everything.
            this.Controls.Add(this.snow);
            this.Controls.Add(this.carpet);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.line);
            this.Controls.Add(this.triangle);
            this.Controls.Add(this.set);
            this.Controls.Add(this.oof);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBarIter);
            this.Controls.Add(this.trackBarWidth);
            this.Controls.Add(this.labelIter);
            this.Controls.Add(this.labelWidth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        //Creating everything.
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button snow;
        private System.Windows.Forms.Button carpet;
        private System.Windows.Forms.Button tree;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.Button oof;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TrackBar trackBarIter;
        private System.Windows.Forms.TrackBar trackBarWidth;
        private System.Windows.Forms.Label labelIter;
        private System.Windows.Forms.Label labelWidth;
    }
}