using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace luxintao
{
    public partial class Form1 : Form
    {
        private string currentPath = "";//当前所在路径
        private string[] copyFileSources = new string[100];//复制文件的路径
        private bool isMove = false;//是否移动
        private ArrayList accessPaths = new ArrayList();//访问过的路径数组

        public Form1()
        {
            InitializeComponent();
        }


        /**
         *窗口初始化事件
         * 此处需要初始化treeview与listview
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            initTreeView();//初始化树形
            initDriverListView();//初始化listView显示信息
            accessPaths.Add("计算机");
            urlComboBox.ComboBox.DataSource = accessPaths;
            urlComboBox.ComboBox.SelectedIndex = 0;
        }


        /**
         *初始化treeview
         */
        private void initTreeView()
        {
            treeView1.ImageList = imageList3;//设置treeview的图片列表
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();//清空节点
            //桌面节点
            string myPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            TreeNode deskTop = new TreeNode("桌面");
            deskTop.ImageKey = deskTop.SelectedImageKey = "desktop.png";
            deskTop.Tag = myPath;//包含树节点的有关数据的对象
            treeView1.Nodes.Add(deskTop);

            //计算机节点
            myPath = "mycomputer";
            TreeNode pc = new TreeNode("计算机");
            pc.ImageKey = pc.SelectedImageKey = "pc.png";
            pc.Tag = myPath;
            treeView1.Nodes.Add(pc);
            //在计算机下添加驱动器的根节点
            this.listAllDrivers(pc);
            pc.Expand(); //展开计算机节点
            
            //收藏夹
            myPath = "favorites";
            TreeNode favorites = new TreeNode("收藏夹");
            favorites.ImageKey = favorites.SelectedImageKey = "favorites.png";
            favorites.Tag = myPath;
            treeView1.Nodes.Add(favorites);
            //在收藏夹节点下添加我的文档，我的图片，我的音乐，我的视频子节点
            myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            TreeNode myDoc = new TreeNode("我的文档");
            myDoc.SelectedImageKey=myDoc.ImageKey = "mydoc.png";
            myDoc.Tag = myPath;
            favorites.Nodes.Add(myDoc);

            //我的音乐
            myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) ;
            TreeNode myMusic = new TreeNode("我的音乐");
            myMusic.SelectedImageKey = myMusic.ImageKey = "mymusic.png";
            myMusic.Tag = myPath;
            favorites.Nodes.Add(myMusic);

            //我的图片
            myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            TreeNode myPicture = new TreeNode("我的图片");
            myPicture.SelectedImageKey = myPicture.ImageKey = "mypic.png";
            myPicture.Tag = myPath;
            favorites.Nodes.Add(myPicture);

            //我的视频
            myPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            TreeNode myVideo = new TreeNode("我的视频");
            myVideo.SelectedImageKey = myVideo.ImageKey = "myvideo.png";
            myVideo.Tag = myPath;
            favorites.Nodes.Add(myVideo);

            //回收站
            myPath = "recycle";
            TreeNode recycle = new TreeNode("回收站");
            recycle.SelectedImageKey = recycle.ImageKey = "recycle.png";
            recycle.Tag = myPath;
            treeView1.Nodes.Add(recycle);
            treeView1.EndUpdate();
        }

        /**
         *列出计算机上的所有磁盘
         *<param name="root">根节点</param>
         * 
         */
        private void listAllDrivers(TreeNode root)
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();//获取驱动器集合
            string keyName = "";//驱动器类型键名
            string driverName = "";//驱动器卷标
            string driverTag = "";//驱动器实际名称  e.g. C:\\
            foreach(DriveInfo driver in drivers){
                if (driver.IsReady) driverName = driver.VolumeLabel;//驱动器卷标
                else driverName = "";
                switch(driver.DriveType){
                    case DriveType.Fixed:
                        keyName = "localdriver";
                        if (driverName.Equals("")) driverName = "本地磁盘";
                        break;//本地磁盘
                    case DriveType.Removable:
                        keyName = "movabledriver";
                        if (driverName.Equals("")) driverName = "可移动磁盘";
                        break;//可移动磁盘
                    case DriveType.CDRom:
                        keyName = "cdrom";
                        if (driverName.Equals("")) driverName = "光盘驱动器";
                        break;
                    default:
                        keyName = "movabledriver";
                        if (driverName.Equals("")) driverName = "未知设备";
                        break;
                }
                driverName = driverName + "(" +driver.Name.Substring(0,2)+ ")";
                driverTag = driver.Name;
                TreeNode driverTreeNode = new TreeNode(driverName);
                driverTreeNode.SelectedImageKey = driverTreeNode.ImageKey = keyName+".png";
                driverTreeNode.Tag = driverTag;
                if(driver.IsReady){//如果该驱动in position 查看是否有子目录，如有显示+
                    DirectoryInfo driver_info = new DirectoryInfo(driver.Name);
                    DirectoryInfo[] dirs = driver_info.GetDirectories();//获取元素
                    if (dirs.Length > 0) driverTreeNode.Nodes.Add("temp");
                }
                root.Nodes.Add(driverTreeNode);//添加子节点
            }
        }


        /**
         *初始化listView显示信息
         * TODO：获取驱动器信息，显示在listView上
         */
        private void initDriverListView() {
            listView1.Items.Clear();//清空信息
            //创建列  TODO:
            DriveInfo[] drivers = DriveInfo.GetDrives();//提取集合
            string lvName1, lvName2, lvType, keyName, lvTotal="", lvFree="";
            foreach(DriveInfo driver in drivers){
                ListViewItem newItem = new ListViewItem();
                newItem.IndentCount=1;//设置要缩进的小图像的数量
                if (driver.IsReady) lvName1 = driver.VolumeLabel;//卷标
                else lvName1 = "";
                lvName2 = driver.Name;//驱动器名称 e.g. C:\
                switch(driver.DriveType){
                    case DriveType.Fixed: {
                        keyName = "localdriver";
                        lvType = "本地磁盘";//磁盘类型
                        if (lvName1.Equals("")) lvName1 = "本地磁盘";
                        newItem.Group=listView1.Groups["mGroup1"];//添加到磁盘组
                        break;
                    }
                    case DriveType.Removable:{
                            keyName = "movabledriver";
                            lvType = "移动存储";
                            if (lvName1.Equals("")) lvName1 = "可移动磁盘";
                            break;
                        }

                }
            }
        }
  
    }
}
