namespace RestaurantBillCalculator
{
    partial class MainForm
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
            this.cmbBeverage = new System.Windows.Forms.ComboBox();
            this.btnClearBill = new System.Windows.Forms.Button();
            this.cmbAppetizer = new System.Windows.Forms.ComboBox();
            this.cmbMainCourse = new System.Windows.Forms.ComboBox();
            this.cmbDessert = new System.Windows.Forms.ComboBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbBeverage
            // 
            this.cmbBeverage.FormattingEnabled = true;
            this.cmbBeverage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbBeverage.Items.AddRange(new object[] {
            "Soda  $1.95",
            "Tea  $1.50",
            "Coffee  $1.25",
            "Mineral Water  $2.95",
            "Juice  $2.50",
            "Milk  $1.50"});
            this.cmbBeverage.Location = new System.Drawing.Point(64, 92);
            this.cmbBeverage.Name = "cmbBeverage";
            this.cmbBeverage.Size = new System.Drawing.Size(149, 24);
            this.cmbBeverage.TabIndex = 0;
            this.cmbBeverage.Text = "Beverage";
            this.cmbBeverage.UseWaitCursor = true;
            this.cmbBeverage.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // btnClearBill
            // 
            this.btnClearBill.Location = new System.Drawing.Point(681, 36);
            this.btnClearBill.Name = "btnClearBill";
            this.btnClearBill.Size = new System.Drawing.Size(75, 23);
            this.btnClearBill.TabIndex = 1;
            this.btnClearBill.Text = "Clear Bill";
            this.btnClearBill.UseVisualStyleBackColor = true;
            this.btnClearBill.UseWaitCursor = true;
            this.btnClearBill.Click += new System.EventHandler(this.btnClearBill_Click);
            // 
            // cmbAppetizer
            // 
            this.cmbAppetizer.FormattingEnabled = true;
            this.cmbAppetizer.Items.AddRange(new object[] {
            "Buffalo Wings  $5.95",
            "Buffalo Fingers  $6.95",
            "Potato Skins  $8.95",
            "Nachos   $8.95",
            "Mushroom Caps  $10.95",
            "Shrimp Cocktail  $12.95",
            "Chips and Salsa  $6.95"});
            this.cmbAppetizer.Location = new System.Drawing.Point(232, 92);
            this.cmbAppetizer.Name = "cmbAppetizer";
            this.cmbAppetizer.Size = new System.Drawing.Size(155, 24);
            this.cmbAppetizer.TabIndex = 2;
            this.cmbAppetizer.Text = "Appetizer";
            this.cmbAppetizer.UseWaitCursor = true;
            this.cmbAppetizer.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // cmbMainCourse
            // 
            this.cmbMainCourse.FormattingEnabled = true;
            this.cmbMainCourse.Items.AddRange(new object[] {
            "Seafood Alfredo  $15.95",
            "Chicken Alfredo  $13.95",
            "Chicken Picatta  $13.95",
            "Turkey Club  $11.95",
            "Lobster Pie  $19.95",
            "Prime Rib  $20.95",
            "Shrimp Scampi  $18.95",
            "Turkey Dinner  $13.95",
            "Stuffed Chicken  $14.95"});
            this.cmbMainCourse.Location = new System.Drawing.Point(407, 92);
            this.cmbMainCourse.Name = "cmbMainCourse";
            this.cmbMainCourse.Size = new System.Drawing.Size(150, 24);
            this.cmbMainCourse.TabIndex = 3;
            this.cmbMainCourse.Text = "Main Course";
            this.cmbMainCourse.UseWaitCursor = true;
            this.cmbMainCourse.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // cmbDessert
            // 
            this.cmbDessert.FormattingEnabled = true;
            this.cmbDessert.Items.AddRange(new object[] {
            "Apple Pie  $5.95",
            "Sundae  $3.95",
            "Carrot Cake  $5.95",
            "Mud Pie  $4.95",
            "Apple Crisp  $5.95"});
            this.cmbDessert.Location = new System.Drawing.Point(575, 92);
            this.cmbDessert.Name = "cmbDessert";
            this.cmbDessert.Size = new System.Drawing.Size(167, 24);
            this.cmbDessert.TabIndex = 4;
            this.cmbDessert.Text = "Dessert";
            this.cmbDessert.UseWaitCursor = true;
            this.cmbDessert.SelectedIndexChanged += new System.EventHandler(this.dropdownSelection);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(92, 150);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(634, 260);
            this.lstOutput.TabIndex = 9;
            this.lstOutput.UseWaitCursor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.cmbDessert);
            this.Controls.Add(this.cmbMainCourse);
            this.Controls.Add(this.cmbAppetizer);
            this.Controls.Add(this.btnClearBill);
            this.Controls.Add(this.cmbBeverage);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBeverage;
        private System.Windows.Forms.Button btnClearBill;
        private System.Windows.Forms.ComboBox cmbAppetizer;
        private System.Windows.Forms.ComboBox cmbMainCourse;
        private System.Windows.Forms.ComboBox cmbDessert;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

