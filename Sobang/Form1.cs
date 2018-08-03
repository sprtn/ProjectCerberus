using System.Collections.Generic;
using System.Windows.Forms;

namespace Sobang
{
    public partial class Sobang : Form
    {
        public Sobang()
        {
            InitializeComponent();
            SetFormSettings();
        }

        private void SetFormSettings()
        {
            MinimizeBox = false;
            MaximizeBox = false;
            CenterToScreen();
        }
    }
}
