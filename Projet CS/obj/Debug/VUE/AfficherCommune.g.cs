﻿#pragma checksum "..\..\..\Vue\AfficherCommune.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1852B48DBC2D82BE2F6646FCD3848D47F73B8F9E83A2209A39434CC5AC3ADD1C"
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
    /// AfficherCommune
    /// </summary>
    public partial class AfficherCommune : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Vue\AfficherCommune.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grigrid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Vue\AfficherCommune.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nomTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Vue\AfficherCommune.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idDepartementTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Vue\AfficherCommune.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRetourForm;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Vue\AfficherCommune.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAjt;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Vue\AfficherCommune.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid listeCommunes;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Vue\AfficherCommune.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSuppr;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Vue\AfficherCommune.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Projet CS;component/vue/affichercommune.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vue\AfficherCommune.xaml"
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
            this.idDepartementTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnRetourForm = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Vue\AfficherCommune.xaml"
            this.btnRetourForm.Click += new System.Windows.RoutedEventHandler(this.retourMenu);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAjt = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Vue\AfficherCommune.xaml"
            this.btnAjt.Click += new System.Windows.RoutedEventHandler(this.ajouterButton);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listeCommunes = ((System.Windows.Controls.DataGrid)(target));
            
            #line 42 "..\..\..\Vue\AfficherCommune.xaml"
            this.listeCommunes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listeCommunes_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSuppr = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Vue\AfficherCommune.xaml"
            this.btnSuppr.Click += new System.Windows.RoutedEventHandler(this.supprimerButton);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnRetourData = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Vue\AfficherCommune.xaml"
            this.btnRetourData.Click += new System.Windows.RoutedEventHandler(this.retourMenu);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
