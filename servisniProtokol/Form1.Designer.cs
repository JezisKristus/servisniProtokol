namespace servisniProtokol;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        basicInfo = new System.Windows.Forms.GroupBox();
        ProtocolNumber_lbl = new System.Windows.Forms.Label();
        DateOfMeasurement_lbl = new System.Windows.Forms.Label();
        BasicEdit_btn = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        CustomerEdit_btn = new System.Windows.Forms.Button();
        PSC_lbl = new System.Windows.Forms.Label();
        IC_lbl = new System.Windows.Forms.Label();
        Name_lbl = new System.Windows.Forms.Label();
        Address_lbl = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        groupBox2 = new System.Windows.Forms.GroupBox();
        MachineEdit_btn = new System.Windows.Forms.Button();
        SerialNumber_lbl = new System.Windows.Forms.Label();
        Manufacturer_lbl = new System.Windows.Forms.Label();
        Model_lbl = new System.Windows.Forms.Label();
        label12 = new System.Windows.Forms.Label();
        label13 = new System.Windows.Forms.Label();
        label14 = new System.Windows.Forms.Label();
        groupBox3 = new System.Windows.Forms.GroupBox();
        MeasurementAdd_btn = new System.Windows.Forms.Button();
        MeasurementEdit_btn = new System.Windows.Forms.Button();
        MeasurementDelete_btn = new System.Windows.Forms.Button();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        Meas_parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Meas_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Meas_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Meas_valid = new System.Windows.Forms.DataGridViewTextBoxColumn();
        Export_btn = new System.Windows.Forms.Button();
        Preview_btn = new System.Windows.Forms.Button();
        Save_btn = new System.Windows.Forms.Button();
        Load_btn = new System.Windows.Forms.Button();
        basicInfo.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // basicInfo
        // 
        basicInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        basicInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        basicInfo.Controls.Add(ProtocolNumber_lbl);
        basicInfo.Controls.Add(DateOfMeasurement_lbl);
        basicInfo.Controls.Add(BasicEdit_btn);
        basicInfo.Controls.Add(label2);
        basicInfo.Controls.Add(label1);
        basicInfo.Location = new System.Drawing.Point(12, 12);
        basicInfo.Name = "basicInfo";
        basicInfo.Size = new System.Drawing.Size(710, 91);
        basicInfo.TabIndex = 0;
        basicInfo.TabStop = false;
        basicInfo.Text = "Basic Info";
        // 
        // ProtocolNumber_lbl
        // 
        ProtocolNumber_lbl.AutoSize = true;
        ProtocolNumber_lbl.Location = new System.Drawing.Point(139, 32);
        ProtocolNumber_lbl.Name = "ProtocolNumber_lbl";
        ProtocolNumber_lbl.Size = new System.Drawing.Size(12, 15);
        ProtocolNumber_lbl.TabIndex = 4;
        ProtocolNumber_lbl.Text = "?";
        // 
        // DateOfMeasurement_lbl
        // 
        DateOfMeasurement_lbl.AutoSize = true;
        DateOfMeasurement_lbl.Location = new System.Drawing.Point(139, 48);
        DateOfMeasurement_lbl.Name = "DateOfMeasurement_lbl";
        DateOfMeasurement_lbl.Size = new System.Drawing.Size(12, 15);
        DateOfMeasurement_lbl.TabIndex = 3;
        DateOfMeasurement_lbl.Text = "?";
        // 
        // BasicEdit_btn
        // 
        BasicEdit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        BasicEdit_btn.Location = new System.Drawing.Point(603, 22);
        BasicEdit_btn.Name = "BasicEdit_btn";
        BasicEdit_btn.Size = new System.Drawing.Size(95, 46);
        BasicEdit_btn.TabIndex = 2;
        BasicEdit_btn.Text = "Edit";
        BasicEdit_btn.UseVisualStyleBackColor = true;
        BasicEdit_btn.Click += basicEdit_btn_Click;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(6, 50);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(127, 18);
        label2.TabIndex = 1;
        label2.Text = "Date of measurement:";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(6, 32);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(111, 18);
        label1.TabIndex = 0;
        label1.Text = "Protocol Number:";
        // 
        // groupBox1
        // 
        groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        groupBox1.Controls.Add(CustomerEdit_btn);
        groupBox1.Controls.Add(PSC_lbl);
        groupBox1.Controls.Add(IC_lbl);
        groupBox1.Controls.Add(Name_lbl);
        groupBox1.Controls.Add(Address_lbl);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label4);
        groupBox1.Location = new System.Drawing.Point(12, 109);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(345, 125);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Customer";
        // 
        // CustomerEdit_btn
        // 
        CustomerEdit_btn.Location = new System.Drawing.Point(260, 84);
        CustomerEdit_btn.Name = "CustomerEdit_btn";
        CustomerEdit_btn.Size = new System.Drawing.Size(79, 33);
        CustomerEdit_btn.TabIndex = 5;
        CustomerEdit_btn.Text = "Edit";
        CustomerEdit_btn.UseVisualStyleBackColor = true;
        CustomerEdit_btn.Click += CustomerEdit_btn_Click;
        // 
        // PSC_lbl
        // 
        PSC_lbl.AutoSize = true;
        PSC_lbl.Location = new System.Drawing.Point(139, 68);
        PSC_lbl.Name = "PSC_lbl";
        PSC_lbl.Size = new System.Drawing.Size(12, 15);
        PSC_lbl.TabIndex = 8;
        PSC_lbl.Text = "?";
        // 
        // IC_lbl
        // 
        IC_lbl.AutoSize = true;
        IC_lbl.Location = new System.Drawing.Point(139, 84);
        IC_lbl.Name = "IC_lbl";
        IC_lbl.Size = new System.Drawing.Size(12, 15);
        IC_lbl.TabIndex = 7;
        IC_lbl.Text = "?";
        // 
        // Name_lbl
        // 
        Name_lbl.AutoSize = true;
        Name_lbl.Location = new System.Drawing.Point(139, 32);
        Name_lbl.Name = "Name_lbl";
        Name_lbl.Size = new System.Drawing.Size(12, 15);
        Name_lbl.TabIndex = 6;
        Name_lbl.Text = "?";
        // 
        // Address_lbl
        // 
        Address_lbl.AutoSize = true;
        Address_lbl.Location = new System.Drawing.Point(139, 48);
        Address_lbl.Name = "Address_lbl";
        Address_lbl.Size = new System.Drawing.Size(12, 15);
        Address_lbl.TabIndex = 5;
        Address_lbl.Text = "?";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(6, 86);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(127, 18);
        label5.TabIndex = 3;
        label5.Text = "IČ:";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(6, 68);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(111, 18);
        label6.TabIndex = 2;
        label6.Text = "PSČ:";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(6, 50);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(127, 18);
        label3.TabIndex = 1;
        label3.Text = "Address:";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(6, 32);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(111, 18);
        label4.TabIndex = 0;
        label4.Text = "Name:";
        // 
        // groupBox2
        // 
        groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        groupBox2.Controls.Add(MachineEdit_btn);
        groupBox2.Controls.Add(SerialNumber_lbl);
        groupBox2.Controls.Add(Manufacturer_lbl);
        groupBox2.Controls.Add(Model_lbl);
        groupBox2.Controls.Add(label12);
        groupBox2.Controls.Add(label13);
        groupBox2.Controls.Add(label14);
        groupBox2.Location = new System.Drawing.Point(371, 109);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(345, 125);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "Machine";
        // 
        // MachineEdit_btn
        // 
        MachineEdit_btn.FlatAppearance.BorderSize = 0;
        MachineEdit_btn.Location = new System.Drawing.Point(260, 84);
        MachineEdit_btn.Name = "MachineEdit_btn";
        MachineEdit_btn.Size = new System.Drawing.Size(79, 33);
        MachineEdit_btn.TabIndex = 5;
        MachineEdit_btn.Text = "Edit";
        MachineEdit_btn.UseVisualStyleBackColor = true;
        MachineEdit_btn.Click += MachineEdit_btn_Click;
        // 
        // SerialNumber_lbl
        // 
        SerialNumber_lbl.AutoSize = true;
        SerialNumber_lbl.Location = new System.Drawing.Point(139, 68);
        SerialNumber_lbl.Name = "SerialNumber_lbl";
        SerialNumber_lbl.Size = new System.Drawing.Size(12, 15);
        SerialNumber_lbl.TabIndex = 8;
        SerialNumber_lbl.Text = "?";
        // 
        // Manufacturer_lbl
        // 
        Manufacturer_lbl.AutoSize = true;
        Manufacturer_lbl.Location = new System.Drawing.Point(139, 32);
        Manufacturer_lbl.Name = "Manufacturer_lbl";
        Manufacturer_lbl.Size = new System.Drawing.Size(12, 15);
        Manufacturer_lbl.TabIndex = 6;
        Manufacturer_lbl.Text = "?";
        // 
        // Model_lbl
        // 
        Model_lbl.AutoSize = true;
        Model_lbl.Location = new System.Drawing.Point(139, 48);
        Model_lbl.Name = "Model_lbl";
        Model_lbl.Size = new System.Drawing.Size(12, 15);
        Model_lbl.TabIndex = 5;
        Model_lbl.Text = "?";
        // 
        // label12
        // 
        label12.Location = new System.Drawing.Point(6, 68);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(111, 18);
        label12.TabIndex = 2;
        label12.Text = "Serial Number:";
        // 
        // label13
        // 
        label13.Location = new System.Drawing.Point(6, 50);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(127, 18);
        label13.TabIndex = 1;
        label13.Text = "Model:";
        // 
        // label14
        // 
        label14.Location = new System.Drawing.Point(6, 32);
        label14.Name = "label14";
        label14.Size = new System.Drawing.Size(111, 18);
        label14.TabIndex = 0;
        label14.Text = "Manufacturer:";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(MeasurementAdd_btn);
        groupBox3.Controls.Add(MeasurementEdit_btn);
        groupBox3.Controls.Add(MeasurementDelete_btn);
        groupBox3.Controls.Add(dataGridView1);
        groupBox3.Location = new System.Drawing.Point(12, 240);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(704, 232);
        groupBox3.TabIndex = 3;
        groupBox3.TabStop = false;
        groupBox3.Text = "Measurement";
        // 
        // MeasurementAdd_btn
        // 
        MeasurementAdd_btn.Location = new System.Drawing.Point(482, 202);
        MeasurementAdd_btn.Name = "MeasurementAdd_btn";
        MeasurementAdd_btn.Size = new System.Drawing.Size(68, 23);
        MeasurementAdd_btn.TabIndex = 7;
        MeasurementAdd_btn.Text = "Add";
        MeasurementAdd_btn.UseVisualStyleBackColor = true;
        // 
        // MeasurementEdit_btn
        // 
        MeasurementEdit_btn.Location = new System.Drawing.Point(556, 202);
        MeasurementEdit_btn.Name = "MeasurementEdit_btn";
        MeasurementEdit_btn.Size = new System.Drawing.Size(68, 23);
        MeasurementEdit_btn.TabIndex = 8;
        MeasurementEdit_btn.Text = "Edit";
        MeasurementEdit_btn.UseVisualStyleBackColor = true;
        // 
        // MeasurementDelete_btn
        // 
        MeasurementDelete_btn.Location = new System.Drawing.Point(630, 202);
        MeasurementDelete_btn.Name = "MeasurementDelete_btn";
        MeasurementDelete_btn.Size = new System.Drawing.Size(68, 23);
        MeasurementDelete_btn.TabIndex = 7;
        MeasurementDelete_btn.Text = "Delete";
        MeasurementDelete_btn.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Meas_parameter, Meas_value, Meas_unit, Meas_valid });
        dataGridView1.Location = new System.Drawing.Point(6, 22);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(692, 174);
        dataGridView1.TabIndex = 0;
        dataGridView1.Text = "dataGridView1";
        // 
        // Meas_parameter
        // 
        Meas_parameter.HeaderText = "Parameter";
        Meas_parameter.Name = "Meas_parameter";
        Meas_parameter.ReadOnly = true;
        // 
        // Meas_value
        // 
        Meas_value.HeaderText = "Value";
        Meas_value.Name = "Meas_value";
        Meas_value.ReadOnly = true;
        // 
        // Meas_unit
        // 
        Meas_unit.HeaderText = "Unit";
        Meas_unit.Name = "Meas_unit";
        Meas_unit.ReadOnly = true;
        // 
        // Meas_valid
        // 
        Meas_valid.HeaderText = "Valid";
        Meas_valid.Name = "Meas_valid";
        Meas_valid.ReadOnly = true;
        // 
        // Export_btn
        // 
        Export_btn.Location = new System.Drawing.Point(580, 496);
        Export_btn.Name = "Export_btn";
        Export_btn.Size = new System.Drawing.Size(68, 23);
        Export_btn.TabIndex = 1;
        Export_btn.Text = "Export";
        Export_btn.UseVisualStyleBackColor = true;
        // 
        // Preview_btn
        // 
        Preview_btn.Location = new System.Drawing.Point(654, 496);
        Preview_btn.Name = "Preview_btn";
        Preview_btn.Size = new System.Drawing.Size(68, 23);
        Preview_btn.TabIndex = 4;
        Preview_btn.Text = "Preview";
        Preview_btn.UseVisualStyleBackColor = true;
        // 
        // Save_btn
        // 
        Save_btn.Location = new System.Drawing.Point(12, 496);
        Save_btn.Name = "Save_btn";
        Save_btn.Size = new System.Drawing.Size(68, 23);
        Save_btn.TabIndex = 5;
        Save_btn.Text = "Save";
        Save_btn.UseVisualStyleBackColor = true;
        Save_btn.Click += Save_btn_Click;
        // 
        // Load_btn
        // 
        Load_btn.Location = new System.Drawing.Point(86, 496);
        Load_btn.Name = "Load_btn";
        Load_btn.Size = new System.Drawing.Size(68, 23);
        Load_btn.TabIndex = 6;
        Load_btn.Text = "Load";
        Load_btn.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        ClientSize = new System.Drawing.Size(734, 531);
        Controls.Add(Load_btn);
        Controls.Add(Save_btn);
        Controls.Add(Preview_btn);
        Controls.Add(Export_btn);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(basicInfo);
        MaximizeBox = false;
        Text = "Servis Protocol";
        basicInfo.ResumeLayout(false);
        basicInfo.PerformLayout();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn Meas_parameter;
    private System.Windows.Forms.DataGridViewTextBoxColumn Meas_value;
    private System.Windows.Forms.DataGridViewTextBoxColumn Meas_unit;
    private System.Windows.Forms.DataGridViewTextBoxColumn Meas_valid;

    private System.Windows.Forms.Button MeasurementAdd_btn;

    private System.Windows.Forms.Button Load_btn;
    private System.Windows.Forms.Button MeasurementDelete_btn;
    private System.Windows.Forms.Button MeasurementEdit_btn;

    private System.Windows.Forms.Button Preview_btn;
    private System.Windows.Forms.Button Save_btn;

    private System.Windows.Forms.Button Export_btn;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.GroupBox groupBox3;

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button MachineEdit_btn;
    private System.Windows.Forms.Label SerialNumber_lbl;
    private System.Windows.Forms.Label Manufacturer_lbl;
    private System.Windows.Forms.Label Model_lbl;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;

    private System.Windows.Forms.Button CustomerEdit_btn;

    private System.Windows.Forms.Label Name_lbl;
    private System.Windows.Forms.Label Address_lbl;
    private System.Windows.Forms.Label PSC_lbl;
    private System.Windows.Forms.Label IC_lbl;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label ProtocolNumber_lbl;

    private System.Windows.Forms.Label DateOfMeasurement_lbl;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Button BasicEdit_btn;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.GroupBox basicInfo;

    #endregion
}