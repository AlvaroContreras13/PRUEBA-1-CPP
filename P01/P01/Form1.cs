namespace P01
{
    public partial class Form1 : Form
    {
        double monto, depositoC, depositoT = 0, retiro, retiroT = 0, saldoA = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            monto = Double.Parse(txtMonto.Text);


            if (rbtnDep.Checked == true)
            {
                depositoC = Double.Parse(txtDepC.Text);
                depositoT += depositoC;

                //El apartado de txtDeopc se borra por motivos visuales
                txtDepC.Text = string.Empty;


            }
            


            if (rbtnRetiro.Checked == true)
            {
                retiro = Double.Parse(txtRetiro.Text);
                if (retiro > saldoA)
                {
                    //retiroT += retiro;
                    MessageBox.Show("El retiro supera el saldo actual", "Saldo insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (retiro <= saldoA)
                {
                    retiroT += retiro; //retiroT= retiroT + retiro
                    txtRetiro.Text = string.Empty;

                }
               

            }

            saldoA = monto+ depositoT - retiroT;

            if (rbtnRetiro.Checked == false && rbtnDep.Checked == false)
            {
                MessageBox.Show("Seleciones alguna opción", "Consejo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                txtSA.Text = saldoA.ToString();
                txtDepT.Text = depositoT.ToString();
                txtRetiroT.Text = retiroT.ToString();
            }
            rbtnRetiro.Checked = false;
            rbtnDep.Checked = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rbtnDep.Checked = false;
            rbtnRetiro.Checked = false;

            txtDepC.Text = "";
            txtDepT.Text = "";
            txtMonto.Text = "";
            txtRetiro.Text = "";
            txtRetiroT.Text = "";
            txtSA.Text = "";
            txtCliente.Text = "";

            saldoA = 0;
            depositoT = 0;
            retiroT = 0;
        }
    }
}