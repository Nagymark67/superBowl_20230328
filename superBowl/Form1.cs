namespace superBowl
{
    public partial class Form1 : Form
    {
        static bool jobb = true;        
        public Form1()
        {
            InitializeComponent();
            btn_irany.Click += OnBtnIranyClick;
            cmd_atvalt.Click += OnCmdAtvaltClick;
            
        }

        private void OnCmdAtvaltClick(object? sender, EventArgs e)
        {
            if (jobb = true)
            {

            }
            else
            {

            }
        }

        private void OnBtnIranyClick(object? sender, EventArgs e)
        {
            if (jobb=false && int.Parse(txt_arab.Text) < 1 || int.Parse(txt_arab.Text) > 10)
            {
                txt_romai.Text = "Hiba!";
            }
            else
            {
                txt_romai.Text = 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void btn_irany_Click(object sender, EventArgs e)
        {
            if (btn_irany.Text == "--->")
            {
                btn_irany.Text = "<---";
            }
            else
            {
                btn_irany.Text = "--->";
            }
        }
    }
}