using System;
using UnityEditor.Experimental.GraphView;

namespace NmiEditor
{
    public class EntityNode : Node
    {
        public string GUID;

        public EntityNode() : base()
        {
            GUID = Guid.NewGuid().ToString().Substring(0, 8);
        }

    }
}