﻿#pragma checksum "..\..\..\Vue\AfficherPlage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2EA43654D7A4F52F0F1F5927E8449A47BD1A33561AEBE86383930D722EE8E3CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Projet_CS.Vue;
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


namespace Projet_CS.Vue {
    
    
    /// <summary>
    /// AfficherPlages
    /// </summary>
    public partial class AfficherPlages : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Vue\AfficherPlage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grigrid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Vue\AfficherPlage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nomTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Vue\AfficherPlage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idCommuneTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Vue\AfficherPlage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nbEspecesDifferentesTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Vue\AfficherPlage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surfaceTextBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Vue\AfficherPlage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRetourForm;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Vue\AfficherPlage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAjt;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Vue\AfficherPlage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid listePlages;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Vue\AfficherPlage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSuppr;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Vue\AfficherPlage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRetourData;
        
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
            System.Uri resourceLocater = new System.Uri("/Projet CS;component/vue/afficherplage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vue\AfficherPlage.xaml"
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
            this.grigrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.nomTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.idCommuneTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.nbEspecesDifferentesTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.surfaceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnRetourForm = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Vue\AfficherPlage.xaml"
            this.btnRetourForm.Click += new System.Windows.RoutedEventHandler(this.retourMenu);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAjt = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Vue\AfficherPlage.xaml"
            this.btnAjt.Click += new System.Windows.RoutedEventHandler(this.ajouterButton);
            
            #line default
            #line hidden
            return;
            case 8:
            this.listePlages = ((System.Windows.Controls.DataGrid)(target));
            
            #line 38 "..\..\..\Vue\AfficherPlage.xaml"
            this.listePlages.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listePlages_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnSuppr = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Vue\AfficherPlage.xaml"
            this.btnSuppr.Click += new System.Windows.RoutedEventHandler(this.supprimerButton);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnRetourData = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\Vue\AfficherPlage.xaml"
            this.btnRetourData.Click += new System.Windows.RoutedEventHandler(this.retourMenu);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
