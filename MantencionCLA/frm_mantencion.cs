﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantencionCLA
{
    public partial class frm_mantencion : Form
    {
        public frm_mantencion()
        {
            InitializeComponent();
        }

        private void frm_mantencion_Load(object sender, EventArgs e)
        {

        }

        private void frm_mantencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.setMantencion(null);
            this.Dispose();
        }
    }
}
