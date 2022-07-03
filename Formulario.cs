using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciayPolimofísmoWF
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void CalculaCena(CenasEmpresa cena)
        {
            CompruebaNumeroPersonasCena(cena);
            CompruebaSiQuierenDecoDeLujoCena(cena);
            CompruebaSiQuierenCenaSaludable(cena);
            CalculaCosteDecoracionCena(cena);
            CalculaCosteCena(cena);
            MuestraDesgloseCosteCena(cena);
        }

        private void CalculaCumple(Cumpleaños cumple)
        {
            CompruebaNumeroPersonasCumple(cumple);
            CompruebaSiQuierenDecoDeLujoCumple(cumple);
            CalculaCosteDecoracionCumple(cumple);
            CalculaElCosteDelTextoDeLaTartaCumple(cumple);
            CalculaCosteCumple(cumple);
            MuestraDesgloseCosteCumple(cumple);
        }

        private void CompruebaNumeroPersonasCena(CenasEmpresa cena)
        {
            cena.NumPersonas = (Int32) NumUpDownCenas.Value;
        }

        private void CompruebaNumeroPersonasCumple(Cumpleaños cumple)
        {
            cumple.NumPersonas = (Int32)NumUpDownCumples.Value;

        }

        private void CompruebaSiQuierenDecoDeLujoCena(CenasEmpresa cena)
        {
            if (CheckBoxDecoDeLujoCenas.Checked)
            {
                cena.DecoracionLujo = true;
            } 
            else
            {
                cena.DecoracionLujo = false;
            }
        }

        private void CompruebaSiQuierenDecoDeLujoCumple(Cumpleaños cumple)
        {
            if (CheckBoxDecoDeLujoCumples.Checked)
            {
                cumple.DecoracionLujo = true;
            }
            else
            {
                cumple.DecoracionLujo = false;
            }
        }

        private void CalculaCosteDecoracionCena(CenasEmpresa cena)
        {
            cena.CalcularCosteDecoracion();
        }

        private void CalculaCosteDecoracionCumple(Cumpleaños cumple)
        {
            cumple.CalcularCosteDecoracion();
        }

        private void CompruebaSiQuierenCenaSaludable(CenasEmpresa cena)
        {
            if (CheckBoxSaludableCenas.Checked)
            {
                cena.OpcionSaludable = true;
                cena.EstableceOpcionSaludable();
            }
            else
            {
                cena.OpcionSaludable = false;
                cena.EstableceOpcionSaludable();
            }
        }

        private void CalculaElCosteDelTextoDeLaTartaCumple(Cumpleaños cumple)
        {
            CompruebaElTextoDeLaTartaCumple(cumple);
        }

        private void CompruebaElTextoDeLaTartaCumple(Cumpleaños cumple)
        {
            if (TextboxTextoTarta.Text.Length <= 16 && cumple.NumPersonas <= 8)
            { cumple.TamañoTarta = 40; cumple.TextoTarta = TextboxTextoTarta.Text; }

            if (TextboxTextoTarta.Text.Length > 16 && cumple.NumPersonas <= 8)
            { MessageBox.Show("La tarta pequeña solo puede contener 16 letras."); }

            if (TextboxTextoTarta.Text.Length <= 40 && cumple.NumPersonas > 8)
            { cumple.TamañoTarta = 75; cumple.TextoTarta = TextboxTextoTarta.Text; }

            if (TextboxTextoTarta.Text.Length > 40 && cumple.NumPersonas > 8)
            { MessageBox.Show("La tarta grande solo puede contener 40 letras."); }
        }

        private void CalculaCosteCena(CenasEmpresa cena)
        {
            TextBoxCosteCenas.Text = cena.CalcularCoste().ToString();
        }

        private void CalculaCosteCumple(Cumpleaños cumple)
        {
            TextBoxCosteCumples.Text = cumple.CalcularCoste().ToString();
        }

        private void MuestraDesgloseCosteCena(CenasEmpresa cena)
        {
            label13.Text = (cena.NumPersonas * cena.CosteFijoPersona).ToString();
            label14.Text = cena.CosteDecoracion.ToString();
            label15.Text = cena.CosteBebidaPorPersona.ToString();
            if (CheckBoxSaludableCenas.Checked) { label16.Text = "5%"; } 
            else { label16.Text = "No hay"; }
        }

        private void MuestraDesgloseCosteCumple(Cumpleaños cumple)
        {


            label20.Text = (cumple.NumPersonas * cumple.CosteFijoPersona).ToString();
            label19.Text = cumple.CosteDecoracion.ToString();
            label18.Text = (TextboxTextoTarta.Text.Length * 0.25).ToString();
            if (cumple.NumPersonas <= 8) { label17.Text = "Pequeña"; }
            else { label17.Text = "Grande"; }
        }

        private void NumUpDownCenas_ValueChanged(object sender, EventArgs e)
        {
            CenasEmpresa cena = new CenasEmpresa();
            CalculaCena(cena);
        }

        private void CheckBoxDecoDeLujoCenas_CheckedChanged(object sender, EventArgs e)
        {
            CenasEmpresa cena = new CenasEmpresa();
            CalculaCena(cena);
        }

        private void CheckBoxSaludableCenas_CheckedChanged(object sender, EventArgs e)
        {
            CenasEmpresa cena = new CenasEmpresa();
            CalculaCena(cena);
        }

        private void NumUpDownCumples_ValueChanged(object sender, EventArgs e)
        {
            Cumpleaños cumple = new Cumpleaños();
            CalculaCumple(cumple);
        }

        private void CheckBoxDecoDeLujoCumples_CheckedChanged(object sender, EventArgs e)
        {
            Cumpleaños cumple = new Cumpleaños();
            CalculaCumple(cumple);
        }

        private void TextboxTextoTarta_TextChanged(object sender, EventArgs e)
        {
            Cumpleaños cumple = new Cumpleaños();
            CalculaCumple(cumple);
        }
    }
}
