using System.Linq.Expressions;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorAtual { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
            Porcentagem
        }
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Permite que o formulário capture eventos de teclado
            textResultado.ReadOnly = true;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            {
                textResultado.Text = "0,";
                textResultado.SelectionStart = textResultado.Text.Length;
                textResultado.Focus();
            }
            else if (!textResultado.Text.Contains(","))
            {
                textResultado.Text += ",";
                textResultado.SelectionStart = textResultado.Text.Length;
                textResultado.Focus();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    btnZero.PerformClick();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    btnUm.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    btnDois.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    btnTres.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    btnQuatro.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    btnCinco.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    btnSeis.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    btnSete.PerformClick();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    btnOito.PerformClick();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    btnNove.PerformClick();
                    break;
                case Keys.Add:
                    btnAdicao.PerformClick();
                    break;
                case Keys.Subtract:
                    btnSubtracao.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMultiplicacao.PerformClick();
                    break;
                case Keys.Divide:
                    btnDivisao.PerformClick();
                    break;
                case Keys.Enter:
                    btnIgual.PerformClick();
                    break;
                case Keys.Decimal:
                case Keys.OemPeriod:
                case Keys.Oemcomma:
                    if (!textResultado.Text.Contains(",")) // Garante apenas uma vírgula
                        textResultado.Text += ",";
                    break;
                case Keys.Back:
                    btnBackspace.PerformClick();
                    break;
                case Keys.Delete:
                    btnApagarTudo.PerformClick();
                    break;
                case Keys.Oem5: // Tecla "%" no teclado padrão
                    btnPorcentagem.PerformClick();
                    break;
                case Keys.Oemplus:
                    if (e.Shift)
                        btnAdicao.PerformClick();
                    break;
                case Keys.OemMinus:
                    btnSubtracao.PerformClick();
                    break;
                case Keys.Oem2: // Também captura "/"
                    btnDivisao.PerformClick();
                    break;
            }
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                OperacaoSelecionada = Operacao.Adicao;
                Valor = Convert.ToDecimal(textResultado.Text);
                textResultado.Text = "";
            }
            else
            {
                MessageBox.Show("Entrada inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                OperacaoSelecionada = Operacao.Subtracao;
                Valor = Convert.ToDecimal(textResultado.Text);
                textResultado.Text = "";

            }
            else
            {
                MessageBox.Show("Entrada inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                OperacaoSelecionada = Operacao.Multiplicacao;
                Valor = Convert.ToDecimal(textResultado.Text);
                textResultado.Text = "";
            }
            else
            {
                MessageBox.Show("Entrada inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                OperacaoSelecionada = Operacao.Divisao;
                Valor = Convert.ToDecimal(textResultado.Text);
                textResultado.Text = "";
            }
            else
            {
                MessageBox.Show("Entrada inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textResultado.Text))
                return;

            decimal valorAtual;
            if (!decimal.TryParse(textResultado.Text, out valorAtual))
            {
                MessageBox.Show("Entrada inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + valorAtual;
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - valorAtual;
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * valorAtual;
                    break;
                case Operacao.Divisao:
                    if (valorAtual == 0)
                    {
                        MessageBox.Show("Erro: Divisão por zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textResultado.Text = "";
                        return;
                    }
                    Resultado = Valor / valorAtual;
                    break;
            }

            textResultado.Text = Resultado.ToString("G29");
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                ValorAtual = Convert.ToDecimal(textResultado.Text);
                Resultado = Valor * (ValorAtual / 100);
                textResultado.Text = Resultado.ToString("G29");
            }
            else
            {
                MessageBox.Show("Entrada inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            Valor = 0;
            Resultado = 0;
            OperacaoSelecionada = 0;
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (textResultado.Text.Length > 0)  // Garante que há caracteres para apagar
            {
                textResultado.Text = textResultado.Text.Substring(0, textResultado.Text.Length - 1);
            }
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            textResultado.SelectionStart = textResultado.Text.Length;
            textResultado.Focus();
        }

        private void textResultado_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}