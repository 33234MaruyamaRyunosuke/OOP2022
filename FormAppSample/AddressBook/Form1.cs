﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook {
    public partial class Form1 : Form {

        //住所データ管理用リスト
        BindingList<Person> listPerson = new BindingList<Person>();

        public Form1() {
            InitializeComponent();
            dgvPersons.DataSource = listPerson;
        }

        private void btPictrureOpen_Click(object sender, EventArgs e) {
            if(ofdFileOpenDialog.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdFileOpenDialog.FileName);
            }
            
        }

        private void btAddPerson_Click(object sender, EventArgs e) {

            if(string.IsNullOrEmpty(tbname.Text)) {
                MessageBox.Show("氏名が入力されていません");
                return;
            }

            Person newPerson = new Person {
                Name = tbname.Text,
                MailAddress = tbMailAddress.Text,
                Address = tbAddress.Text,
                Company = cbCompany.Text,
                Picture = pbPicture.Image,
                listGroup = GetCheckBoxGroup(),
            };

            listPerson.Add(newPerson);
            dgvPersons.Rows[dgvPersons.RowCount - 1].Selected = true;

            if(listPerson.Count() > 0) {
                btDelete.Enabled = true;
                btUpdate.Enabled = true;
            }

            if (cbCompany.Items.Contains(cbCompany.Text)) {
                cbCompany.Items.Add(cbCompany.Text);
            }

        }

        private List<Person.GroupType> GetCheckBoxGroup() {
            var listGroup = new List<Person.GroupType>();
            if (cbFamily.Checked) {
                listGroup.Add(Person.GroupType.家族);
            }
            if (cbFriend.Checked) {
                listGroup.Add(Person.GroupType.友人);
            }
            if (cbWork.Checked) {
                listGroup.Add(Person.GroupType.仕事);
            }
            if (cbOther.Checked) {
                listGroup.Add(Person.GroupType.その他);
            }
            return listGroup;
        }

        private void pbPicture_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void dgvPersons_Click(object sender, EventArgs e) {
            if (dgvPersons.CurrentRow == null) return;

            var index = dgvPersons.CurrentRow.Index;

            tbname.Text = listPerson[index].Name;
            tbMailAddress.Text = listPerson[index].MailAddress;
            tbAddress.Text = listPerson[index].Address;
            cbCompany.Text = listPerson[index].Company;
            pbPicture.Image = listPerson[index].Picture;

            groupCheckBoxAllClear();

            foreach(var group in listPerson[index].listGroup) {
                switch (group) {
                    case Person.GroupType.家族:
                        cbFamily.Checked = true;
                        break;
                    case Person.GroupType.友人:
                        cbFriend.Checked = true;
                        break;
                    case Person.GroupType.仕事:
                        cbWork.Checked = true;
                        break;
                    case Person.GroupType.その他:
                        cbOther.Checked = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void groupCheckBoxAllClear() {
            cbFamily.Checked = cbFriend.Checked = cbWork.Checked = cbOther.Checked = false;
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            listPerson[dgvPersons.CurrentRow.Index].Name = tbname.Text;
            listPerson[dgvPersons.CurrentRow.Index].MailAddress = tbMailAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Address = tbAddress.Text;
            listPerson[dgvPersons.CurrentRow.Index].Company = cbCompany.Text;
            listPerson[dgvPersons.CurrentRow.Index].listGroup = GetCheckBoxGroup();
            listPerson[dgvPersons.CurrentRow.Index].Picture = pbPicture.Image;
            dgvPersons.Refresh();
        }

        private void btDelete_Click(object sender, EventArgs e) {
            listPerson.RemoveAt(dgvPersons.CurrentRow.Index);
            dgvPersons.Rows[dgvPersons.RowCount - 1].Selected = true;

            if(listPerson.Count() == 0) {
                btDelete.Enabled = false;
                btUpdate.Enabled = false;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            //btDelete.Enabled = false;
            //btUpdate.Enabled = false;
            //btPictureClear.Enabled = false;
            
        }
    }
}
