namespace servisniProtokol;
    public partial class Form1 : Form
    {
        private ServiceProtocol ServiceProtocol { get; set; } = new ServiceProtocol(); /// problémy v serializaci or smt

        public Form1()
        {
            InitializeComponent();
        }

        private void basicEdit_btn_Click(object sender, EventArgs e)
        {
            new BasicEditForm().ShowDialog();
            
        }

        private void CustomerEdit_btn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void MachineEdit_btn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        { 
            throw new System.NotImplementedException();
        }
    }
