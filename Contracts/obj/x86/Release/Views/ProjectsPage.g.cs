﻿

#pragma checksum "C:\Users\Dapo Oloruntola\Desktop\Contracts\Contracts\Views\ProjectsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D3184127774B787BC8B342C859A7274D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contracts.Views
{
    partial class ProjectsPage : global::Contracts.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 75 "..\..\..\Views\ProjectsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AddButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 65 "..\..\..\Views\ProjectsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.EditButton_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 111 "..\..\..\Views\ProjectsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.ProjectsGridView_ItemClick;
                 #line default
                 #line hidden
                #line 112 "..\..\..\Views\ProjectsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ProjectsGridView_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 94 "..\..\..\Views\ProjectsPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.BackButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


