using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Docking;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsApplication3
{
    public class MyDockManager : DockManager
    {
        public MyDockManager() : base() { }
        public MyDockManager(ContainerControl form) : base(form) { }
        public MyDockManager(IContainer container) : base(container) { }

        protected override VS2005StyleDockingVisualizer CreateVisualizer(VisualizerRole role)
        {
            if (!SupportVS2010DockingStyle())
                return new MyVS2005StyleDockingVisualizer(role, DockModeVS2005FadeSpeed, DockModeVS2005FadeFramesCount, this);
            return base.CreateVisualizer(role);
        }
    }

    public class MyVS2005StyleDockingVisualizer : VS2005StyleDockingVisualizer
    {
        DockManager manager;
        public MyVS2005StyleDockingVisualizer(VisualizerRole role, int fadeSpeed, int framesCount, DockManager manager)
            : base(role, fadeSpeed, framesCount)
        {
            this.manager = manager;
        }

        protected override void UpdateWindows()
        {
            DockPanel panel = manager.ActivePanel;
            if (panel.Options.AllowDockBottom)
                SetBoundsVisibility(GetFrame(VisualizerFormType.Bottom), this.viewInfoCore[VisualizerFormType.Bottom]);
            if (panel.Options.AllowDockFill)
                SetBoundsVisibility(GetFrame(VisualizerFormType.Center), this.viewInfoCore[VisualizerFormType.Center]);
            if (panel.Options.AllowDockLeft)
                SetBoundsVisibility(GetFrame(VisualizerFormType.Left), this.viewInfoCore[VisualizerFormType.Left]);
            if (panel.Options.AllowDockRight)
                SetBoundsVisibility(GetFrame(VisualizerFormType.Right), this.viewInfoCore[VisualizerFormType.Right]);
            if (panel.Options.AllowDockTop)
                SetBoundsVisibility(GetFrame(VisualizerFormType.Top), this.viewInfoCore[VisualizerFormType.Top]);
        }
    }
}
