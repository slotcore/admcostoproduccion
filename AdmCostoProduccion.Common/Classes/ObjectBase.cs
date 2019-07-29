using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdmCostoProduccion.Common.Classes
{
    public class ObjectBase : INotifyPropertyChanged
    {

        #region Propiedades Privadas
        protected bool _IsNew;

        protected bool _IsOld;
        #endregion

        #region Propiedades Publicas
        public bool IsNew
        {
            get
            {
                return _IsNew;
            }

            set
            {
                if (value != _IsNew)
                {
                    _IsNew = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool IsOld
        {
            get
            {
                return _IsOld;
            }

            set
            {
                if (value != _IsOld)
                {
                    _IsOld = value;
                    NotifyPropertyChanged();
                }
            }
        } 
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                IsOld = true;
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
