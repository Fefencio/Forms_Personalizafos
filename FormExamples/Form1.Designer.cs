
namespace FormExamples
{
    partial class Form1
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
            this.pnBordTop = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnMaximasize = new System.Windows.Forms.Panel();
            this.pnMimimize = new System.Windows.Forms.Panel();
            this.pnClose = new System.Windows.Forms.Panel();
            this.pnBordTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBordTop
            // 
            this.pnBordTop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnBordTop.Controls.Add(this.lbTitulo);
            this.pnBordTop.Controls.Add(this.pnMaximasize);
            this.pnBordTop.Controls.Add(this.pnMimimize);
            this.pnBordTop.Controls.Add(this.pnClose);
            this.pnBordTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnBordTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBordTop.Location = new System.Drawing.Point(0, 0);
            this.pnBordTop.Name = "pnBordTop";
            this.pnBordTop.Size = new System.Drawing.Size(751, 38);
            this.pnBordTop.TabIndex = 0;
            this.pnBordTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBordTop_MouseMove);
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitulo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(134, 8);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(484, 23);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "Titulo predefinido";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnBordTop_MouseMove);
            // 
            // pnMaximasize
            // 
            this.pnMaximasize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnMaximasize.BackColor = System.Drawing.Color.Transparent;
            this.pnMaximasize.BackgroundImage = global::FormExamples.Properties.Resources.Website_Maximize_512;
            this.pnMaximasize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMaximasize.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnMaximasize.Location = new System.Drawing.Point(668, 9);
            this.pnMaximasize.Name = "pnMaximasize";
            this.pnMaximasize.Size = new System.Drawing.Size(28, 22);
            this.pnMaximasize.TabIndex = 2;
            this.pnMaximasize.Click += new System.EventHandler(this.pnMaximasize_Click);
            this.pnMaximasize.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.pnMaximasize.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // pnMimimize
            // 
            this.pnMimimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnMimimize.BackColor = System.Drawing.Color.Transparent;
            this.pnMimimize.BackgroundImage = global::FormExamples.Properties.Resources.minimize_b837e9c641dea4c3b5c662586d475f6c;
            this.pnMimimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMimimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnMimimize.Location = new System.Drawing.Point(624, 9);
            this.pnMimimize.Name = "pnMimimize";
            this.pnMimimize.Size = new System.Drawing.Size(28, 22);
            this.pnMimimize.TabIndex = 2;
            this.pnMimimize.Click += new System.EventHandler(this.pnMimimize_Click);
            this.pnMimimize.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.pnMimimize.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // pnClose
            // 
            this.pnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnClose.BackColor = System.Drawing.Color.Transparent;
            this.pnClose.BackgroundImage = global::FormExamples.Properties.Resources.img_352348;
            this.pnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnClose.Location = new System.Drawing.Point(712, 9);
            this.pnClose.Name = "pnClose";
            this.pnClose.Size = new System.Drawing.Size(28, 22);
            this.pnClose.TabIndex = 1;
            this.pnClose.Click += new System.EventHandler(this.pnClose_Click);
            this.pnClose.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.pnClose.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 376);
            this.Controls.Add(this.pnBordTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnBordTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBordTop;
        private System.Windows.Forms.Panel pnMaximasize;
        private System.Windows.Forms.Panel pnMimimize;
        private System.Windows.Forms.Panel pnClose;
        private System.Windows.Forms.Label lbTitulo;
    }
}

