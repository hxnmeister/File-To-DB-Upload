namespace Домашня_робота
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StorageDataGridView = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.StorageProductsPictureBox = new System.Windows.Forms.PictureBox();
            this.LoadPictureButton = new System.Windows.Forms.Button();
            this.ShowOneButton = new System.Windows.Forms.Button();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.ProductSerialNumberTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StorageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorageProductsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StorageDataGridView
            // 
            this.StorageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageDataGridView.Location = new System.Drawing.Point(12, 12);
            this.StorageDataGridView.Name = "StorageDataGridView";
            this.StorageDataGridView.Size = new System.Drawing.Size(400, 426);
            this.StorageDataGridView.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // StorageProductsPictureBox
            // 
            this.StorageProductsPictureBox.Location = new System.Drawing.Point(418, 12);
            this.StorageProductsPictureBox.Name = "StorageProductsPictureBox";
            this.StorageProductsPictureBox.Size = new System.Drawing.Size(400, 426);
            this.StorageProductsPictureBox.TabIndex = 1;
            this.StorageProductsPictureBox.TabStop = false;
            // 
            // LoadPictureButton
            // 
            this.LoadPictureButton.Location = new System.Drawing.Point(825, 164);
            this.LoadPictureButton.Name = "LoadPictureButton";
            this.LoadPictureButton.Size = new System.Drawing.Size(56, 40);
            this.LoadPictureButton.TabIndex = 2;
            this.LoadPictureButton.Text = "Load Picture";
            this.LoadPictureButton.UseVisualStyleBackColor = true;
            this.LoadPictureButton.Click += new System.EventHandler(this.LoadPictureButton_Click);
            // 
            // ShowOneButton
            // 
            this.ShowOneButton.Location = new System.Drawing.Point(825, 210);
            this.ShowOneButton.Name = "ShowOneButton";
            this.ShowOneButton.Size = new System.Drawing.Size(56, 40);
            this.ShowOneButton.TabIndex = 3;
            this.ShowOneButton.Text = "Show One";
            this.ShowOneButton.UseVisualStyleBackColor = true;
            this.ShowOneButton.Click += new System.EventHandler(this.ShowOneButton_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(825, 256);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(56, 40);
            this.ShowAllButton.TabIndex = 4;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // ProductSerialNumberTextBox
            // 
            this.ProductSerialNumberTextBox.Location = new System.Drawing.Point(825, 138);
            this.ProductSerialNumberTextBox.Name = "ProductSerialNumberTextBox";
            this.ProductSerialNumberTextBox.Size = new System.Drawing.Size(56, 20);
            this.ProductSerialNumberTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.ProductSerialNumberTextBox);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.ShowOneButton);
            this.Controls.Add(this.LoadPictureButton);
            this.Controls.Add(this.StorageProductsPictureBox);
            this.Controls.Add(this.StorageDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StorageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorageProductsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StorageDataGridView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox StorageProductsPictureBox;
        private System.Windows.Forms.Button LoadPictureButton;
        private System.Windows.Forms.Button ShowOneButton;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.TextBox ProductSerialNumberTextBox;
    }
}

