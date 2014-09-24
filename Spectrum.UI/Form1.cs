using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spectrum.DAL;

namespace Spectrum.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {

                lbTypes.DataSource = MaterialTypes.GetAllMaterialTypes();

                lbTypes.DisplayMember = "Material_Type";
                lbTypes.ValueMember = "MaterialTypeID";
            }
        }

        

        private void btnSelectType_Click(object sender, EventArgs e)
        {
            var selectedType = (LU_MaterialType)lbTypes.SelectedItem;

            {
                lbMaterials.DataSource = Material.GetAllMaterials(selectedType.MaterialTypeID);
                lbMaterials.DisplayMember = "Material";
                lbMaterials.ValueMember = "MaterialID";
            }


            lbMaterials.Visible = true;
            btnSelectMaterial.Visible = true;
        }



      
        private void btnSelectMaterial_Click(object sender, EventArgs e)
        {
            var selectedMaterial = (LU_Material)lbMaterials.SelectedItem;

            LU_Material SelectedMaterial = Material.GetAllMaterialProperies(selectedMaterial.MaterialID);

            lblDensityVal.Text = SelectedMaterial.Density.EmptyIfNull();
            lblEmbodiedImpactVal.Text = SelectedMaterial.Environmental_Impact_Factor.EmptyIfNull();
            lblThicknessVal.Text = SelectedMaterial.Thickness.EmptyIfNull();
          
        }
    }
}
