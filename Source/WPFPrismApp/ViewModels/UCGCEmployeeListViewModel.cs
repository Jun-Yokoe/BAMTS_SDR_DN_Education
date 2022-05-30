using Prism.Mvvm;
using Prism.Regions;
using System.Collections.Generic;

namespace BAMTS.Internal
{
    public class UCGCEmployeeListViewModel : UCEmployeeListViewModel 
    {
        public UCGCEmployeeListViewModel() : base() { }
        public UCGCEmployeeListViewModel(IDataAccessor dataAccessor, IMessageService messageService) : base(dataAccessor, messageService) { }
    }
}
