﻿namespace SectionConverterPlugin.Forms
{
    partial class ExportSectionsDataForm
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
            this.retb_FactValue = new SectionConverterPlugin.CustomControls.RegExedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_mistake = new System.Windows.Forms.Label();
            this.cb_ActualValueMistake = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ExportPoints = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // retb_FactValue
            // 
            this.retb_FactValue.Enabled = false;
            this.retb_FactValue.Location = new System.Drawing.Point(0, 0);
            this.retb_FactValue.Margin = new System.Windows.Forms.Padding(0);
            this.retb_FactValue.MatchOnKeyInput = false;
            this.retb_FactValue.Name = "retb_FactValue";
            this.retb_FactValue.Silent = true;
            this.retb_FactValue.Size = new System.Drawing.Size(191, 21);
            this.retb_FactValue.TabIndex = 0;
            this.retb_FactValue.Value = null;
            this.retb_FactValue.ValueChanged += new System.EventHandler(this.retb_FactValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ошибка фактических значений";
            // 
            // label_mistake
            // 
            this.label_mistake.AutoSize = true;
            this.label_mistake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mistake.Location = new System.Drawing.Point(3, 30);
            this.label_mistake.Name = "label_mistake";
            this.label_mistake.Size = new System.Drawing.Size(156, 16);
            this.label_mistake.TabIndex = 3;
            this.label_mistake.Text = "Учитывать ошибку Ф.З";
            // 
            // cb_ActualValueMistake
            // 
            this.cb_ActualValueMistake.AutoSize = true;
            this.cb_ActualValueMistake.Location = new System.Drawing.Point(315, 33);
            this.cb_ActualValueMistake.Name = "cb_ActualValueMistake";
            this.cb_ActualValueMistake.Size = new System.Drawing.Size(15, 14);
            this.cb_ActualValueMistake.TabIndex = 2;
            this.cb_ActualValueMistake.UseVisualStyleBackColor = true;
            this.cb_ActualValueMistake.CheckedChanged += new System.EventHandler(this.cb_FactValueMistake_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.Controls.Add(this.retb_FactValue, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(315, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(266, 24);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_mistake, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_ActualValueMistake, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 396);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btn_ExportPoints
            // 
            this.btn_ExportPoints.Location = new System.Drawing.Point(3, 3);
            this.btn_ExportPoints.Name = "btn_ExportPoints";
            this.btn_ExportPoints.Size = new System.Drawing.Size(615, 31);
            this.btn_ExportPoints.TabIndex = 7;
            this.btn_ExportPoints.Text = "Экспорт";
            this.btn_ExportPoints.UseVisualStyleBackColor = true;
            this.btn_ExportPoints.Click += new System.EventHandler(this.btn_ExportPoints_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btn_ExportPoints, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 403);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(621, 37);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // ExportSectionsDataForm
            // 
            this.AcceptButton = this.btn_ExportPoints;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportSectionsDataForm";
            this.ShowIcon = false;
            this.Text = "Экспорт сечений";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RegExedTextBox retb_FactValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_mistake;
        private System.Windows.Forms.CheckBox cb_ActualValueMistake;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_ExportPoints;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}