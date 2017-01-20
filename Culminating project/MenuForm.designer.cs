namespace FinalCulminating
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnEnterName = new System.Windows.Forms.Button();
            this.lblPromptEnvironment = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblStartTitle = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlStart = new System.Windows.Forms.Panel();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.picAskName = new System.Windows.Forms.PictureBox();
            this.btnJungle = new System.Windows.Forms.Button();
            this.btnPetStore = new System.Windows.Forms.Button();
            this.btnFarm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMenuTItle = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAskName)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(273, 187);
            this.txtUsername.MaxLength = 15;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(140, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // btnEnterName
            // 
            this.btnEnterName.Location = new System.Drawing.Point(303, 213);
            this.btnEnterName.Name = "btnEnterName";
            this.btnEnterName.Size = new System.Drawing.Size(75, 23);
            this.btnEnterName.TabIndex = 1;
            this.btnEnterName.Text = "Enter Name";
            this.btnEnterName.UseVisualStyleBackColor = true;
            this.btnEnterName.Click += new System.EventHandler(this.btnEnterName_Click);
            // 
            // lblPromptEnvironment
            // 
            this.lblPromptEnvironment.AutoSize = true;
            this.lblPromptEnvironment.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromptEnvironment.Location = new System.Drawing.Point(187, 295);
            this.lblPromptEnvironment.Name = "lblPromptEnvironment";
            this.lblPromptEnvironment.Size = new System.Drawing.Size(337, 29);
            this.lblPromptEnvironment.TabIndex = 6;
            this.lblPromptEnvironment.Text = "Choose an environment to play!";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(541, 29);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(117, 24);
            this.lblHighScore.TabIndex = 7;
            this.lblHighScore.Text = "Highscore: 0";
            // 
            // lblStartTitle
            // 
            this.lblStartTitle.AutoSize = true;
            this.lblStartTitle.BackColor = System.Drawing.Color.SkyBlue;
            this.lblStartTitle.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStartTitle.Location = new System.Drawing.Point(30, 81);
            this.lblStartTitle.Name = "lblStartTitle";
            this.lblStartTitle.Size = new System.Drawing.Size(376, 55);
            this.lblStartTitle.TabIndex = 8;
            this.lblStartTitle.Text = "Animal Mania!";
            this.lblStartTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(313, 253);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(53, 23);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "label1";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlMenu.Controls.Add(this.pnlStart);
            this.pnlMenu.Controls.Add(this.picAskName);
            this.pnlMenu.Controls.Add(this.btnJungle);
            this.pnlMenu.Controls.Add(this.btnPetStore);
            this.pnlMenu.Controls.Add(this.btnFarm);
            this.pnlMenu.Controls.Add(this.lblLogin);
            this.pnlMenu.Controls.Add(this.lblHighScore);
            this.pnlMenu.Controls.Add(this.lblPromptEnvironment);
            this.pnlMenu.Controls.Add(this.btnEnterName);
            this.pnlMenu.Controls.Add(this.txtUsername);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lblMenuTItle);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(693, 549);
            this.pnlMenu.TabIndex = 10;
            // 
            // pnlStart
            // 
            this.pnlStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlStart.BackgroundImage")));
            this.pnlStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlStart.Controls.Add(this.lblInstruction);
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Controls.Add(this.lblStartTitle);
            this.pnlStart.Location = new System.Drawing.Point(0, 0);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(693, 549);
            this.pnlStart.TabIndex = 14;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(281, 217);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(167, 16);
            this.lblInstruction.TabIndex = 12;
            this.lblInstruction.Text = "Press start to enter the game!";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(317, 251);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picAskName
            // 
            this.picAskName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAskName.Location = new System.Drawing.Point(273, 153);
            this.picAskName.Name = "picAskName";
            this.picAskName.Size = new System.Drawing.Size(155, 28);
            this.picAskName.TabIndex = 13;
            this.picAskName.TabStop = false;
            // 
            // btnJungle
            // 
            this.btnJungle.BackColor = System.Drawing.Color.Transparent;
            this.btnJungle.BackgroundImage = global::FinalCulminating.Properties.Resources.Jungle;
            this.btnJungle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJungle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJungle.Location = new System.Drawing.Point(474, 351);
            this.btnJungle.Name = "btnJungle";
            this.btnJungle.Size = new System.Drawing.Size(185, 123);
            this.btnJungle.TabIndex = 12;
            this.btnJungle.UseVisualStyleBackColor = false;
            this.btnJungle.Click += new System.EventHandler(this.btnJungle_Click);
            // 
            // btnPetStore
            // 
            this.btnPetStore.BackColor = System.Drawing.Color.Transparent;
            this.btnPetStore.BackgroundImage = global::FinalCulminating.Properties.Resources.PetStore;
            this.btnPetStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPetStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPetStore.Location = new System.Drawing.Point(255, 351);
            this.btnPetStore.Name = "btnPetStore";
            this.btnPetStore.Size = new System.Drawing.Size(185, 123);
            this.btnPetStore.TabIndex = 11;
            this.btnPetStore.UseVisualStyleBackColor = false;
            this.btnPetStore.Click += new System.EventHandler(this.btnPetStore_Click);
            // 
            // btnFarm
            // 
            this.btnFarm.BackColor = System.Drawing.Color.Transparent;
            this.btnFarm.BackgroundImage = global::FinalCulminating.Properties.Resources.Farm;
            this.btnFarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFarm.Location = new System.Drawing.Point(39, 351);
            this.btnFarm.Name = "btnFarm";
            this.btnFarm.Size = new System.Drawing.Size(185, 123);
            this.btnFarm.TabIndex = 10;
            this.btnFarm.UseVisualStyleBackColor = false;
            this.btnFarm.Click += new System.EventHandler(this.btnFarm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Farm                         Pet Store                      Jungle";
            // 
            // lblMenuTItle
            // 
            this.lblMenuTItle.AutoSize = true;
            this.lblMenuTItle.BackColor = System.Drawing.Color.SkyBlue;
            this.lblMenuTItle.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTItle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenuTItle.Location = new System.Drawing.Point(148, 73);
            this.lblMenuTItle.Name = "lblMenuTItle";
            this.lblMenuTItle.Size = new System.Drawing.Size(376, 55);
            this.lblMenuTItle.TabIndex = 16;
            this.lblMenuTItle.Text = "Animal Mania!";
            this.lblMenuTItle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 549);
            this.Controls.Add(this.pnlMenu);
            this.Name = "MenuForm";
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAskName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnEnterName;
        private System.Windows.Forms.Label lblPromptEnvironment;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblStartTitle;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnJungle;
        private System.Windows.Forms.Button btnPetStore;
        private System.Windows.Forms.Button btnFarm;
        private System.Windows.Forms.PictureBox picAskName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblMenuTItle;
    }
}

