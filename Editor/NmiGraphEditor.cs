using System.IO;
using System.Threading;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace NmiEditor
{
    public class NmiGraphEditor : EditorWindow
    {
        #region MenuItem
        [MenuItem("Nmi/NmiGraph")]
        public static void OpenNmiGraphEditor()
        {
            var window = GetWindow<NmiGraphEditor>();
            window.titleContent = new GUIContent("NmiGraph");
        }
        #endregion

        private NmiGraphView _graphView;
        private NmiGraphCreateNodeWindow _createNodeWindow;

        private void OnEnable()
        {
            CreateGraph();
            CreateToolbar();
            CreateSearchWindow();
        }

        private void OnDisable()
        {
            rootVisualElement.Remove(_graphView);
        }

        private void OnGUI()
        {
            this.position = new Rect(200, 100, 1080, 640);
        }

        private void CreateGraph()
        {
            _graphView = new NmiGraphView();

            _graphView.StretchToParentSize();
            rootVisualElement.Add(_graphView);
        }

        private void CreateToolbar()
        {
            var toolbar = new Toolbar();
            toolbar.Add(new UnityEngine.UIElements.VisualElement());
            rootVisualElement.Add(toolbar);
        }

        private void CreateSearchWindow()
        {
            _createNodeWindow = CreateInstance<NmiGraphCreateNodeWindow>();
            _createNodeWindow.Init(this, _graphView);
            _graphView.nodeCreationRequest = context =>
                SearchWindow.Open(new SearchWindowContext(context.screenMousePosition), _createNodeWindow);
        }

    }
}