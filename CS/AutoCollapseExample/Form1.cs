using System;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;

namespace AutoCollapseExample {
    public partial class MainForm :XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        private void OnTreeListAfterExpand(object sender, NodeEventArgs e) {
            ((TreeList)sender).NodesIterator.DoOperation(new AutoCollapseNodeOperation(e.Node));
        }
    }

    public class AutoCollapseNodeOperation :TreeListOperation {
        private TreeListNode fNode;
        public AutoCollapseNodeOperation(TreeListNode node) {
            fNode = node;
        }
        public override void Execute(TreeListNode node) {
            if (!(node == fNode) && node.Expanded && !node.HasAsParent(fNode) && !fNode.HasAsParent(node))
                node.Expanded = false;
        }
    }
}