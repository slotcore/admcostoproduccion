﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.Entity;

namespace AdmCostoProduccion.Common.Classes
{
    public class ObservableListSource<T> : ObservableCollection<T>, IListSource
            where T : ObjectBase
    {
        private IBindingList _bindingList;
        private List<T> _removeList = new List<T>();

        bool IListSource.ContainsListCollection { get { return false; } }

        IList IListSource.GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }

        public bool RemoveItem(T item)
        {
            _removeList.Add(item);
            return this.Remove(item);
        }

        public List<T> GetRemoveItems()
        {
            return _removeList;
        }
    }
}
