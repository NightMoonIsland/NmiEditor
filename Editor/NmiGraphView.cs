using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace NmiEditor
{
    public class NmiGraphView : GraphView
    {

        public static readonly Vector2 DEFAULT_NODE_SIZE = new Vector2(150f, 200f);
        public static readonly Vector2 DEFAULT_NODE_POSITION = new Vector2(350f, 200f);

        public NmiGraphView()
        {
            styleSheets.Add(Resources.Load<StyleSheet>("DialogueGraphStyle"));

            SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale);

            this.AddManipulator(new ContentDragger());
            this.AddManipulator(new SelectionDragger());
            this.AddManipulator(new RectangleSelector());

            var grid = new GridBackground();
            Insert(0, grid);
            grid.StretchToParentSize();

        }
    }
}