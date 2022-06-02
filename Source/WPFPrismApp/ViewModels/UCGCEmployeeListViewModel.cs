using Prism.Mvvm;
using Prism.Regions;
using Prism.Commands;
using System.Collections.Generic;
using GrapeCity.Windows.SpreadGrid;
using System;
using System.Windows;

namespace BAMTS.Internal
{
    public class UCGCEmployeeListViewModel : UCEmployeeListViewModel
    {
        public UCGCEmployeeListViewModel() : base() { }
        public UCGCEmployeeListViewModel(IDataAccessor dataAccessor, IMessageService messageService) : base(dataAccessor, messageService) { }
    }
}
