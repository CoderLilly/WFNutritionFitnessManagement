using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFNutritionFitnessManagement1
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }

        private void btnConvertStart_Click(object sender, EventArgs e)
        {
            double valueIn = double.Parse(tbValueIn.Text);
            double result = 0;
            string convertFrom = cbFrom.Text;
            string convertTo = cbTo.Text;

            if (cbFrom.Text == "Convert from:" || cbTo.Text == "Convert to:")
            { MessageBox.Show("Please select From and To units"); }
            
            if (convertFrom == "Teaspoon")
            {
                if (convertTo == "Teaspoon") { result = valueIn;  }
                if (convertTo == "Tablespoon") { result = valueIn / 3;  }
                if (convertTo == "Cup") { result = valueIn / 48;  }
                if (convertTo == "Pint") { result = valueIn / 96;  }
                if (convertTo == "Quart") { result = valueIn / 192;  }
                if (convertTo == "Gallon") { result = valueIn / 768;  }
                if (convertTo== "Ounce") { result = valueIn * .166667; }
                if (convertTo == "Milliliter") { result = valueIn * 5; }
            }
            else if (convertFrom == "Tablespoon")
            {
                if (convertTo == "Teaspoon") { result = valueIn * 3;  }
                if (convertTo == "Tablespoon") { result = valueIn;  }
                if (convertTo == "Cup") { result = valueIn / 16;  }
                if (convertTo == "Pint") { result = valueIn / 32;  }
                if (convertTo == "Quart") { result = valueIn / 64;  }
                if (convertTo == "Gallon") { result = valueIn / 256;  }
                if (convertTo == "Ounce") { result = valueIn * .5; }
                if (convertTo == "Milliliter") { result = valueIn * 15; }
            }
            else if (convertFrom == "Cup")
            {
                if (convertTo == "Teaspoon") { result = valueIn * 48;  }
                if (convertTo == "Tablespoon") { result = valueIn * 16;  }
                if (convertTo == "Cup") { result = valueIn;  }
                if (convertTo == "Pint") { result = valueIn / 2;  }
                if (convertTo == "Quart") { result = valueIn / 4;  }
                if (convertTo == "Gallon") { result = valueIn / 16; }
                if (convertTo == "Ounce") { result = valueIn * 8; }
                if (convertTo == "Milliliter") { result = valueIn * 240; }
            }
            else if (convertFrom == "Pint")
            {
                if (convertTo == "Teaspoon") { result = valueIn * 96;  }
                if (convertTo == "Tablespoon") { result = valueIn * 32;  }
                if (convertTo == "Cup") { result = valueIn * 2;  }
                if (convertTo == "Pint") { result = valueIn;  }
                if (convertTo == "Quart") { result = valueIn / 2;  }
                if (convertTo == "Gallon") { result = valueIn / 8;  }
                if (convertTo == "Ounce") { result = valueIn * 16; }
                if (convertTo == "Milliliter") { result = valueIn * 473.176; }
            }
            else if (convertFrom == "Quart")
            {
                if (convertTo == "Teaspoon") { result = valueIn * 192;  }
                if (convertTo == "Tablespoon") { result = valueIn * 64;  }
                if (convertTo == "Cup") { result = valueIn * 4;  }
                if (convertTo == "Pint") { result = valueIn * 2;  }
                if (convertTo == "Quart") { result = valueIn;  }
                if (convertTo == "Gallon") { result = valueIn / 4;  }
                if (convertTo == "Ounce") { result = valueIn * 32; }
                if (convertTo == "Milliliter") { result = valueIn * 946.353; }
            }
            else if (convertFrom == "Gallon")
            {
                if (convertTo == "Teaspoon") { result = valueIn * 768; }
                if (convertTo == "Tablespoon") { result = valueIn * 256; }
                if (convertTo == "Cup") { result = valueIn * 16; }
                if (convertTo == "Pint") { result = valueIn * 8; }
                if (convertTo == "Quart") { result = valueIn * 4; }
                if (convertTo == "Gallon") { result = valueIn; }
                if (convertTo == "Ounce") { result = valueIn * 128; }
                if (convertTo == "Milliliter") { result = valueIn * 3785.41; }
            }
            else if (convertFrom == "Ounce")
            {
                if (convertTo == "Teaspoon") { result = valueIn * 6; }
                if (convertTo == "Tablespoon") { result = valueIn * 2; }
                if (convertTo == "Cup") { result = valueIn / 8; }
                if (convertTo == "Pint") { result = valueIn / 16; }
                if (convertTo == "Quart") { result = valueIn / 32; }
                if (convertTo == "Gallon") { result = valueIn / 128; }
                if (convertTo == "Ounce") { result = valueIn; }
                if (convertTo == "Milliliter") { result = valueIn * 29.5735; }
            }
            else if (convertFrom == "Milliliter")
            {
                if (convertTo == "Teaspoon") { result = valueIn / 5; }
                if (convertTo == "Tablespoon") { result = valueIn / 15; }
                if (convertTo == "Cup") { result = valueIn / 240; }
                if (convertTo == "Pint") { result = valueIn / 473.176; }
                if (convertTo == "Quart") { result = valueIn / 946.353; }
                if (convertTo == "Gallon") { result = valueIn / 3785.41; }
                if (convertTo == "Ounce") { result = valueIn / 29.5735; }
                if (convertTo == "Milliliter") { result = valueIn; }
            }
            else { return; }
            tbResult.Text = result.ToString("F");
        }
    }
}
