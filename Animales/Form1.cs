using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Animales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEdad_Click(object sender, EventArgs e)
        {
            if (CbxTipo.SelectedIndex == 0)
            {
                Modelo.Cls_Vertebrados oCls_Vertebrados = new Cls_Vertebrados(Int32.Parse(TxtNro_Huesos.Text), 
                    Convert.ToByte(CbxTipo.SelectedIndex), Int32.Parse(TxtAnio.Text), TxtNombre.Text);

                //Logica.Cls_Vertebrados oCls_Vertebrados = new Logica.Cls_Vertebrados(TxtNombre.Text, 
                //    Int32.Parse(TxtAnio.Text), Int32.Parse(TxtNro_Huesos.Text), Convert.ToByte(CbxTipo.SelectedIndex));

                Logica.Cls_Vertebrados oLogCls_Vertebrados = new Logica.Cls_Vertebrados();
                LblEdad.Text = Convert.ToString(oLogCls_Vertebrados.Calcular_Edad(oCls_Vertebrados.Anio_Naci));

                Modelo.Cls_Venta oCls_Venta = new Modelo.Cls_Venta(Int32.Parse(TxtIdVenta.Text), oCls_Vertebrados);
                Logica.Cls_Venta OdjCls_Venta = new Logica.Cls_Venta();
                Modelo.Cls_Vendedor oCls_Vendedor = new Cls_Vendedor(Int32.Parse(TxtId_Vendedor.Text));
                bool bolRespuesta = OdjCls_Venta.registrar_Venta(oCls_Venta, oCls_Vendedor);
                if (bolRespuesta)
                { MessageBox.Show("Registro Satisfactorio"); }
                else
                { MessageBox.Show("Error al Registrar => Verifique <="); }
            }

            if (CbxTipo.SelectedIndex == 1)
            {
                Logica.Cls_Invertebrados oCls_Invertebrados = new Logica.Cls_Invertebrados(TxtNombre.Text,
                    Int32.Parse(TxtAnio.Text), Convert.ToByte(CbxTipo.SelectedIndex));
                LblEdad.Text = Convert.ToString(oCls_Invertebrados.Calcular_Edad(Int32.Parse(TxtAnio.Text)));
            }
        }
    }
}
