using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmCostoProduccion.Common.Forms
{
    public partial class BaseForm : KryptonForm
    {
        /// <summary>
        /// Indica si el formulario esta en modo de edicion o para agregar
        /// </summary>
        public bool IsNew;

        public BaseForm()
        {
        }

        public BaseForm(bool isNew)
        {
            IsNew = isNew;
            InitializeComponent();
        }
    }
}
