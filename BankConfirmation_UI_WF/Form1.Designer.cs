namespace BankConfirmation_UI_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox = new GroupBox();
            Payment = new Button();
            CreditClosed = new Button();
            Credit = new Button();
            Deposit = new Button();
            CreditCard = new Button();
            OverDraft = new Button();
            AccountClosed = new Button();
            Account = new Button();
            Client = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.IndianRed;
            groupBox.Controls.Add(Payment);
            groupBox.Controls.Add(CreditClosed);
            groupBox.Controls.Add(Credit);
            groupBox.Controls.Add(Deposit);
            groupBox.Controls.Add(CreditCard);
            groupBox.Controls.Add(OverDraft);
            groupBox.Controls.Add(AccountClosed);
            groupBox.Controls.Add(Account);
            groupBox.Controls.Add(Client);
            groupBox.Location = new Point(1, -11);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(1132, 74);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            // 
            // Payment
            // 
            Payment.Location = new Point(1015, 22);
            Payment.Name = "Payment";
            Payment.Size = new Size(106, 35);
            Payment.TabIndex = 8;
            Payment.Text = "Payment";
            Payment.UseVisualStyleBackColor = true;
            // 
            // CreditClosed
            // 
            CreditClosed.Location = new Point(894, 22);
            CreditClosed.Name = "CreditClosed";
            CreditClosed.Size = new Size(106, 35);
            CreditClosed.TabIndex = 7;
            CreditClosed.Text = "Credit Closed";
            CreditClosed.UseVisualStyleBackColor = true;
            // 
            // Credit
            // 
            Credit.Location = new Point(772, 22);
            Credit.Name = "Credit";
            Credit.Size = new Size(106, 35);
            Credit.TabIndex = 6;
            Credit.Text = "Credit";
            Credit.UseVisualStyleBackColor = true;
            // 
            // Deposit
            // 
            Deposit.Location = new Point(647, 22);
            Deposit.Name = "Deposit";
            Deposit.Size = new Size(106, 35);
            Deposit.TabIndex = 5;
            Deposit.Text = "Deposit";
            Deposit.UseVisualStyleBackColor = true;
            // 
            // CreditCard
            // 
            CreditCard.Location = new Point(519, 22);
            CreditCard.Name = "CreditCard";
            CreditCard.Size = new Size(106, 35);
            CreditCard.TabIndex = 4;
            CreditCard.Text = "Credit Card";
            CreditCard.UseVisualStyleBackColor = true;
            // 
            // OverDraft
            // 
            OverDraft.Location = new Point(392, 22);
            OverDraft.Name = "OverDraft";
            OverDraft.Size = new Size(106, 35);
            OverDraft.TabIndex = 3;
            OverDraft.Text = "OverDraft";
            OverDraft.UseVisualStyleBackColor = true;
            // 
            // AccountClosed
            // 
            AccountClosed.Location = new Point(264, 22);
            AccountClosed.Name = "AccountClosed";
            AccountClosed.Size = new Size(106, 35);
            AccountClosed.TabIndex = 2;
            AccountClosed.Text = "Account Closed";
            AccountClosed.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            Account.Location = new Point(136, 22);
            Account.Name = "Account";
            Account.Size = new Size(106, 35);
            Account.TabIndex = 1;
            Account.Text = "Account";
            Account.UseVisualStyleBackColor = true;
            Account.Click += AccountClick;
            // 
            // Client
            // 
            Client.Location = new Point(11, 22);
            Client.Name = "Client";
            Client.Size = new Size(106, 35);
            Client.TabIndex = 0;
            Client.Text = "Client";
            Client.UseVisualStyleBackColor = true;
            Client.Click += ClientClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.addiko_FormLayout;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1134, 449);
            Controls.Add(groupBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddikoBank";
            WindowState = FormWindowState.Maximized;
            groupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Button Client;
        private Button Payment;
        private Button CreditClosed;
        private Button Credit;
        private Button Deposit;
        private Button CreditCard;
        private Button OverDraft;
        private Button AccountClosed;
        private Button Account;
    }
}
