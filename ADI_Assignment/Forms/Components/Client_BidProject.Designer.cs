namespace Freelancer_client.Forms.Components
{
    partial class Client_BidProject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flow_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flow_panel
            // 
            this.flow_panel.AutoScroll = true;
            this.flow_panel.BackColor = System.Drawing.Color.White;
            this.flow_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_panel.Location = new System.Drawing.Point(0, 0);
            this.flow_panel.Name = "flow_panel";
            this.flow_panel.Size = new System.Drawing.Size(690, 456);
            this.flow_panel.TabIndex = 0;
            // 
            // Client_BidProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flow_panel);
            this.Name = "Client_BidProject";
            this.Size = new System.Drawing.Size(690, 456);
            this.Load += new System.EventHandler(this.Client_BidViewLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow_panel;
    }
}
