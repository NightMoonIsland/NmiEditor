using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NmiEditor
{
    public class NmiGraphData : ScriptableObject
    {
        public List<NodeData> Nodes = new List<NodeData>();

        public List<LineData> NodeLinks = new List<LineData>();
    }
}