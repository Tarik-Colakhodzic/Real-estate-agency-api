﻿using RealEstateAgency.WinUI.BookOfComplaints;
using RealEstateAgency.WinUI.Contract;
using RealEstateAgency.WinUI.Owner;
using RealEstateAgency.WinUI.Payments;
using RealEstateAgency.WinUI.Property;
using RealEstateAgency.WinUI.User;
using RealEstateAgency.WinUI.Visit;
using System;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI
{
    public partial class frmHome : Form
    {
        private int childFormNumber = 0;

        public frmHome()
        {
            InitializeComponent();
            if (!APIService.Administrator)
            {
                usersToolStripMenuItem.Visible = false;
                uplateToolStripMenuItem.Visible = false;
            }
            if (!APIService.Agent)
            {
                posjeteToolStripMenuItem.Visible = false;
                dodavanjeNekrenineToolStripMenuItem.Visible = false;
                doddavanjeUgovoraToolStripMenuItem.Visible = false;
            }
            if(!APIService.Agent && !APIService.Administrator)
            {
                vlasniciToolStripMenuItem.Visible = nekretnineToolStripMenuItem.Visible
                    = ugovoriToolStripMenuItem.Visible = knjigaŽalbiToolStripMenuItem.Visible = false;
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void displayUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayUsers frm = new frmDisplayUsers();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersDetails frm = new frmUsersDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void displayOwnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayOwners frm = new frmDisplayOwners();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void addOwnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOwnerDetails frm = new frmOwnerDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledNekretninaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayProperty frm = new frmDisplayProperty();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void dodavanjeNekrenineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPropertyDetails frm = new frmPropertyDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayContracts frm = new frmDisplayContracts();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void doddavanjeUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContractDetails frm = new frmContractDetails();
            frm.MdiParent = this;
            frm.Show();
        }

        private void knjigaŽalbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisplayBooksOfComplaints frm = new frmDisplayBooksOfComplaints();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void posjeteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisitsDisplay frm = new frmVisitsDisplay();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void uplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayments frm = new frmPayments();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}