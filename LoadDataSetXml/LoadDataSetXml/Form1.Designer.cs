﻿namespace LoadDataSetXml
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
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.LoadSchemaButton = new System.Windows.Forms.Button();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Location = new System.Drawing.Point(1, 169);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.Size = new System.Drawing.Size(797, 180);
            this.OrdersGrid.TabIndex = 1;
            // 
            // LoadSchemaButton
            // 
            this.LoadSchemaButton.Location = new System.Drawing.Point(13, 371);
            this.LoadSchemaButton.Name = "LoadSchemaButton";
            this.LoadSchemaButton.Size = new System.Drawing.Size(118, 23);
            this.LoadSchemaButton.TabIndex = 2;
            this.LoadSchemaButton.Text = "Load Schema";
            this.LoadSchemaButton.UseVisualStyleBackColor = true;
            this.LoadSchemaButton.Click += new System.EventHandler(this.LoadSchemaButton_Click);
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(663, 371);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(116, 23);
            this.LoadDataButton.TabIndex = 3;
            this.LoadDataButton.Text = "Load Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Location = new System.Drawing.Point(1, 1);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.Size = new System.Drawing.Size(797, 162);
            this.CustomersGrid.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomersGrid);
            this.Controls.Add(this.LoadDataButton);
            this.Controls.Add(this.LoadSchemaButton);
            this.Controls.Add(this.OrdersGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.Button LoadSchemaButton;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.DataGridView CustomersGrid;
    }
}

