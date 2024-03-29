﻿using RealEstateAgency.Model;
using RealEstateAgency.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateAgency.WinUI.User
{
    public partial class frmUsersDetails : Form
    {
        private readonly APIService _userService = new APIService(EntityNames.User);
        private readonly APIService _rolesService = new APIService(EntityNames.Role);
        private readonly APIService _agentService = new APIService(EntityNames.Agent);
        private bool _newAgent = false;
        private Model.User _user;
        private Model.Agent _agent;

        public frmUsersDetails(Model.User user = null)
        {
            InitializeComponent();
            _user = user;
            if (_user == null)
            {
                lblPwdFirst.Visible = false;
                lblPwdSecond.Visible = false;
            }
            dtpHireDate.CustomFormat = "MM/dd/yyyy";
            dtpHireDate.Format = DateTimePickerFormat.Custom;
        }

        private async void frmUsersDetails_Load(object sender, EventArgs e)
        {
            showAdminPanel(false);
            await LoadUloge();
            if (_user != null)
            {
                txtFirstName.Text = _user.FirstName;
                txtLastName.Text = _user.LastName;
                txtEmail.Text = _user.Email;
                txtPhoneNumber.Text = _user.PhoneNumber;
                txtUsername.Text = _user.Username;
            }
        }

        private async Task LoadUloge()
        {
            try
            {
                var roles = await _rolesService.GetAll<List<Model.Role>>();
                if (_user != null)
                {
                    foreach (var item in roles)
                    {
                        if (_user.UserRoles.Any(x => x.RoleId == item.Id))
                        {
                            clbRoles.Items.Add(item, true);
                        }
                        else
                        {
                            clbRoles.Items.Add(item, false);
                        }
                    }
                }
                else
                {
                    clbRoles.DataSource = roles;
                }
                clbRoles.DisplayMember = "Name";
                var agentRoleId = roles.First(x => x.Name == "Agent").Id;
                if (_user != null && _user.UserRoles.Any(x => x?.RoleId == agentRoleId))
                {
                    _agent = await _agentService.GetById<Model.Agent>(_user.Id);
                    if (_agent != null)
                    {
                        showAdminPanel(true);
                        dtpHireDate.Value = _agent.HireDate;
                        txtSalary.Text = Math.Round(_agent.Salary, 2).ToString();
                        if(_agent.Photo.Count() > 0)
                            pbAgentImage.Image = ImageHelper.FromByteToImage(_agent.Photo);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.Error_Occured);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                try
                {
                    var roleList = clbRoles.CheckedItems.Cast<Model.Role>();
                    var roleIds = roleList.Select(x => x.Id).ToList();

                    var request = new Model.Requests.UserInsertRequest();
                    request.Email = txtEmail.Text;
                    request.PhoneNumber = txtPhoneNumber.Text;
                    request.FirstName = txtFirstName.Text;
                    request.LastName = txtLastName.Text;
                    request.Username = txtUsername.Text;
                    request.Password = txtPassword.Text;
                    request.ConfirmedPassword = txtConfirmedPassword.Text;
                    request.Roles = roleIds;

                    if (_user == null)
                    {
                        var user = await _userService.Insert<Model.User>(request);
                        if (user == null)
                        {
                            MessageBox.Show("Korisnik sa istim korisničkim imenom već postoji, molimo da ga promijenite!");
                            return;
                        }
                        var selectedItems = clbRoles.CheckedItems;
                        _newAgent = false;
                        foreach (var item in selectedItems)
                        {
                            var role = item as Model.Role;
                            if (role != null)
                            {
                                if (role.Name == "Agent")
                                {
                                    _newAgent = true;
                                }
                            }
                        }
                        if (_newAgent)
                        {
                            var agent = new Model.Agent
                            {
                                Id = user.Id,
                                HireDate = dtpHireDate.Value
                            };
                            if (!string.IsNullOrEmpty(txtSalary.Text))
                                agent.Salary = decimal.Parse(txtSalary.Text);
                            if (pbAgentImage.Image != null)
                                agent.Photo = ImageHelper.FromImageToByte(pbAgentImage.Image);
                            await _agentService.Insert<Model.Agent>(agent);
                        }
                    }
                    else
                    {
                        await _userService.Update<Model.User>(_user.Id, request);
                        if (roleList.Any(x => x.Name == "Agent") && _newAgent && _agent == null)
                        {
                            var agent = new Model.Agent
                            {
                                Id = _user.Id,
                                HireDate = dtpHireDate.Value
                            };
                            if (!string.IsNullOrEmpty(txtSalary.Text))
                                agent.Salary = decimal.Parse(txtSalary.Text);
                            if (pbAgentImage.Image != null)
                                agent.Photo = ImageHelper.FromImageToByte(pbAgentImage.Image);
                            if(await _agentService.GetById<Model.Agent>(_user.Id) == null)
                                await _agentService.Insert<Model.Agent>(agent);
                        }
                    }
                    MessageBox.Show("Operacija uspješno izvršena");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show(Resources.Error_Occured);
                }
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateRequiredField(errorProvider, txtFirstName, e);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateRequiredField(errorProvider, txtLastName, e);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateEmail(errorProvider, txtEmail, e);
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidatePhoneNumber(errorProvider, txtPhoneNumber, e);
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateMinLength(errorProvider, txtUsername, 3, e);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) && _user != null)
            {
                errorProvider.SetError(txtPassword, null);
                return;
            }
            Regex rgx = new Regex(@"^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$");
            if (!rgx.IsMatch(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, Properties.Resources.Validation_PasswordStrength);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, null);
            }
        }

        private void txtConfirmedPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) && _user != null)
            {
                errorProvider.SetError(txtConfirmedPassword, null);
                return;
            }
            if (txtPassword.Text != txtConfirmedPassword.Text)
            {
                errorProvider.SetError(txtConfirmedPassword, Properties.Resources.Validation_NotEqualFields);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtConfirmedPassword, null);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdImageUpload.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = ofdImageUpload.FileName;
                    Image image = Image.FromFile(imagePath);
                    pbAgentImage.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Grška: {ex.Message}");
            }
        }

        private async void btnSaveAgent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Decimal.TryParse(txtSalary.Text, out decimal salary))
                {
                    MessageBox.Show("Plata nije isprava!");
                }
                _agent.Salary = salary;
                _agent.HireDate = dtpHireDate.Value;
                if(pbAgentImage.Image != null)
                    _agent.Photo = ImageHelper.FromImageToByte(pbAgentImage.Image);

                await _agentService.Update<Model.Agent>(_agent.Id, _agent);
                MessageBox.Show("Operacija uspješno izvršena");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                MessageBox.Show("Plata nije ispravna!");
                return;
            }
            if (!decimal.TryParse(txtIncreaseSalaryBy.Text, out decimal increaseBy))
            {
                MessageBox.Show("Postotak povećanja nije validan!");
                return;
            }
            if (increaseBy == 0)
            {
                return;
            }
            salary += Math.Round((increaseBy / 100) * salary, 2);
            txtSalary.Text = salary.ToString();
        }

        private void clbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItems = clbRoles.CheckedItems;
            _newAgent = false;
            foreach (var item in selectedItems)
            {
                var role = item as Model.Role;
                if (role != null)
                {
                    if (role.Name == "Agent")
                    {
                        _newAgent = true;
                    }
                }
            }
            if (_newAgent)
            {
                showAdminPanel(true);
            }
            else
            {
                showAdminPanel(false);
            }
        }

        private void showAdminPanel(bool show)
        {
            lblSalary.Visible = lblHireDate.Visible = txtSalary.Visible =
            dtpHireDate.Visible = btnSaveAgent.Visible = btnUploadImage.Visible =
            pbAgentImage.Visible = lblIncrease.Visible = txtIncreaseSalaryBy.Visible =
            btnIncrease.Visible = lblPercentage.Visible = lblKM.Visible = show;
            lblNoAgent.Visible = !show;
            if (_user == null || (_user != null && _agent == null))
            {
                btnSaveAgent.Visible = false;
                txtIncreaseSalaryBy.Visible = false;
                lblPercentage.Visible = false;
                btnIncrease.Visible = false;
                lblIncrease.Visible = false;
            }
        }

        private void dtpHireDate_ValueChanged(object sender, EventArgs e)
        {
            dtpHireDate.CustomFormat = "MM/dd/yyyy";
            dtpHireDate.Format = DateTimePickerFormat.Custom;
        }
    }
}