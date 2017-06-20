﻿namespace Gu.Wpf.FlipView.Demo.Misc
{
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for ManipulationBox.xaml
    /// </summary>
    public partial class ManipulationBox : EventBox
    {
        public ManipulationBox()
        {
            this.InitializeComponent();
        }

        protected override void OnEnded(object sender, InputEventArgs e)
        {
            this.Args.Add(new ArgsVm(e));
        }
    }
}
