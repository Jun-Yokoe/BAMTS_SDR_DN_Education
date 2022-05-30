using Prism.Mvvm;
using Prism.Regions;
using System.Collections.Generic;

namespace BAMTS.Internal
{
    public class UCMSEmployeeListViewModel : UCEmployeeListViewModel 
    {
        public UCMSEmployeeListViewModel() : base() { }
        public UCMSEmployeeListViewModel(IDataAccessor dataAccessor, IMessageService messageService) : base(dataAccessor, messageService) { }
    }
}
