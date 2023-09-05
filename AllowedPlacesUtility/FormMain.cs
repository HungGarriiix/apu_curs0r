using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace APU
{
    public partial class FormMain : Form
    {
        CarFilter filter;

        public FormMain()
        {
            InitializeComponent();
        }

        // might binding two-way controls later
        /*public void BindingComponent()
        {
            cmbNameFilter.DataBindings.Add()
        }*/

        private void SaveCar(Car c)
        {
            if (File.Exists(c.Path))
            {
                string[] lines = File.ReadAllLines(c.Path);
                int i = 0;
                foreach (var line in lines)
                {
                    if (line.ToLower().StartsWith("uniquemod"))
                    {
                        lines[i] = line.Substring(0, line.IndexOf("=") + 1);
                        lines[i] += c.UniqueMod.ToString();
                    }
                    if (line.ToLower().StartsWith("allowedplaces"))
                    {
                        lines[i] = line
                            .Replace("Junkyard", "")
                            .Replace("Auction", "")
                            .Replace("Shed", "")
                            .Replace("Salon", "")
                            .Replace("junkyard", "")
                            .Replace("auction", "")
                            .Replace("shed", "")
                            .Replace("salon", "")
                            .Replace(",", "");
                        if (c.Junkyard)
                        {
                            lines[i] += ",Junkyard";
                        }
                        if (c.Auction)
                        {
                            lines[i] += ",Auction";
                        }
                        if (c.Salon)
                        {
                            lines[i] += ",Salon";
                        }
                        if (c.Shed)
                        {
                            lines[i] += ",Shed";
                        }
                    }
                    i++;
                }
                File.WriteAllLines(c.Path, lines);
            }
            else
            {
                MessageBox.Show("Unable to save " + c.Path);
            }
        }

        private void FoundCar(string file,string name, string carpath, CarFilter filter)
        {
            Car c = new Car();
            c.Path = file;
            string[] cfg = File.ReadAllLines(file);
            foreach (var line in cfg)
            {
                if (line.ToLower().StartsWith("carversionname"))
                {
                    c.Name = name + " " + line.Substring(line.IndexOf('=') + 1);
                    if (!c.Name.ToLower().Contains(filter.NameFilter.ToLower()))
                        return;
                }
                if (line.ToLower().StartsWith("uniquemod"))
                {
                    decimal um = 0;
                    decimal.TryParse(line.Substring(line.IndexOf('=') + 1), out um);
                    if (um != 0)
                    {
                        c.UniqueMod = um;
                    }
                }
                if (line.ToLower().StartsWith("allowedplaces"))
                {
                    string[] places = line.Substring(line.IndexOf('=') + 1).Split(',');
                    foreach (var place in places)
                    {
                        switch (place.ToLower())
                        {
                            case "shed":
                                c.Shed = true;
                                break;
                            case "junkyard":
                                c.Junkyard = true;
                                break;
                            case "auction":
                                c.Auction = true;
                                break;
                            case "salon":
                                c.Salon = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            ListViewItem lvi = new ListViewItem();
            lvi.Text = c.Name;
            lvi.Tag = c;

            lvwCars.Items.Add(lvi);
        }

        private void FoundCars(string main_dir, CarFilter filter)
        {
            foreach (var carpath in Directory.EnumerateDirectories(main_dir))
            {
                string cp = carpath + "\\";
                string name = "Unnamed Car";
                if (File.Exists(cp + "name.txt"))
                {
                    name = File.ReadAllText(cp + "name.txt");
                }
                foreach (var file in Directory.EnumerateFiles(cp, "config*.txt"))
                {
                    FoundCar(file, name, carpath, filter);
                }
            }
        }

        private CarFilter LoadDefaultFilterConfig()
        {
            return new CarFilter()
            {
                SortMode = FileTypeSortMode.All,
                NameSortOrder = SortOrder.Ascending,
                NameFilter = String.Empty,
            };
        }

        private void LoadCars(CarFilter filter)
        {
            lvwCars.Items.Clear();
            if (filter.SortMode == FileTypeSortMode.Vanilla || filter.SortMode == FileTypeSortMode.All)
            {
                FoundCars(Properties.Settings.Default.GamePath + @"\Car Mechanic Simulator 2021_Data\StreamingAssets\Cars\", filter);
            }
            if ((filter.SortMode == FileTypeSortMode.Mod || filter.SortMode == FileTypeSortMode.All) && Directory.Exists(Properties.Settings.Default.ShopPath))
            {
                FoundCars(Properties.Settings.Default.ShopPath, filter);
            }  
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            filter = LoadDefaultFilterConfig();
            // assigning default values for controls
            tbxNameFilter.Text = filter.NameFilter;
            cmbNameFilter.DataSource = Enum.GetValues(typeof(SortOrder));
            // for some reason, this does not work at all
/*            SortOrder so = filter.NameSortOrder;
            cmbNameFilter.SelectedIndex = (int)so;*/
            cmbNameFilter.SelectedItem = SortOrder.Ascending;
            rbFTFAll.Checked = true;
        }

        private void lvwCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView view = (sender as ListView);
            if (view.SelectedIndices.Count > 0)
            {
                Car c = (view.Items[view.SelectedIndices[0]].Tag as Car);
                nudUnique.Value = c.UniqueMod;
                chkAuction.Checked = c.Auction;
                chkJunk.Checked = c.Junkyard;
                chkSalon.Checked = c.Salon;
                chkShed.Checked = c.Shed;
                //pbxCarImage.Image = c.Image;
                lblCarName.Text = c.Name;
            }
        }

        private void chkAuction_CheckedChanged(object sender, EventArgs e)
        {
            if (lvwCars.SelectedItems.Count > 0)
            {
                Car c = (lvwCars.SelectedItems[0].Tag as Car);
                c.Auction = (sender as CheckBox).Checked;
                SaveCar(c);
            }
        }

        private void chkSalon_CheckedChanged(object sender, EventArgs e)
        {
            if (lvwCars.SelectedItems.Count > 0)
            {
                Car c = (lvwCars.SelectedItems[0].Tag as Car);
                c.Salon = (sender as CheckBox).Checked;
                SaveCar(c);
            }
        }

        private void chkJunk_CheckedChanged(object sender, EventArgs e)
        {
            if (lvwCars.SelectedItems.Count > 0)
            {
                Car c = (lvwCars.SelectedItems[0].Tag as Car);
                c.Junkyard = (sender as CheckBox).Checked;
                SaveCar(c);
            }
        }

        private void chkShed_CheckedChanged(object sender, EventArgs e)
        {
            if (lvwCars.SelectedItems.Count > 0)
            {
                Car c = (lvwCars.SelectedItems[0].Tag as Car);
                c.Shed = (sender as CheckBox).Checked;
                SaveCar(c);
            }
        }

        private void tsbSalonAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lvwCars.Items)
            {
                Car c = (item as ListViewItem).Tag as Car;
                c.Salon = true;
                SaveCar(c);
                chkSalon.Checked = true;
            }
        }

        private void tsbSalonNone_Click(object sender, EventArgs e)
        {
            foreach (var item in lvwCars.Items)
            {
                Car c = (item as ListViewItem).Tag as Car;
                c.Salon = false;
                SaveCar(c);
                chkSalon.Checked = false;
            }
        }

        private void tsbAuctionAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lvwCars.Items)
            {
                Car c = (item as ListViewItem).Tag as Car;
                c.Auction = true;
                SaveCar(c);
                chkAuction.Checked = true;
            }
        }

        private void tsbAuctionNone_Click(object sender, EventArgs e)
        {
            foreach (var item in lvwCars.Items)
            {
                Car c = (item as ListViewItem).Tag as Car;
                c.Auction = false;
                SaveCar(c);
                chkAuction.Checked = false;
            }
        }

        private void tsbJunkyardAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lvwCars.Items)
            {
                Car c = (item as ListViewItem).Tag as Car;
                c.Junkyard = true;
                SaveCar(c);
                chkJunk.Checked = true;
            }
        }

        private void tsbJunkyardNone_Click(object sender, EventArgs e)
        {
            foreach (var item in lvwCars.Items)
            {
                Car c = (item as ListViewItem).Tag as Car;
                c.Junkyard = false;
                SaveCar(c);
                chkJunk.Checked = false;
            }
        }

        private void tsbBarnsAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lvwCars.Items)
            {
                Car c = (item as ListViewItem).Tag as Car;
                c.Shed = true;
                SaveCar(c);
                chkShed.Checked = true;
            }
        }

        private void tsbBarnsNone_Click(object sender, EventArgs e)
        {
            foreach (var item in lvwCars.Items)
            {
                Car c = (item as ListViewItem).Tag as Car;
                c.Shed = false;
                SaveCar(c);
                chkShed.Checked = false;
            }
        }

        private void nudUnique_ValueChanged(object sender, EventArgs e)
        {
            if (lvwCars.SelectedItems.Count > 0)
            {
                Car c = (lvwCars.SelectedItems[0].Tag as Car);
                c.UniqueMod = (sender as NumericUpDown).Value;
                SaveCar(c);
            }
        }

        private void cmbNameFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter.NameSortOrder = (SortOrder)cmbNameFilter.SelectedItem;
            lvwCars.Sorting = filter.NameSortOrder;
            LoadCars(filter);
        }

        private void tbxNameFilter_TextChanged(object sender, EventArgs e)
        {
            filter.NameFilter = (sender as TextBox).Text;
            LoadCars(filter);
        }

        private void rbFTFAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFTFAll.Checked)
                filter.SortMode = FileTypeSortMode.All;
            LoadCars(filter);
        }

        private void rbFTFVanilla_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFTFVanilla.Checked)
                filter.SortMode = FileTypeSortMode.Vanilla;
            LoadCars(filter);
        }

        private void rbFTFMod_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFTFMod.Checked)
                filter.SortMode = FileTypeSortMode.Mod;
            LoadCars(filter);
        }
    }
}
