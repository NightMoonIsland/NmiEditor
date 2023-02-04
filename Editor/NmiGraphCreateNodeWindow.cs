using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace NmiEditor
{
    public class NmiGraphCreateNodeWindow : ScriptableObject, ISearchWindowProvider
    {
        private NmiGraphView _nmiGraphView;
        private EditorWindow _nmiEditorWindow;

        public void Init(EditorWindow editorWindow, NmiGraphView dialogueGraphView)
        {
            _nmiEditorWindow = editorWindow;
            _nmiGraphView = dialogueGraphView;
        }

        public List<SearchTreeEntry> CreateSearchTree(SearchWindowContext context)
        {
            var tree = new List<SearchTreeEntry>
            {
                new SearchTreeGroupEntry(new GUIContent("Create Node"), level: 0),
                new SearchTreeGroupEntry(new GUIContent("Nodes"), level: 1),
            };
            return tree;
        }

        public bool OnSelectEntry(SearchTreeEntry SearchTreeEntry, SearchWindowContext context)
        {
            return false;
        }
    }
}
