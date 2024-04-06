namespace CookBook.UI
{
    partial class RecipesForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddRecipeBtn = new Button();
            RecipeIngredientsBtn = new Button();
            ClearAllFieldsBtn = new Button();
            NameTxt = new TextBox();
            RecipeTypesCbx = new ComboBox();
            AddRecipeTypeBtn = new Button();
            DescriptionTxt = new RichTextBox();
            RecipePictureBox = new PictureBox();
            RecipesFilterCbx = new ComboBox();
            RecipesGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(794, 38);
            label1.Name = "label1";
            label1.Size = new Size(74, 30);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(794, 97);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 1;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(794, 181);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(794, 320);
            label4.Name = "label4";
            label4.Size = new Size(76, 30);
            label4.TabIndex = 3;
            label4.Text = "Image:";
            // 
            // AddRecipeBtn
            // 
            AddRecipeBtn.Location = new Point(794, 454);
            AddRecipeBtn.Name = "AddRecipeBtn";
            AddRecipeBtn.Size = new Size(398, 45);
            AddRecipeBtn.TabIndex = 4;
            AddRecipeBtn.Text = "Add recipe";
            AddRecipeBtn.UseVisualStyleBackColor = true;
            AddRecipeBtn.Click += AddRecipeBtn_Click;
            // 
            // RecipeIngredientsBtn
            // 
            RecipeIngredientsBtn.Location = new Point(794, 505);
            RecipeIngredientsBtn.Name = "RecipeIngredientsBtn";
            RecipeIngredientsBtn.Size = new Size(398, 45);
            RecipeIngredientsBtn.TabIndex = 5;
            RecipeIngredientsBtn.Text = "Recipe ingredients";
            RecipeIngredientsBtn.UseVisualStyleBackColor = true;
            // 
            // ClearAllFieldsBtn
            // 
            ClearAllFieldsBtn.Location = new Point(794, 554);
            ClearAllFieldsBtn.Name = "ClearAllFieldsBtn";
            ClearAllFieldsBtn.Size = new Size(398, 45);
            ClearAllFieldsBtn.TabIndex = 6;
            ClearAllFieldsBtn.Text = "Clear all fields";
            ClearAllFieldsBtn.UseVisualStyleBackColor = true;
            ClearAllFieldsBtn.Click += ClearAllFieldsBtn_Click;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(917, 38);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(275, 35);
            NameTxt.TabIndex = 7;
            // 
            // RecipeTypesCbx
            // 
            RecipeTypesCbx.FormattingEnabled = true;
            RecipeTypesCbx.Location = new Point(917, 89);
            RecipeTypesCbx.Name = "RecipeTypesCbx";
            RecipeTypesCbx.Size = new Size(154, 38);
            RecipeTypesCbx.TabIndex = 8;
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.Location = new Point(1086, 89);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(106, 38);
            AddRecipeTypeBtn.TabIndex = 9;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Location = new Point(917, 150);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(275, 96);
            DescriptionTxt.TabIndex = 10;
            DescriptionTxt.Text = "";
            // 
            // RecipePictureBox
            // 
            RecipePictureBox.Location = new Point(917, 275);
            RecipePictureBox.Name = "RecipePictureBox";
            RecipePictureBox.Size = new Size(275, 153);
            RecipePictureBox.TabIndex = 11;
            RecipePictureBox.TabStop = false;
            RecipePictureBox.Click += RecipePictureBox_Click;
            // 
            // RecipesFilterCbx
            // 
            RecipesFilterCbx.FormattingEnabled = true;
            RecipesFilterCbx.Location = new Point(22, 35);
            RecipesFilterCbx.Name = "RecipesFilterCbx";
            RecipesFilterCbx.Size = new Size(748, 38);
            RecipesFilterCbx.TabIndex = 12;
            // 
            // RecipesGrid
            // 
            RecipesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecipesGrid.Location = new Point(22, 97);
            RecipesGrid.Name = "RecipesGrid";
            RecipesGrid.RowTemplate.Height = 25;
            RecipesGrid.Size = new Size(748, 502);
            RecipesGrid.TabIndex = 13;
            RecipesGrid.CellClick += RecipesGrid_CellClick;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 621);
            Controls.Add(RecipesGrid);
            Controls.Add(RecipesFilterCbx);
            Controls.Add(RecipePictureBox);
            Controls.Add(DescriptionTxt);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(RecipeTypesCbx);
            Controls.Add(NameTxt);
            Controls.Add(ClearAllFieldsBtn);
            Controls.Add(RecipeIngredientsBtn);
            Controls.Add(AddRecipeBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipesForm";
            Text = "RecipesForm";
            Load += RecipesForm_Load;
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button AddRecipeBtn;
        private Button RecipeIngredientsBtn;
        private Button ClearAllFieldsBtn;
        private TextBox NameTxt;
        private ComboBox RecipeTypesCbx;
        private Button AddRecipeTypeBtn;
        private RichTextBox DescriptionTxt;
        private PictureBox RecipePictureBox;
        private ComboBox RecipesFilterCbx;
        private DataGridView RecipesGrid;
    }
}