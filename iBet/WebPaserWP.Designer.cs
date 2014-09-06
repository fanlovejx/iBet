namespace iBet
{
    partial class WebPaserWP
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
            this._web = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // _web
            // 
            this._web.Dock = System.Windows.Forms.DockStyle.Fill;
            this._web.Location = new System.Drawing.Point(0, 0);
            this._web.MinimumSize = new System.Drawing.Size(20, 20);
            this._web.Name = "_web";
            this._web.ScriptErrorsSuppressed = true;
            this._web.Size = new System.Drawing.Size(741, 434);
            this._web.TabIndex = 0;
            // 
            // WebPaserWP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 434);
            this.Controls.Add(this._web);
            this.Name = "WebPaserWP";
            this.Text = "WebPaserWP";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser _web;

    }
}