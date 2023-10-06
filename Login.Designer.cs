
namespace StokTakipveSatisUygulamasi
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.loginCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.LoginBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.SignUpBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.loginUserTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginPassTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 0;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.gunaPanel1, "gunaPanel1");
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Name = "gunaPanel1";
            // 
            // gunaPanel2
            // 
            resources.ApplyResources(this.gunaPanel2, "gunaPanel2");
            this.gunaPanel2.Name = "gunaPanel2";
            // 
            // gunaControlBox1
            // 
            resources.ApplyResources(this.gunaControlBox1, "gunaControlBox1");
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // gunaControlBox2
            // 
            resources.ApplyResources(this.gunaControlBox2, "gunaControlBox2");
            this.gunaControlBox2.Animated = true;
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.DeepSkyBlue;
            // 
            // gunaLabel2
            // 
            resources.ApplyResources(this.gunaLabel2, "gunaLabel2");
            this.gunaLabel2.Name = "gunaLabel2";
            // 
            // gunaLabel1
            // 
            resources.ApplyResources(this.gunaLabel1, "gunaLabel1");
            this.gunaLabel1.Name = "gunaLabel1";
            // 
            // gunaPanel3
            // 
            resources.ApplyResources(this.gunaPanel3, "gunaPanel3");
            this.gunaPanel3.Name = "gunaPanel3";
            // 
            // loginCheckBox
            // 
            this.loginCheckBox.BaseColor = System.Drawing.Color.White;
            this.loginCheckBox.CheckedOffColor = System.Drawing.Color.Gray;
            this.loginCheckBox.CheckedOnColor = System.Drawing.Color.DeepSkyBlue;
            this.loginCheckBox.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.loginCheckBox, "loginCheckBox");
            this.loginCheckBox.Name = "loginCheckBox";
            this.loginCheckBox.CheckedChanged += new System.EventHandler(this.gunaCheckBox1_CheckedChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.AnimationHoverSpeed = 0.07F;
            this.LoginBtn.AnimationSpeed = 0.03F;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BaseColor1 = System.Drawing.Color.LightGray;
            this.LoginBtn.BaseColor2 = System.Drawing.Color.DeepSkyBlue;
            this.LoginBtn.BorderColor = System.Drawing.Color.Black;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.LoginBtn, "LoginBtn");
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Image = ((System.Drawing.Image)(resources.GetObject("LoginBtn.Image")));
            this.LoginBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnHoverBaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.LoginBtn.OnHoverBaseColor2 = System.Drawing.Color.LightGray;
            this.LoginBtn.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.LoginBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnHoverImage = null;
            this.LoginBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LoginBtn.Radius = 4;
            this.LoginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.AnimationHoverSpeed = 0.07F;
            this.SignUpBtn.AnimationSpeed = 0.03F;
            this.SignUpBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignUpBtn.BaseColor1 = System.Drawing.Color.LightGray;
            this.SignUpBtn.BaseColor2 = System.Drawing.Color.DeepSkyBlue;
            this.SignUpBtn.BorderColor = System.Drawing.Color.Black;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignUpBtn.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.SignUpBtn, "SignUpBtn");
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.Image = ((System.Drawing.Image)(resources.GetObject("SignUpBtn.Image")));
            this.SignUpBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.OnHoverBaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.SignUpBtn.OnHoverBaseColor2 = System.Drawing.Color.LightGray;
            this.SignUpBtn.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.SignUpBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SignUpBtn.OnHoverImage = null;
            this.SignUpBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SignUpBtn.Radius = 4;
            this.SignUpBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // gunaLabel3
            // 
            resources.ApplyResources(this.gunaLabel3, "gunaLabel3");
            this.gunaLabel3.Name = "gunaLabel3";
            // 
            // loginUserTxt
            // 
            this.loginUserTxt.AcceptsTab = true;
            this.loginUserTxt.Animated = true;
            this.loginUserTxt.BackColor = System.Drawing.Color.White;
            this.loginUserTxt.BorderRadius = 2;
            this.loginUserTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginUserTxt.DefaultText = "";
            this.loginUserTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginUserTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginUserTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginUserTxt.DisabledState.Parent = this.loginUserTxt;
            this.loginUserTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginUserTxt.FillColor = System.Drawing.Color.WhiteSmoke;
            this.loginUserTxt.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.loginUserTxt.FocusedState.Parent = this.loginUserTxt;
            resources.ApplyResources(this.loginUserTxt, "loginUserTxt");
            this.loginUserTxt.ForeColor = System.Drawing.Color.Black;
            this.loginUserTxt.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.loginUserTxt.HoverState.Parent = this.loginUserTxt;
            this.loginUserTxt.IconLeft = ((System.Drawing.Image)(resources.GetObject("loginUserTxt.IconLeft")));
            this.loginUserTxt.IconLeftSize = new System.Drawing.Size(30, 30);
            this.loginUserTxt.Name = "loginUserTxt";
            this.loginUserTxt.PasswordChar = '\0';
            this.loginUserTxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.loginUserTxt.PlaceholderText = "Username";
            this.loginUserTxt.SelectedText = "";
            this.loginUserTxt.ShadowDecoration.Parent = this.loginUserTxt;
            // 
            // loginPassTxt
            // 
            this.loginPassTxt.AcceptsTab = true;
            this.loginPassTxt.Animated = true;
            this.loginPassTxt.BackColor = System.Drawing.Color.White;
            this.loginPassTxt.BorderRadius = 2;
            this.loginPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginPassTxt.DefaultText = "";
            this.loginPassTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginPassTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginPassTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginPassTxt.DisabledState.Parent = this.loginPassTxt;
            this.loginPassTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginPassTxt.FillColor = System.Drawing.Color.WhiteSmoke;
            this.loginPassTxt.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.loginPassTxt.FocusedState.Parent = this.loginPassTxt;
            resources.ApplyResources(this.loginPassTxt, "loginPassTxt");
            this.loginPassTxt.ForeColor = System.Drawing.Color.Black;
            this.loginPassTxt.HoverState.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.loginPassTxt.HoverState.Parent = this.loginPassTxt;
            this.loginPassTxt.IconLeft = ((System.Drawing.Image)(resources.GetObject("loginPassTxt.IconLeft")));
            this.loginPassTxt.IconLeftSize = new System.Drawing.Size(30, 30);
            this.loginPassTxt.Name = "loginPassTxt";
            this.loginPassTxt.PasswordChar = '*';
            this.loginPassTxt.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.loginPassTxt.PlaceholderText = "Password";
            this.loginPassTxt.SelectedText = "";
            this.loginPassTxt.ShadowDecoration.Parent = this.loginPassTxt;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.loginPassTxt);
            this.Controls.Add(this.loginUserTxt);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.loginCheckBox);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaCheckBox loginCheckBox;
        private Guna.UI.WinForms.GunaGradientButton LoginBtn;
        private Guna.UI.WinForms.GunaGradientButton SignUpBtn;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2TextBox loginPassTxt;
        private Guna.UI2.WinForms.Guna2TextBox loginUserTxt;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Timer timer1;
    }
}

