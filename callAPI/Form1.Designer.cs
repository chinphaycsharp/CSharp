namespace callAPI
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
            this.btn_getAll = new System.Windows.Forms.Button();
            this.btn_getID = new System.Windows.Forms.Button();
            this.btn_post = new System.Windows.Forms.Button();
            this.btn_put = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_getAll
            // 
            this.btn_getAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getAll.Location = new System.Drawing.Point(12, 12);
            this.btn_getAll.Name = "btn_getAll";
            this.btn_getAll.Size = new System.Drawing.Size(75, 37);
            this.btn_getAll.TabIndex = 0;
            this.btn_getAll.Text = "GetAll";
            this.btn_getAll.UseVisualStyleBackColor = true;
            // 
            // btn_getID
            // 
            this.btn_getID.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_getID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getID.Location = new System.Drawing.Point(126, 12);
            this.btn_getID.Name = "btn_getID";
            this.btn_getID.Size = new System.Drawing.Size(75, 37);
            this.btn_getID.TabIndex = 1;
            this.btn_getID.Text = "getID";
            this.btn_getID.UseVisualStyleBackColor = false;
            // 
            // btn_post
            // 
            this.btn_post.BackColor = System.Drawing.Color.Coral;
            this.btn_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_post.Location = new System.Drawing.Point(373, 12);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 37);
            this.btn_post.TabIndex = 2;
            this.btn_post.Text = "Post";
            this.btn_post.UseVisualStyleBackColor = false;
            // 
            // btn_put
            // 
            this.btn_put.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_put.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_put.Location = new System.Drawing.Point(514, 12);
            this.btn_put.Name = "btn_put";
            this.btn_put.Size = new System.Drawing.Size(75, 37);
            this.btn_put.TabIndex = 3;
            this.btn_put.Text = "Put";
            this.btn_put.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Yellow;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(653, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 37);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(217, 27);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(100, 22);
            this.txt_ma.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 519);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_put);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.btn_getID);
            this.Controls.Add(this.btn_getAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getAll;
        private System.Windows.Forms.Button btn_getID;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.Button btn_put;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_ma;
    }
}

