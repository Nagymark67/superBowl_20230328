using System.Drawing.Text;

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

            string[] romaiSzamok = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
            int[] arabSzamok = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            if (jobb == false)
            {
                if (int.Parse(txt_arab.Text) < 1 || int.Parse(txt_arab.Text) > 10)
                {
                    txt_romai.Text = "Hiba!";
                }
                else
                {
                    int index = int.Parse(txt_arab.Text);
                    txt_romai.Text = romaiSzamok[index - 1];
                }
            }
            else
            {                
                if (!romaiSzamok.Contains(txt_romai.Text))
                {
                    txt_arab.Text = "Hiba!";
                }
                else
                {
                    for (int i = 0; i < romaiSzamok.Length; i++)
                    {
                        if (romaiSzamok[i] == txt_romai.Text)
                        {
                            txt_arab.Text = arabSzamok[i].ToString();
                        }
                    }
                }
            }

        }

        private void OnBtnIranyClick(object? sender, EventArgs e)
        {
            txt_romai.Clear();
            txt_arab.Clear();
            txt_arab.Enabled = !txt_arab.Enabled;
            txt_romai.Enabled = !txt_romai.Enabled;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = cmd_atvalt;
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
            jobb = !jobb;
        }
    }
}