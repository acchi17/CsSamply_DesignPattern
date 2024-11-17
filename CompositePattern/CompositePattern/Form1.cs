using CompositePattern.Data;
using CompositePattern.Objects;
using System.Xml.Linq;

namespace CompositePattern
{
    public partial class Form1 : Form
    {
        private List<Entry> _entries = new List<Entry>();
        public Form1()
        {
            InitializeComponent();
            treeView1.HideSelection = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTree(treeView1);
            UpdateTree(treeView1);
            treeView1.ExpandAll();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ReleaseHighlight(treeView1);
            SearchAndHighlight(textBoxSearch.Text, treeView1);
        }

        private void buttonRelease_Click(object sender, EventArgs e)
        {
            ReleaseHighlight(treeView1);
        }

        #region Main methods
        private void CreateTree(TreeView tree)
        {
            var entries = new List<Entry>();

            var entities = TreeDB.GetTree();
            foreach (var entity in entities)
            {
                if (entity.Kind == 1)
                {
                    _entries.Add(new AppDirectory(entity));
                }
                else if (entity.Kind == 2)
                {
                    _entries.Add(new AppFile(entity));
                }
            }
            foreach (var entry in _entries)
            {
                var parent = _entries.Find(x => x.Id == entry.ParentId);
                if (parent != null)
                {
                    parent.Add(entry);
                }
            }

            AddEntryToTree(entries, tree);

        }
        private void SearchAndHighlight(string text, TreeView tree)
        {
            var list = new List<Entry>();
            SearchForTree(tree, text, list);
            if (list.Count > 0)
            {
                foreach (var entry in list)
                {
                    entry.Highlight();
                }
            }
            UpdateTree(tree);
        }

        private void ReleaseHighlight(TreeView tree)
        {
            ReleaseInTree(tree);
            UpdateTree(tree);
        }
        #endregion

        #region Add entry
        private void AddEntryToTree(List<Entry> entries, TreeView tree)
        {
            var roots = _entries.FindAll(x => x.ParentId == 0);
            foreach (var root in roots)
            {
                AddEntryToTreeRecur(root, null);
            }
        }

        private void AddEntryToTreeRecur(Entry entry, TreeNode? parent)
        {
            var node = new TreeNode(entry.Name, 0, 0);
            node.Tag = entry;

            if (parent == null)
            {
                treeView1.Nodes.Add(node);
            }
            else
            {
                parent.Nodes.Add(node);
            }

            foreach (var child in entry.GetChildren())
            {
                AddEntryToTreeRecur(child, node);
            }
        }
        #endregion

        #region Search
        private void SearchForTree(TreeView tree, string name, List<Entry> foundEntries)
        {
            foreach (TreeNode node in tree.Nodes)
            {
                SearchForTreeRecur(node, name, foundEntries);
            }
        }

        private void SearchForTreeRecur(TreeNode node, string name, List<Entry> foundEntries)
        {
            var entry = node.Tag as Entry;
            if (entry != null)
            {
                if (entry.Name.Contains(name))
                {
                    foundEntries.Add(entry);
                }
            }

            foreach (TreeNode child in node.Nodes)
            {
                SearchForTreeRecur(child, name, foundEntries);
            }
        }
        #endregion

        #region Release
        private void ReleaseInTree(TreeView tree)
        {
            foreach (TreeNode node in tree.Nodes)
            {
                ReleaseInTreeRecur(node);
            }
        }

        private void ReleaseInTreeRecur(TreeNode node)
        {
            var entry = node.Tag as Entry;
            if (entry != null)
            {
                entry.Release();
            }

            foreach (TreeNode child in node.Nodes)
            {
                ReleaseInTreeRecur(child);
            }
        }
        #endregion

        #region Update
        private void UpdateTree(TreeView tree)
        {
            foreach (TreeNode node in tree.Nodes)
            {
                UpdateTreeRecur(node);
            }
        }

        private void UpdateTreeRecur(TreeNode node)
        {
            var entry = node.Tag as Entry;
            if (entry != null)
            {
                if (entry.IsHighlight)
                {
                    node.ImageIndex = 2;
                    node.SelectedImageIndex = 2;
                }
                else
                {
                    if (entry.Kind == 1)
                    {
                        node.ImageIndex = 0;
                        node.SelectedImageIndex = 0;
                    }
                    else if (entry.Kind == 2)
                    {
                        node.ImageIndex = 1;
                        node.SelectedImageIndex = 1;
                    }
                }
            }

            foreach (TreeNode child in node.Nodes)
            {
                UpdateTreeRecur(child);
            }
        }
        #endregion
    }
}
