using Ghumakkad.Droid.CustomRenderers;
using Ghumakkad.Renderers;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]

namespace Ghumakkad.Droid.CustomRenderers
{
    public    class BorderlessEntryRenderer: EntryRenderer
    {
        [Obsolete]
        public BorderlessEntryRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null || e.NewElement == null) return;
            if (e.NewElement is BorderlessEntry)
            {
                Control.Background = null;

            }
        }
    }
}