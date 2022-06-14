using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;

namespace Wpf_ImageViewer.Mvvm
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        private static bool? _isInDesignMode;

        protected ViewModelBase()
        {
        }

        public virtual String DisplayName { get; protected set; }

        protected virtual bool ThrowOnInvalidPropertyNames { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the control is in design mode
        ///             (running under Blend or Visual Studio).
        /// 
        /// </summary>
        public bool IsInDesignMode
        {
            get
            {
                return IsInDesignModeStatic;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the control is in design mode
        ///             (running in Blend or Visual Studio).
        /// 
        /// </summary>
        public static bool IsInDesignModeStatic
        {
            get
            {
                if (!_isInDesignMode.HasValue)
                    _isInDesignMode = new bool?((bool)DependencyPropertyDescriptor.FromProperty(
                        DesignerProperties.IsInDesignModeProperty, typeof(FrameworkElement)).Metadata.DefaultValue);
                return _isInDesignMode.Value;
            }
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public void VerifyPropertyName(string propertyName)
        {
            if (null == TypeDescriptor.GetProperties(this)[propertyName])
            {
                string msg = "Invalid property name: " + propertyName;
                if (ThrowOnInvalidPropertyNames)
                    throw new Exception(msg);
                else
                    Debug.Fail(msg);
            }
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            VerifyPropertyName(propertyName);
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}