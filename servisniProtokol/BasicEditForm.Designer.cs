using System.ComponentModel;

namespace servisniProtokol;

partial class BasicEditForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        Number_textBox = new System.Windows.Forms.TextBox();
        Date_dateTimePicker = new System.Windows.Forms.DateTimePicker();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(13, 13);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 0;
        label1.Text = "Protocol number:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(13, 39);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(114, 23);
        label2.TabIndex = 1;
        label2.Text = "Measurement date:";
        // 
        // Number_textBox
        // 
        Number_textBox.Location = new System.Drawing.Point(158, 10);
        Number_textBox.Name = "Number_textBox";
        Number_textBox.Size = new System.Drawing.Size(201, 23);
        Number_textBox.TabIndex = 2;
        // 
        // Date_dateTimePicker
        // 
        Date_dateTimePicker.Location = new System.Drawing.Point(159, 39);
        Date_dateTimePicker.Name = "Date_dateTimePicker";
        Date_dateTimePicker.Size = new System.Drawing.Size(200, 23);
        Date_dateTimePicker.TabIndex = 3;
        // 
        // BasicEditForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(371, 69);
        Controls.Add(Date_dateTimePicker);
        Controls.Add(Number_textBox);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "BasicEditForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox Number_textBox;
    private System.Windows.Forms.DateTimePicker Date_dateTimePicker;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}