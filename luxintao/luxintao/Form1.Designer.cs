namespace luxintao
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("硬盘", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("移动存储", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("其它", System.Windows.Forms.HorizontalAlignment.Left);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backBtn = new System.Windows.Forms.ToolStripButton();
            this.forwardBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchBtn = new System.Windows.Forms.ToolStripButton();
            this.urlComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.searchContent = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toTopBtn = new System.Windows.Forms.ToolStripButton();
            this.refreshBtn = new System.Windows.Forms.ToolStripButton();
            this.propertyBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutBtn = new System.Windows.Forms.ToolStripButton();
            this.copyBtn = new System.Windows.Forms.ToolStripButton();
            this.pasteBtn = new System.Windows.Forms.ToolStripButton();
            this.newFolderBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderTBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_totale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_avail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backBtn,
            this.forwardBtn,
            this.toolStripLabel1,
            this.searchBtn,
            this.urlComboBox,
            this.searchContent});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(0, 50);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 50);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(977, 50);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // backBtn
            // 
            this.backBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backBtn.Image = global::luxintao.Properties.Resources.back;
            this.backBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(24, 47);
            this.backBtn.Text = "toolStripButton1";
            // 
            // forwardBtn
            // 
            this.forwardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardBtn.Image = global::luxintao.Properties.Resources.forward;
            this.forwardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(24, 47);
            this.forwardBtn.Text = "toolStripButton2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 47);
            this.toolStripLabel1.Text = "地址:";
            // 
            // searchBtn
            // 
            this.searchBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchBtn.Image = global::luxintao.Properties.Resources.search;
            this.searchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBtn.Size = new System.Drawing.Size(24, 47);
            this.searchBtn.Text = "toolStripButton3";
            // 
            // urlComboBox
            // 
            this.urlComboBox.Name = "urlComboBox";
            this.urlComboBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.urlComboBox.Size = new System.Drawing.Size(465, 50);
            // 
            // searchContent
            // 
            this.searchContent.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.searchContent.AutoSize = false;
            this.searchContent.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.searchContent.Name = "searchContent";
            this.searchContent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchContent.Size = new System.Drawing.Size(132, 27);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toTopBtn,
            this.refreshBtn,
            this.propertyBtn,
            this.toolStripSeparator1,
            this.cutBtn,
            this.copyBtn,
            this.pasteBtn,
            this.newFolderBtn,
            this.deleteBtn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 50);
            this.toolStrip2.MaximumSize = new System.Drawing.Size(0, 50);
            this.toolStrip2.MinimumSize = new System.Drawing.Size(0, 50);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(977, 50);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toTopBtn
            // 
            this.toTopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toTopBtn.Image = global::luxintao.Properties.Resources.top;
            this.toTopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toTopBtn.Name = "toTopBtn";
            this.toTopBtn.Size = new System.Drawing.Size(36, 47);
            this.toTopBtn.Text = "toolStripButton4";
            this.toTopBtn.ToolTipText = "向上一层";
            // 
            // refreshBtn
            // 
            this.refreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshBtn.Image = global::luxintao.Properties.Resources.refresh;
            this.refreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(36, 47);
            this.refreshBtn.ToolTipText = "刷新";
            // 
            // propertyBtn
            // 
            this.propertyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.propertyBtn.Image = global::luxintao.Properties.Resources.porperty;
            this.propertyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.propertyBtn.Name = "propertyBtn";
            this.propertyBtn.Size = new System.Drawing.Size(36, 47);
            this.propertyBtn.Text = "toolStripButton6";
            this.propertyBtn.ToolTipText = "属性";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // cutBtn
            // 
            this.cutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutBtn.Image = global::luxintao.Properties.Resources.cut;
            this.cutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutBtn.Name = "cutBtn";
            this.cutBtn.Size = new System.Drawing.Size(36, 47);
            this.cutBtn.Text = "toolStripButton4";
            this.cutBtn.ToolTipText = "剪切";
            // 
            // copyBtn
            // 
            this.copyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyBtn.Image = global::luxintao.Properties.Resources.copy;
            this.copyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(36, 47);
            this.copyBtn.Text = "toolStripButton4";
            this.copyBtn.ToolTipText = "复制";
            // 
            // pasteBtn
            // 
            this.pasteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteBtn.Image = global::luxintao.Properties.Resources.paste;
            this.pasteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(36, 47);
            this.pasteBtn.Text = "toolStripButton4";
            this.pasteBtn.ToolTipText = "粘贴";
            // 
            // newFolderBtn
            // 
            this.newFolderBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newFolderBtn.Image = global::luxintao.Properties.Resources.newfolder;
            this.newFolderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFolderBtn.Name = "newFolderBtn";
            this.newFolderBtn.Size = new System.Drawing.Size(36, 47);
            this.newFolderBtn.Text = "toolStripButton4";
            this.newFolderBtn.ToolTipText = "新建文件夹";
            // 
            // deleteBtn
            // 
            this.deleteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteBtn.Image = global::luxintao.Properties.Resources.delete;
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(36, 47);
            this.deleteBtn.Text = "toolStripButton5";
            this.deleteBtn.ToolTipText = "删除";
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.newFolderTBtn,
            this.toolStripSplitButton2});
            this.toolStrip3.Location = new System.Drawing.Point(0, 100);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(977, 27);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.剪切ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.重命名ToolStripMenuItem,
            this.属性ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(58, 24);
            this.toolStripSplitButton1.Text = "组织";
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.剪切ToolStripMenuItem.Text = "剪切";
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.重命名ToolStripMenuItem.Text = "重命名";
            // 
            // 属性ToolStripMenuItem
            // 
            this.属性ToolStripMenuItem.Name = "属性ToolStripMenuItem";
            this.属性ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.属性ToolStripMenuItem.Text = "属性";
            // 
            // newFolderTBtn
            // 
            this.newFolderTBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newFolderTBtn.Image = ((System.Drawing.Image)(resources.GetObject("newFolderTBtn.Image")));
            this.newFolderTBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFolderTBtn.Name = "newFolderTBtn";
            this.newFolderTBtn.Size = new System.Drawing.Size(88, 24);
            this.newFolderTBtn.Text = "新建文件夹";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标ToolStripMenuItem,
            this.小图标ToolStripMenuItem,
            this.列表ToolStripMenuItem,
            this.详细信息ToolStripMenuItem,
            this.详细大图标ToolStripMenuItem});
            this.toolStripSplitButton2.Image = global::luxintao.Properties.Resources.menu;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // 大图标ToolStripMenuItem
            // 
            this.大图标ToolStripMenuItem.Name = "大图标ToolStripMenuItem";
            this.大图标ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.大图标ToolStripMenuItem.Text = "大图标";
            // 
            // 小图标ToolStripMenuItem
            // 
            this.小图标ToolStripMenuItem.Name = "小图标ToolStripMenuItem";
            this.小图标ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.小图标ToolStripMenuItem.Text = "小图标";
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.列表ToolStripMenuItem.Text = "列表";
            // 
            // 详细信息ToolStripMenuItem
            // 
            this.详细信息ToolStripMenuItem.Name = "详细信息ToolStripMenuItem";
            this.详细信息ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.详细信息ToolStripMenuItem.Text = "详细列表";
            // 
            // 详细大图标ToolStripMenuItem
            // 
            this.详细大图标ToolStripMenuItem.Name = "详细大图标ToolStripMenuItem";
            this.详细大图标ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.详细大图标ToolStripMenuItem.Text = "详细大图标";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 559);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(977, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList3;
            this.treeView1.Location = new System.Drawing.Point(0, 127);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(307, 432);
            this.treeView1.TabIndex = 4;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "desktop.png");
            this.imageList3.Images.SetKeyName(1, "pc.png");
            this.imageList3.Images.SetKeyName(2, "mydoc.png");
            this.imageList3.Images.SetKeyName(3, "mymusic.png");
            this.imageList3.Images.SetKeyName(4, "mypic.png");
            this.imageList3.Images.SetKeyName(5, "myvideo.png");
            this.imageList3.Images.SetKeyName(6, "recycle.png");
            this.imageList3.Images.SetKeyName(7, "favorites.png");
            this.imageList3.Images.SetKeyName(8, "cdrom.png");
            this.imageList3.Images.SetKeyName(9, "movabledriver.png");
            this.imageList3.Images.SetKeyName(10, "localdriver.png");
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_type,
            this.ch_totale,
            this.ch_avail});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "硬盘";
            listViewGroup1.Name = "mGroup1";
            listViewGroup2.Header = "移动存储";
            listViewGroup2.Name = "mGroup2";
            listViewGroup3.Header = "其它";
            listViewGroup3.Name = "mGroup3";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(307, 127);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(670, 432);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ch_name
            // 
            this.ch_name.Text = "名称";
            // 
            // ch_type
            // 
            this.ch_type.Text = "类型";
            // 
            // ch_totale
            // 
            this.ch_totale.Text = "总大小";
            // 
            // ch_avail
            // 
            this.ch_avail.Text = "可用空间";
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(20, 20);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 581);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "卢心陶-资源管理器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton backBtn;
        private System.Windows.Forms.ToolStripButton forwardBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox urlComboBox;
        private System.Windows.Forms.ToolStripTextBox searchContent;
        private System.Windows.Forms.ToolStripButton searchBtn;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toTopBtn;
        private System.Windows.Forms.ToolStripButton refreshBtn;
        private System.Windows.Forms.ToolStripButton propertyBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cutBtn;
        private System.Windows.Forms.ToolStripButton copyBtn;
        private System.Windows.Forms.ToolStripButton pasteBtn;
        private System.Windows.Forms.ToolStripButton newFolderBtn;
        private System.Windows.Forms.ToolStripButton deleteBtn;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newFolderTBtn;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem 大图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详细信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详细大图标ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_type;
        private System.Windows.Forms.ColumnHeader ch_totale;
        private System.Windows.Forms.ColumnHeader ch_avail;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
    }
}

