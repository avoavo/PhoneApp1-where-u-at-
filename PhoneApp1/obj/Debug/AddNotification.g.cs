﻿#pragma checksum "C:\Users\Christine\Desktop\HackUCI\PhoneApp1\PhoneApp1\AddNotification.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EE182DCD0EF18EC95CFAF9CA7753C5D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace OnTimeAlarm {
    
    
    public partial class Page1 : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock AlarmName;
        
        internal System.Windows.Controls.TextBox titleTextBox;
        
        internal System.Windows.Controls.TextBlock destinationLabel;
        
        internal System.Windows.Controls.TextBox destinationTextBox;
        
        internal System.Windows.Controls.TextBlock beginTimeLabel;
        
        internal Microsoft.Phone.Controls.TimePicker expirationTimePicker;
        
        internal Microsoft.Phone.Controls.DatePicker expirationDatePicker;
        
        internal System.Windows.Controls.TextBlock expirationTimeLabel;
        
        internal System.Windows.Controls.TextBox txtBuffer;
        
        internal System.Windows.Controls.TextBlock repeatLabel;
        
        internal System.Windows.Controls.RadioButton onceRadioButton;
        
        internal System.Windows.Controls.RadioButton weeklyRadioButton;
        
        internal System.Windows.Controls.RadioButton dailyRadioButton;
        
        internal System.Windows.Controls.RadioButton monthlyRadioButton;
        
        internal System.Windows.Controls.RadioButton endOfMonthRadioButton;
        
        internal System.Windows.Controls.RadioButton yearlyRadioButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneApp1;component/AddNotification.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.AlarmName = ((System.Windows.Controls.TextBlock)(this.FindName("AlarmName")));
            this.titleTextBox = ((System.Windows.Controls.TextBox)(this.FindName("titleTextBox")));
            this.destinationLabel = ((System.Windows.Controls.TextBlock)(this.FindName("destinationLabel")));
            this.destinationTextBox = ((System.Windows.Controls.TextBox)(this.FindName("destinationTextBox")));
            this.beginTimeLabel = ((System.Windows.Controls.TextBlock)(this.FindName("beginTimeLabel")));
            this.expirationTimePicker = ((Microsoft.Phone.Controls.TimePicker)(this.FindName("expirationTimePicker")));
            this.expirationDatePicker = ((Microsoft.Phone.Controls.DatePicker)(this.FindName("expirationDatePicker")));
            this.expirationTimeLabel = ((System.Windows.Controls.TextBlock)(this.FindName("expirationTimeLabel")));
            this.txtBuffer = ((System.Windows.Controls.TextBox)(this.FindName("txtBuffer")));
            this.repeatLabel = ((System.Windows.Controls.TextBlock)(this.FindName("repeatLabel")));
            this.onceRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("onceRadioButton")));
            this.weeklyRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("weeklyRadioButton")));
            this.dailyRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("dailyRadioButton")));
            this.monthlyRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("monthlyRadioButton")));
            this.endOfMonthRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("endOfMonthRadioButton")));
            this.yearlyRadioButton = ((System.Windows.Controls.RadioButton)(this.FindName("yearlyRadioButton")));
        }
    }
}

