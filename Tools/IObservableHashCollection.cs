﻿namespace GMaster.Tools
{
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;

    public interface IObservableHashCollection : INotifyCollectionChanged, INotifyPropertyChanged
    {
        void Add(string pairKey, IStringIdItem pairValue);

        IEnumerable<IStringIdItem> GetAll();
    }
}