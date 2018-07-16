using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using SGP.HCBBOOK.GameMenu.UI.Logic.IService;
using SGP.HCBBOOK.GameMenu.UI.Logic.Service;
using Bunifu.Framework.UI;

namespace SGP.HCBBOOK.GameMenu.UI.FormPartial
{
    public partial class ContainControlCategoryGame : DevExpress.XtraEditors.XtraUserControl
    {
        IList<XtraUserControl> xtraUserControls;
        IList<AccordionControlElement> accordionControlElements;
        ICategoryService categoryService;
        IGameMenuService gameMenuService;
        int tasbindex = 0;
        //XtraUserControl employeesUserControl;
        //XtraUserControl customersUserControl;
        BarSubItem barSubItemNavigation;

        public ContainControlCategoryGame(IGameMenuService _gameMenuService)
        {
            this.gameMenuService = _gameMenuService;
            InitializeComponent();
            categoryService = new CategoryService();
            this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.Id = 15;
            this.barSubItemNavigation.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.employeesBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.customersBarButtonItem)});
            this.barSubItemNavigation.Name = "barSubItemNavigation";
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] { this.ribbonControl.ExpandCollapseItem, this.skinRibbonGalleryBarItem, this.barSubItemNavigation });
            SetAccordionControlElements();
            //employeesUserControl = CreateUserControl("Employees");
            //customersUserControl = CreateUserControl("Customers");
            //accordionControl.SelectedElement = employeesAccordionControlElement;
        }

        void SetAccordionControlElements()
        {
            if (this.accordionControlElements != null)
            {
                this.accordionControlElements.Clear();
            }
            this.accordionControlElements = new List<AccordionControlElement>();
            ICategoryService categoryService = new CategoryService();
            IList<Logic.Models.CategoryGame> categoryGames = categoryService.GetCategoryGamesOnLocal();

            if (categoryGames == null)
            {
                categoryGames = new List<Logic.Models.CategoryGame>();
            }

            if (categoryGames.Count() == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Danh sách Category đang rỗng bạn có muốn reset lại mặc định không?", "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int k = 0;
                    categoryGames.Add(new Logic.Models.CategoryGame() { Id = k++, CategoryName = "All Games" });
                    categoryGames.Add(new Logic.Models.CategoryGame() { Id = k++, CategoryName = "Application" });
                    categoryGames.Add(new Logic.Models.CategoryGame() { Id = k++, CategoryName = "Office Applicaltion" });
                    categoryGames.Add(new Logic.Models.CategoryGame() { Id = k++, CategoryName = "Online Games" });
                    categoryGames.Add(new Logic.Models.CategoryGame() { Id = k++, CategoryName = "Offline Games" });
                    categoryGames.Add(new Logic.Models.CategoryGame() { Id = k++, CategoryName = "Mini Games" });
                    categoryService.SaveCategorysGameAndSync(categoryGames);
                }
            }

            foreach (var item in categoryGames)
            {
                var categoryAccordionControlElement = new AccordionControlElement()
                {
                    Text = item.CategoryName,
                    Style = DevExpress.XtraBars.Navigation.ElementStyle.Item,
                    Name = String.Format("{0}AccordionControlElement", item.Id)
                };
                this.mainAccordionGroup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { categoryAccordionControlElement });
                this.accordionControlElements.Add(categoryAccordionControlElement);
            }
            if (this.accordionControlElements != null)
            {
                if (this.accordionControlElements.Count() > 0)
                    accordionControl.SelectedElement = this.accordionControlElements[0];
            }
        }

        void SetUserControl()
        {
            if (this.accordionControlElements != null)
            {
                this.xtraUserControls = new List<XtraUserControl>();
                foreach (var item in this.accordionControlElements)
                {
                    this.xtraUserControls.Add(CreateUserControl(item.Text));
                }
            }
        }

        XtraUserControl CreateUserControl(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text == null ? "UserControl" : text.ToLower() + "UserControl";
            result.Text = text == null ? "" : text;
            var gameitems = gameMenuService.JLoadGameItemFromDataJson();
            return SetGames(text, gameitems, result);
        }

        XtraUserControl CreateUserControl(string text, IList<Logic.Models.GameItem> gameitems)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text == null ? "UserControl" : text.ToLower() + "UserControl";
            result.Text = text == null ? "" : text;
            return SetGames(text, gameitems, result);
        }

        XtraUserControl SetGames(string text,IList<Logic.Models.GameItem> gameitems, XtraUserControl xtraUserControl)
        {
            XtraUserControl result = xtraUserControl;
            Point point = new Point(5, 5);
            Size size = new Size(80, 84);
            int index = 1;
            int line = 1;
            //int itemPerline = (int)(result.Width / (size.Width + 5));
            int itemPerline = 4;
            if (gameitems != null)
            {
                if (gameitems.Count() > 0)
                {
                    foreach (var item in gameitems)
                    {
                        if (item.CategoryGames != null)
                        {
                            foreach (var cate in item.CategoryGames)
                            {
                                if (cate.CategoryName == text)
                                {
                                    point.X = 5 * index + size.Width * (index - 1);
                                    point.Y = 5 * index + size.Height * (line - 1);
                                    var buttont = GetBunifuTileButton(point, size, item.NameGame, item.IconUrL);
                                    buttont.Parent = result;
                                    buttont.Show();

                                    if (index == itemPerline)
                                    {
                                        line++;
                                        index = 1;
                                    }
                                    index++;
                                    break;
                                }
                            }
                        }
                        else if (text == "All Games")
                        {
                            point.X = 5 * index + size.Width * (index - 1);
                            point.Y = 5 * index + size.Height * (line - 1);
                            var buttont = GetBunifuTileButton(point, size, item.NameGame, item.IconUrL);
                            buttont.Parent = result;
                            buttont.Show();

                            if (index == itemPerline)
                            {
                                line++;
                                index = 1;
                            }
                            index++;
                        }
                        else if(text == searchName)
                        {
                            point.X = 5 * index + size.Width * (index - 1);
                            point.Y = 5 * index + size.Height * (line - 1);
                            var buttont = GetBunifuTileButton(point, size, item.NameGame, item.IconUrL);
                            buttont.Parent = result;
                            buttont.Show();

                            if (index == itemPerline)
                            {
                                line++;
                                index = 1;
                            }
                            index++;
                        }
                    }
                }
                else
                {
                    LabelControl label = GetLabel(text);
                    label.Parent = result;
                }
            }
            else
            {
                LabelControl label = GetLabel(text);
                label.Parent = result;
            }
            return result;
        }

        private LabelControl GetLabel(string text)
        {
            LabelControl label = new LabelControl();
            label.Appearance.Font = new Font("Tahoma", 25.25F);
            label.Appearance.ForeColor = Color.Gray;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            label.AutoSizeMode = LabelAutoSizeMode.None;
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            label.Text = text;
            return label;
        }

        private BunifuTileButton GetBunifuTileButton(Point point, Size size, string namegame, string urlicon)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaster));
            BunifuTileButton bunifuTileButton = new BunifuTileButton();
            bunifuTileButton.BackColor = System.Drawing.Color.Transparent;
            try
            {
                bunifuTileButton.BackgroundImage = Image.FromFile(urlicon);
            }
            catch
            {
                bunifuTileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.BackgroundImage")));
            }
            bunifuTileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bunifuTileButton.color = System.Drawing.Color.Transparent;
            bunifuTileButton.colorActive = System.Drawing.Color.Transparent;
            bunifuTileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            bunifuTileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            bunifuTileButton.ForeColor = System.Drawing.Color.Lime;
            bunifuTileButton.Image = null;
            bunifuTileButton.ImagePosition = 13;
            bunifuTileButton.ImageZoom = 50;
            bunifuTileButton.LabelPosition = 26;
            bunifuTileButton.LabelText = namegame;
            bunifuTileButton.Location = point;
            bunifuTileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            bunifuTileButton.Name = "bunifuTileButton" + point.X + point.Y;
            if (size != null)
                bunifuTileButton.Size = size;
            else
                bunifuTileButton.Size = new System.Drawing.Size(80, 84);
            bunifuTileButton.TabIndex = tasbindex;
            bunifuTileButton.MouseEnter += new System.EventHandler(this.bunifuTileButton_MouseEnter);
            bunifuTileButton.MouseLeave += new System.EventHandler(this.bunifuTileButton_MouseLeave);
            return bunifuTileButton;
        }

        private void bunifuTileButton_MouseLeave(object sender, EventArgs e)
        {
            BunifuTileButton bunifuTileButton = (BunifuTileButton)sender;
            bunifuTileButton.Image = null;
            bunifuTileButton.BorderStyle = BorderStyle.None;
        }

        private void bunifuTileButton_MouseEnter(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaster));
            BunifuTileButton bunifuTileButton = (BunifuTileButton)sender;
            bunifuTileButton.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            bunifuTileButton.BorderStyle = BorderStyle.FixedSingle;
        }

        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {
            if (this.xtraUserControls == null)
            {
                SetUserControl();
            }
            else if (this.xtraUserControls.Count() == 0)
            {
                SetUserControl();
            }
            if (e.Element == null) return;
            XtraUserControl userControl = new XtraUserControl();
            foreach (var item in this.accordionControlElements)
            {
                if (e.Element.Text == item.Text)
                {
                    userControl = this.xtraUserControls.FirstOrDefault(m => m.Text == item.Text);
                    break;
                }
            }
            tabbedView.AddDocument(userControl);
            tabbedView.ActivateDocument(userControl);
            if (accordionControl.SelectedElement != null)
            {
                this.barButtonItemDeleteCategory.Enabled = true;
            }
            else
            {
                this.barButtonItemDeleteCategory.Enabled = false;
            }
        }

        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
        }

        void tabbedView_DocumentClosed(object sender, DocumentEventArgs e)
        {
            RecreateUserControls(e);
            SetAccordionSelectedElement(e);
            this.xtraUserControls.Clear();
            if (accordionControl.SelectedElement != null)
            {
                this.barButtonItemDeleteCategory.Enabled = true;
            }
            else
            {
                this.barButtonItemDeleteCategory.Enabled = false;
            }
        }

        void SetAccordionSelectedElement(DocumentEventArgs e)
        {
            if (tabbedView.Documents.Count != 0)
            {
                foreach (var item in this.accordionControlElements)
                {
                    if (e.Document.Caption == item.Text)
                    {
                        accordionControl.SelectedElement = this.accordionControlElements.FirstOrDefault(m => m.Text == item.Text);
                        break;
                    }
                }
            }
            else
            {
                accordionControl.SelectedElement = null;
            }
        }

        void RecreateUserControls(DocumentEventArgs e)
        {
            foreach (var item in this.accordionControlElements)
            {
                if (e.Document.Caption == item.Text)
                {
                    var xtra = this.xtraUserControls.FirstOrDefault(m => m.Text == item.Text);
                    if (xtra == null)
                    {
                        xtra = CreateUserControl(item.Text);
                    }
                    break;
                }
            }
        }

        private void barButtonItemDeleteCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.accordionControl.SelectedElement.Text.Count() > 0)
            {
                categoryService.DeleteCategory(new Logic.Models.CategoryGame() { CategoryName = this.accordionControl.SelectedElement.Text });
                this.accordionControlElements.Clear();
                this.xtraUserControls.Clear();
                this.mainAccordionGroup.Elements.Clear();
                SetAccordionControlElements();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void barButtonItemAddCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddCategory addCategory = new AddCategory();
            addCategory.Show();
        }


        private string searchName = "Kết quả tìm kiếm";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Logic.Models.GameItem> games = gameMenuService.JLoadGameItemFromDataJson().Where(m=>m.NameGame.Contains(txtSearch.Text.ToUpper())).ToList();
            var userControl = this.xtraUserControls.FirstOrDefault(m => m.Text == searchName);
            if (userControl != null)
            {
                userControl.Dispose();
                userControl = CreateUserControl(searchName, games);                
            }
            else
            {
                userControl = CreateUserControl(searchName, games);
                this.xtraUserControls.Add(userControl);
            }            
            tabbedView.AddDocument(userControl);
            tabbedView.ActivateDocument(userControl);
        }
    }
}
