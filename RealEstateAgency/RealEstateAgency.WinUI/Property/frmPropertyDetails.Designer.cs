﻿
namespace RealEstateAgency.WinUI.Property
{
    partial class frmPropertyDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSquareMeters = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbWaterConnection = new System.Windows.Forms.CheckBox();
            this.chbElectricityConnection = new System.Windows.Forms.CheckBox();
            this.chbFinished = new System.Windows.Forms.CheckBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbOfferType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.txtBalconySquareMeters = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chbInternet = new System.Windows.Forms.CheckBox();
            this.pbPhotos = new System.Windows.Forms.PictureBox();
            this.btnAddPhotos = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNumberOfBedRooms = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNumberOfBathRoom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.ofdImageUpload = new System.Windows.Forms.OpenFileDialog();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbPaid = new System.Windows.Forms.CheckBox();
            this.txtChargeId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(16, 34);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(172, 22);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(503, 45);
            this.txtShortDescription.Multiline = true;
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(387, 56);
            this.txtShortDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kratak opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opis";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(503, 134);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(387, 87);
            this.txtDescription.TabIndex = 5;
            // 
            // txtSquareMeters
            // 
            this.txtSquareMeters.Location = new System.Drawing.Point(16, 176);
            this.txtSquareMeters.Name = "txtSquareMeters";
            this.txtSquareMeters.Size = new System.Drawing.Size(172, 22);
            this.txtSquareMeters.TabIndex = 7;
            this.txtSquareMeters.Validating += new System.ComponentModel.CancelEventHandler(this.txtSquareMeters_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Broj kvadrata";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(16, 105);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(172, 22);
            this.txtAddress.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adresa";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(16, 246);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(172, 22);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cijena";
            // 
            // chbWaterConnection
            // 
            this.chbWaterConnection.AutoSize = true;
            this.chbWaterConnection.Location = new System.Drawing.Point(16, 339);
            this.chbWaterConnection.Name = "chbWaterConnection";
            this.chbWaterConnection.Size = new System.Drawing.Size(144, 21);
            this.chbWaterConnection.TabIndex = 12;
            this.chbWaterConnection.Text = "Priključak za vodu";
            this.chbWaterConnection.UseVisualStyleBackColor = true;
            // 
            // chbElectricityConnection
            // 
            this.chbElectricityConnection.AutoSize = true;
            this.chbElectricityConnection.Location = new System.Drawing.Point(16, 395);
            this.chbElectricityConnection.Name = "chbElectricityConnection";
            this.chbElectricityConnection.Size = new System.Drawing.Size(148, 21);
            this.chbElectricityConnection.TabIndex = 13;
            this.chbElectricityConnection.Text = "Priključak za struju";
            this.chbElectricityConnection.UseVisualStyleBackColor = true;
            // 
            // chbFinished
            // 
            this.chbFinished.AutoSize = true;
            this.chbFinished.Location = new System.Drawing.Point(754, 341);
            this.chbFinished.Name = "chbFinished";
            this.chbFinished.Size = new System.Drawing.Size(136, 21);
            this.chbFinished.TabIndex = 14;
            this.chbFinished.Text = "Završena objava";
            this.chbFinished.UseVisualStyleBackColor = true;
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(257, 34);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(199, 24);
            this.cmbCity.TabIndex = 15;
            this.cmbCity.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCity_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Grad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Kategorija";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(257, 105);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(199, 24);
            this.cmbCategory.TabIndex = 17;
            this.cmbCategory.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCategory_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Vrsta oglasa";
            // 
            // cmbOfferType
            // 
            this.cmbOfferType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOfferType.FormattingEnabled = true;
            this.cmbOfferType.Location = new System.Drawing.Point(257, 176);
            this.cmbOfferType.Name = "cmbOfferType";
            this.cmbOfferType.Size = new System.Drawing.Size(199, 24);
            this.cmbOfferType.TabIndex = 19;
            this.cmbOfferType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbOfferType_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Vlasnik";
            // 
            // cmbOwner
            // 
            this.cmbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(257, 246);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(199, 24);
            this.cmbOwner.TabIndex = 21;
            this.cmbOwner.Validating += new System.ComponentModel.CancelEventHandler(this.cmbOwner_Validating);
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(363, 276);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(93, 30);
            this.btnAddOwner.TabIndex = 23;
            this.btnAddOwner.Text = "Novi vlasnik";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // txtBalconySquareMeters
            // 
            this.txtBalconySquareMeters.Location = new System.Drawing.Point(257, 339);
            this.txtBalconySquareMeters.Name = "txtBalconySquareMeters";
            this.txtBalconySquareMeters.Size = new System.Drawing.Size(172, 22);
            this.txtBalconySquareMeters.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Broj kvadrata balkona";
            // 
            // chbInternet
            // 
            this.chbInternet.AutoSize = true;
            this.chbInternet.Location = new System.Drawing.Point(503, 395);
            this.chbInternet.Name = "chbInternet";
            this.chbInternet.Size = new System.Drawing.Size(78, 21);
            this.chbInternet.TabIndex = 26;
            this.chbInternet.Text = "Internet";
            this.chbInternet.UseVisualStyleBackColor = true;
            // 
            // pbPhotos
            // 
            this.pbPhotos.Location = new System.Drawing.Point(943, 24);
            this.pbPhotos.Name = "pbPhotos";
            this.pbPhotos.Size = new System.Drawing.Size(256, 256);
            this.pbPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhotos.TabIndex = 27;
            this.pbPhotos.TabStop = false;
            // 
            // btnAddPhotos
            // 
            this.btnAddPhotos.Location = new System.Drawing.Point(943, 318);
            this.btnAddPhotos.Name = "btnAddPhotos";
            this.btnAddPhotos.Size = new System.Drawing.Size(256, 30);
            this.btnAddPhotos.TabIndex = 28;
            this.btnAddPhotos.Text = "Dodaj slike";
            this.btnAddPhotos.UseVisualStyleBackColor = true;
            this.btnAddPhotos.Click += new System.EventHandler(this.btnAddPhotos_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1067, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 35);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNumberOfBedRooms
            // 
            this.txtNumberOfBedRooms.Location = new System.Drawing.Point(257, 395);
            this.txtNumberOfBedRooms.Name = "txtNumberOfBedRooms";
            this.txtNumberOfBedRooms.Size = new System.Drawing.Size(172, 22);
            this.txtNumberOfBedRooms.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Broj soba";
            // 
            // txtNumberOfBathRoom
            // 
            this.txtNumberOfBathRoom.Location = new System.Drawing.Point(503, 339);
            this.txtNumberOfBathRoom.Name = "txtNumberOfBathRoom";
            this.txtNumberOfBathRoom.Size = new System.Drawing.Size(172, 22);
            this.txtNumberOfBathRoom.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(500, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Broj kupatila";
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imgList.ImageSize = new System.Drawing.Size(256, 256);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ofdImageUpload
            // 
            this.ofdImageUpload.FileName = "ofdImageUpload";
            this.ofdImageUpload.Multiselect = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(943, 282);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(130, 30);
            this.btnPrevious.TabIndex = 34;
            this.btnPrevious.Text = "Prethodna";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1075, 282);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 30);
            this.btnNext.TabIndex = 35;
            this.btnNext.Text = "Sljedeća";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbPaid
            // 
            this.cbPaid.AutoSize = true;
            this.cbPaid.Enabled = false;
            this.cbPaid.Location = new System.Drawing.Point(809, 250);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(81, 21);
            this.cbPaid.TabIndex = 36;
            this.cbPaid.Text = "Plaćeno";
            this.cbPaid.UseVisualStyleBackColor = true;
            // 
            // txtChargeId
            // 
            this.txtChargeId.Location = new System.Drawing.Point(503, 248);
            this.txtChargeId.Name = "txtChargeId";
            this.txtChargeId.ReadOnly = true;
            this.txtChargeId.Size = new System.Drawing.Size(300, 22);
            this.txtChargeId.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(500, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Id transakcije";
            // 
            // frmPropertyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 451);
            this.Controls.Add(this.txtChargeId);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbPaid);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtNumberOfBathRoom);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNumberOfBedRooms);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddPhotos);
            this.Controls.Add(this.pbPhotos);
            this.Controls.Add(this.chbInternet);
            this.Controls.Add(this.txtBalconySquareMeters);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddOwner);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbOwner);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbOfferType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.chbFinished);
            this.Controls.Add(this.chbElectricityConnection);
            this.Controls.Add(this.chbWaterConnection);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSquareMeters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShortDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "frmPropertyDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podaci o nekretnini";
            this.Load += new System.EventHandler(this.frmPropertyDetails_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSquareMeters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbWaterConnection;
        private System.Windows.Forms.CheckBox chbElectricityConnection;
        private System.Windows.Forms.CheckBox chbFinished;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbOfferType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.TextBox txtBalconySquareMeters;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chbInternet;
        private System.Windows.Forms.PictureBox pbPhotos;
        private System.Windows.Forms.Button btnAddPhotos;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNumberOfBedRooms;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNumberOfBathRoom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.OpenFileDialog ofdImageUpload;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox cbPaid;
        private System.Windows.Forms.TextBox txtChargeId;
        private System.Windows.Forms.Label label14;
    }
}