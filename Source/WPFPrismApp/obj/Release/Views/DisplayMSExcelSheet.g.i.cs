﻿#pragma checksum "..\..\..\Views\DisplayMSExcelSheet.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E6A00B0328CF1FADF5EE3E28270B33BEE8EA751D31DC97FDB2715EACD3A8819B"
//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

using GrapeCity.Wpf.SpreadSheet;
using GrapeCity.Wpf.SpreadSheet.CellType.Editors;
using Prism.Interactivity;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
using Prism.Services.Dialogs;
using Prism.Unity;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BAMTS.Internal {
    
    
    /// <summary>
    /// DisplayMSExcelSheet
    /// </summary>
    public partial class DisplayMSExcelSheet : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Views\DisplayMSExcelSheet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpenFile;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\DisplayMSExcelSheet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveFile;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\DisplayMSExcelSheet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReset;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\DisplayMSExcelSheet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GrapeCity.Wpf.SpreadSheet.GcSpreadSheet gcSpreadSheet1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFPrismApp;component/views/displaymsexcelsheet.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\DisplayMSExcelSheet.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnOpenFile = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Views\DisplayMSExcelSheet.xaml"
            this.btnOpenFile.Click += new System.Windows.RoutedEventHandler(this.btnOpenFile_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSaveFile = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Views\DisplayMSExcelSheet.xaml"
            this.btnSaveFile.Click += new System.Windows.RoutedEventHandler(this.btnSaveFile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnReset = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Views\DisplayMSExcelSheet.xaml"
            this.btnReset.Click += new System.Windows.RoutedEventHandler(this.btnReset_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.gcSpreadSheet1 = ((GrapeCity.Wpf.SpreadSheet.GcSpreadSheet)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
