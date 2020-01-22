﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO_Project.Core.Analysis.Models;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.GraphViewerGdi;
using DrawingEdge = Microsoft.Msagl.Drawing.Edge;
using DrawingNode = Microsoft.Msagl.Drawing.Node;
namespace IO_Project.Graph
{
    class GraphDrawer
    {
        private GViewer _gViewer;
        private SourceAnalysisModel _mainModel;
        public bool methodsToMethods, methodsToNamespaces, methodsToFiles, filesToFiles;
        private Microsoft.Msagl.Drawing.Graph graph1, graph2;
        public GraphDrawer(GViewer gViewer)
        {
            _gViewer = gViewer;
        }
        public void GenerateGraphForSourceAnalysis(SourceAnalysisModel model)
        {
            _mainModel = model;
            if (filesToFiles == true) GenerateFilesGraph();
            else if (methodsToMethods || methodsToNamespaces || methodsToFiles) GenerateMethodsGraph();
        }
        public void GenerateMethodsGraph()
        {
            
        }
        public void GenerateFilesGraph()
        {
            
        }
    }
}