using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RendimentoVeicular.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal km = ValidarDecimal(tbxKM);
                decimal litros = ValidarDecimal(tbxLitros);

                decimal remdimento = km / litros;
                decimal consumo = litros / km;

                lblRendimentoResultado.Text = remdimento.ToString("N3");
                lblConsumo.Text = consumo.ToString("N3");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Alerta de Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public static decimal ValidarDecimal(TextBox txt)
        {
            try
            {
                return Convert.ToDecimal(txt.Text);
            }
            catch(Exception e)
            {
                txt.Focus();
                throw new Exception("Preencha corretamente o campo" + txt.Name.ToUpper().Replace("TEXTBOX", ""));
            }
        }

        public void LimparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
                else if( ctl is Label && Convert.ToInt32(ctl.Tag).Equals(1))
                {
                    ctl.Text = string.Empty;
                }
            }
        }
    }
}
