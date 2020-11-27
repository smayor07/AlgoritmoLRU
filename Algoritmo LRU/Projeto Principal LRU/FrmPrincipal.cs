using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projeto_Principal_LRU
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public struct Paginas
        {
            public string valor;
            public DateTime ultimoacesso;
        }

        public Paginas[] V;
        public Random R;
        public string S = "0A1B2C3D4E5F6G7H8I9J";

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            V = new Paginas[4];
            R = new Random();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                Executar();
            });
        }

        public string ProximaPagina()
        {
            string AUX;
            AUX = S.Substring(R.Next(1, 20), 1);
            return AUX;
        }

        public int EscolheVitima()
        {
            DateTime Menor = V[0].ultimoacesso;
            int INDEX = 0;
            for (int i = 0; i < 4; i++)
            {
                if (V[i].ultimoacesso < Menor)
                {
                    Menor = V[i].ultimoacesso;
                    INDEX = i;
                }
            }
            return INDEX;
        }

        public bool paraExecucao = false;

        public void Executar()
        {
            int NU = (int)nudIntervalo.Value * 1000;
            while (true)
            {
                Thread.Sleep(NU);
                if (txtP1.Text == "")
                {
                    V[0].valor = ProximaPagina();
                    V[0].ultimoacesso = DateTime.Now;
                    txtP1.Invoke(new Action(() => txtP1.Text = V[0].valor));
                    txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                }
                if (txtP2.Text == "")
                {
                    V[1].valor = txtPP.Text;
                    V[1].ultimoacesso = DateTime.Now;
                    txtP2.Invoke(new Action(() => txtP2.Text = V[1].valor));
                    txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                }
                if (txtP3.Text == "")
                {
                    V[2].valor = txtPP.Text;
                    V[2].ultimoacesso = DateTime.Now;
                    txtP3.Invoke(new Action(() => txtP3.Text = V[2].valor));
                    txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                }
                if (txtP4.Text == "")
                {
                    V[3].valor = txtPP.Text;
                    V[3].ultimoacesso = DateTime.Now;
                    txtP4.Invoke(new Action(() => txtP4.Text = V[3].valor));
                    txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));

                    string A = V[0].valor;
                    string B = V[1].valor;
                    string C = V[2].valor;
                    string D = V[3].valor;

                    if ((A == B) || (A == C) || (A == D))
                    {
                        V[0].valor = txtPP.Text;
                        txtP1.Invoke(new Action(() => txtP1.Text = V[0].valor));
                        txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                        goto LINE;
                    }
                    if ((B == A) || (B == C) || (B == D))
                    {
                        V[1].valor = txtPP.Text;
                        txtP2.Invoke(new Action(() => txtP2.Text = V[1].valor));
                        txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                        goto LINE;
                    }
                    if ((C == A) || (C == B) || (C == D))
                    {
                        V[2].valor = txtPP.Text;
                        txtP3.Invoke(new Action(() => txtP3.Text = V[2].valor));
                        txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                        goto LINE;
                    }
                    if ((D == A) || (D == B) || (D == C))
                    {
                        V[3].valor = txtPP.Text;
                        txtP4.Invoke(new Action(() => txtP4.Text = V[3].valor));
                        txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                        goto LINE;
                    }
                }

                LINE:
                int VIT = EscolheVitima();
                txtPV.Invoke(new Action(() => txtPV.Text = V[VIT].valor));
                string PROX = txtPP.Text;

                if (txtP1.Text == PROX)
                {
                    V[0].ultimoacesso = DateTime.Now;
                    txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                }
                if (txtP2.Text == PROX)
                {
                    V[1].ultimoacesso = DateTime.Now;
                    txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                }
                if (txtP3.Text == PROX)
                {
                    V[2].ultimoacesso = DateTime.Now;
                    txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                }
                if (txtP4.Text == PROX)
                {
                    V[3].ultimoacesso = DateTime.Now;
                    txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                }

                if (VIT == 0)
                {
                    V[0].valor = txtPP.Text;
                    V[0].ultimoacesso = DateTime.Now;
                    txtP1.Invoke(new Action(() => txtP1.Text = V[0].valor));
                    txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                    txtPV.Invoke(new Action(() => txtPV.Text = V[EscolheVitima()].valor));
                }
                if (VIT == 1)
                {
                    V[1].valor = txtPP.Text;
                    V[1].ultimoacesso = DateTime.Now;
                    txtP2.Invoke(new Action(() => txtP2.Text = V[1].valor));
                    txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                    txtPV.Invoke(new Action(() => txtPV.Text = V[EscolheVitima()].valor));
                }
                if (VIT == 2)
                {
                    V[2].valor = txtPP.Text;
                    V[2].ultimoacesso = DateTime.Now;
                    txtP3.Invoke(new Action(() => txtP3.Text = V[2].valor));
                    txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                    txtPV.Invoke(new Action(() => txtPV.Text = V[EscolheVitima()].valor));
                }
                if (VIT == 3)
                {
                    V[3].valor = txtPP.Text;
                    V[3].ultimoacesso = DateTime.Now;
                    txtP4.Invoke(new Action(() => txtP4.Text = V[3].valor));
                    txtPP.Invoke(new Action(() => txtPP.Text = ProximaPagina()));
                    txtPV.Invoke(new Action(() => txtPV.Text = V[EscolheVitima()].valor));
                }


                if (paraExecucao)
                {
                    break;
                }
            }
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            paraExecucao = true;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
