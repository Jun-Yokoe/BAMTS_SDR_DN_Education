using System.Windows.Controls;
using GrapeCity.Windows.SpreadGrid;

namespace BAMTS.Internal
{
    /// <summary>
    /// Interaction logic for UCGCEmployeeList
    /// </summary>
    public partial class UCGCEmployeeList : UserControl
    {
        public UCGCEmployeeList()
        {
            InitializeComponent();
            gcgList.Columns[5].MergePolicy = MergePolicy.Always;
            gcgList.Columns[6].MergePolicy = MergePolicy.Restricted;
        }
    }
}
