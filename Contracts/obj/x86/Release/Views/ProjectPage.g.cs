﻿

#pragma checksum "C:\Users\Dapo Oloruntola\Desktop\Contracts\Contracts\Views\ProjectPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1DA3A0A6A3A06D1697A3EFAF9841ED45"
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
    partial class ProjectPage : global::Contracts.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 24 "..\..\..\Views\ProjectPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SaveButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 26 "..\..\..\Views\ProjectPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.StartLayoutUpdates;
                 #line default
                 #line hidden
                #line 26 "..\..\..\Views\ProjectPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.DeleteButton_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 44 "..\..\..\Views\ProjectPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.BackButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


