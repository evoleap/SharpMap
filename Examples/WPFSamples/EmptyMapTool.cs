using GeoAPI.Geometries;
using SharpMap;
using SharpMap.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WPFSamples
{
    public class EmptyMapTool : IMapTool
    {

        public string Name => throw new NotImplementedException();
        public string Description => throw new NotImplementedException();

        public Map Map { get; set; }
        public bool Enabled { get; set; }

        public Cursor Cursor => Cursors.Default;

        public event EventHandler EnabledChanged;
        public event EventHandler CursorChanged;

        public bool DoKeyDown(Coordinate mapPosition, KeyEventArgs keyEventArgs) => false;
        public bool DoKeyUp(Coordinate mapPosition, KeyEventArgs keyEventArgs) => false;
        public bool DoMouseDoubleClick(Coordinate mapPosition, MouseEventArgs mouseEventArgs) => false;
        public bool DoMouseDown(Coordinate mapPosition, MouseEventArgs mouseEventArgs) => false;
        public bool DoMouseEnter() => false;
        public bool DoMouseHover(Coordinate mapPosition) => false;
        public bool DoMouseLeave() => false;
        public bool DoMouseMove(Coordinate mapPosition, MouseEventArgs mouseEventArgs) => false;
        public bool DoMouseUp(Coordinate mapPosition, MouseEventArgs mouseEventArgs) => false;
        public bool DoMouseWheel(Coordinate mapPosition, MouseEventArgs mouseEventArgs) => false;
        public void DoPaint(PaintEventArgs e) { }

    }
}
