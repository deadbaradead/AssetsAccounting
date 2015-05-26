﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AssetsAccounting.ViewModels;
using Microsoft.Practices.Unity;

namespace AssetsAccounting.Views
{
    /// <summary>
    /// Interaction logic for AssetsDictionaryView.xaml
    /// </summary>
    public partial class AssetsDictionaryView : UserControl
    {
        public AssetsDictionaryView(IUnityContainer container)
        {
            DataContext = container.Resolve<AssetsDictionaryViewModel>();
            InitializeComponent();
        }
    }
}
