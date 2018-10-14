﻿/*
 * Objective    - Creating a master detail almost without code
 * CreationDate - 2018/10/14 - Gildasio Cardoso 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMasterDetail
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataModel.SUBGROUP_PRODUCT' table. You can move, or remove it, as needed.
            this.sUBGROUP_PRODUCTTableAdapter.Fill(this.dataModel.SUBGROUP_PRODUCT);
            // TODO: This line of code loads data into the 'dataModel.GROUP_PRODUCT' table. You can move, or remove it, as needed.
            this.gROUP_PRODUCTTableAdapter.Fill(this.dataModel.GROUP_PRODUCT);
        }

        /// <summary>
        /// Save the items updated or inserted, autogenerated by visual studio except enable gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gROUP_PRODUCTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.gROUP_PRODUCTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataModel);
            sUBGROUP_PRODUCTDataGridView.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            sUBGROUP_PRODUCTDataGridView.Enabled = false;
        }


        /// <summary>
        /// Treating the event to delete details before the master
        /// remember to change de property gROUP_PRODUCTBindingSource.DeleteItem to "None"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gROUP_PRODUCTBindingNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // deleting detail before apply
            if (e.ClickedItem == bindingNavigatorDeleteItem)
            {
                DialogResult dr = MessageBox.Show( "Are you sure?", "Delete confirmation",  MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    this.Validate();
                    this.gROUP_PRODUCTBindingSource.EndEdit();

                    // to remove each record on detail before to remove master
                    while (sUBGROUP_PRODUCTBindingSource.Count > 0)
                    {
                        sUBGROUP_PRODUCTBindingSource.RemoveCurrent();
                    }
                    // removing master
                    gROUP_PRODUCTBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.dataModel);
                    sUBGROUP_PRODUCTDataGridView.Enabled = true;
                    MessageBox.Show("Record and details removed successfully.");
                }
            }
        }
    }
}
