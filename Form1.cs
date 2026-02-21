using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
       
        public Form1()
        {
           
            InitializeComponent();
        }
        void Reset()
        {
            groupBox1.Enabled = true;
            cheese.Checked=false;
            olives.Checked = false;
           onion.Checked = false;
            mushorom.Checked = false;
            paper.Checked = false;
            tomato.Checked = false;
           samll.Checked = false;
            Meduim.Checked = false;
           large.Checked = false;
          thick.Checked = false;
            thin.Checked = false;

        }
        void UpdateSize()
        {
            UpdatePrize();
            if (samll.Checked) { size.Text = "small"; }
            if (Meduim.Checked) { size.Text = "Meduim"; }
            if (large.Checked) { size.Text = "large"; }

        }
     
        void UpdateToping()
        {
            UpdatePrize();
            topings.Text = "";
            if (cheese.Checked) { topings.Text += "cheese"; }
            if (mushorom.Checked) { topings.Text += "  , mushroom"; }
            if (olives.Checked) { topings.Text += " , olives"; }
            if (onion.Checked) { topings.Text += " , onion"; }
            if (tomato.Checked) { topings.Text += " , tomato"; }
            if (paper.Checked) { topings.Text += " , paper"; }

        }
        void CrustType()
        {
            UpdatePrize();
            if (thin.Checked) { type.Text = "thin crust"; }
            if (thick.Checked) {type.Text = "thick crust"; }
        }
       void UpdatewhereToEat()
        {
            if (EatIn.Checked) { where.Text = "EatIn"; }
            if (EatOut.Checked) { where.Text = "EatOut"; }
        }
        float GetSizePize()
        {
            if (samll.Checked)
                return Convert.ToSingle(samll.Tag);

            if (Meduim.Checked)

                return Convert.ToSingle(Meduim.Tag);

            if (large.Checked)

                return Convert.ToSingle(large.Tag);
            return 0;
        }
        float GetCrustTypePrize()
        {
            if (thick.Checked)
                return Convert.ToSingle(thick.Tag);

           
            if (thin.Checked)

                return Convert.ToSingle(thin.Tag);
            return 0;
        }

        float GetToppintTotalPrise()
        {
            float toppingPrize=0;
            if (cheese.Checked)
                toppingPrize += Convert.ToSingle(cheese.Tag);

            if (mushorom.Checked)

                toppingPrize += Convert.ToSingle(mushorom.Tag);
            if (paper.Checked)

                toppingPrize += Convert.ToSingle(paper.Tag);
            if (tomato.Checked)

                toppingPrize += Convert.ToSingle(tomato.Tag);
            if (olives.Checked)

                toppingPrize += Convert.ToSingle(olives.Tag);

            if (onion.Checked)

                toppingPrize += Convert.ToSingle(onion.Tag);
            return toppingPrize;
        } 

        float CalculateTotal()
        {
            return GetCrustTypePrize() + GetToppintTotalPrise()+ GetSizePize();
        }
        void UpdatePrize()
        {
            prise.Text = "$ " + CalculateTotal().ToString();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void part2_Enter(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void samll_CheckedChanged(object sender, EventArgs e)
        {

            UpdateSize();
        }

        private void Meduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void topings_Click(object sender, EventArgs e)
        {
            UpdateToping();
        }

        private void large_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void thin_CheckedChanged(object sender, EventArgs e)
        {
            CrustType();
        }

        private void cheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToping();
        }

        private void mushorom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToping();
        }

        private void paper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToping();
        }

        private void olives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToping();
        }

        private void onion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToping();
        }

        private void tomato_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToping();
        }

        private void type_Click(object sender, EventArgs e)
        {
            CrustType();
        }

        private void thick_CheckedChanged(object sender, EventArgs e)
        {
            CrustType();
        }

        private void where_Click(object sender, EventArgs e)
        {
            UpdatewhereToEat();
        }

        private void EatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdatewhereToEat();
        }

        private void EatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdatewhereToEat();
        }

        private void order_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            if (MessageBox.Show("conform order","conform",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question ) == DialogResult.OK) {
                MessageBox.Show("success", "success order",MessageBoxButtons.OK );
            
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
