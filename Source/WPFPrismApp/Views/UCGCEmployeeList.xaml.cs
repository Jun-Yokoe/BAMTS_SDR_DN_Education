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
        }
        /// <summary>
        /// セル結合処理
        /// ※※※※※※※※※※※※※※※※※※※※※
        /// ※※※おそらくXAMLで対応できなさそう※※※
        /// ※※※※※※※※※※※※※※※※※※※※※
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gcgList_RowCollectionChanged(object sender, SpreadCollectionChangedEventArgs e)
        {
            this.gcgList.Columns[0].MergePolicy = MergePolicy.None;
            this.gcgList.Columns[1].MergePolicy = MergePolicy.None;
            this.gcgList.Columns[2].MergePolicy = MergePolicy.Always;
            this.gcgList.Columns[3].MergePolicy = MergePolicy.Restricted;
            this.gcgList.Columns[4].MergePolicy = MergePolicy.Restricted;
            this.gcgList.Columns[5].MergePolicy = MergePolicy.Restricted;
            this.gcgList.Columns[6].MergePolicy = MergePolicy.Restricted;
            this.gcgList.Columns[7].MergePolicy = MergePolicy.Restricted;
            this.gcgList.Columns[8].MergePolicy = MergePolicy.Restricted;
            this.gcgList.Columns[9].MergePolicy = MergePolicy.Restricted;
            //※※※最終列は指定できない！？※※※
            //this.gcgList.Columns[10].MergePolicy = MergePolicy.Restricted;
        }
        private void btnSearch_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.gcgList.SearchDialog.Show();
        }
    }
}
