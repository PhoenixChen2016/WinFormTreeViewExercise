namespace WinFormTreeViewExercise
{
	partial class MainForm
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && ( components != null ))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.TreeView treeDataList;
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.lblOrderId = new System.Windows.Forms.Label();
			this.lblCustomerId = new System.Windows.Forms.Label();
			this.lblEmployeeId = new System.Windows.Forms.Label();
			this.lblOrderDate = new System.Windows.Forms.Label();
			this.lblRequiredDate = new System.Windows.Forms.Label();
			this.lblShippingDate = new System.Windows.Forms.Label();
			this.lblShipVia = new System.Windows.Forms.Label();
			this.lblFreight = new System.Windows.Forms.Label();
			this.lblShipName = new System.Windows.Forms.Label();
			this.lblShipAddress = new System.Windows.Forms.Label();
			this.lblShipCity = new System.Windows.Forms.Label();
			this.lblShipRegion = new System.Windows.Forms.Label();
			this.lblShipPostalCode = new System.Windows.Forms.Label();
			this.lblShipCountry = new System.Windows.Forms.Label();
			treeDataList = new System.Windows.Forms.TreeView();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel1.Controls.Add(treeDataList, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1211, 731);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// treeDataList
			// 
			treeDataList.Dock = System.Windows.Forms.DockStyle.Fill;
			treeDataList.Location = new System.Drawing.Point(10, 11);
			treeDataList.Margin = new System.Windows.Forms.Padding(4);
			treeDataList.Name = "treeDataList";
			treeDataList.Size = new System.Drawing.Size(349, 709);
			treeDataList.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.label9, 0, 8);
			this.tableLayoutPanel2.Controls.Add(this.label10, 0, 9);
			this.tableLayoutPanel2.Controls.Add(this.label11, 0, 10);
			this.tableLayoutPanel2.Controls.Add(this.label12, 0, 11);
			this.tableLayoutPanel2.Controls.Add(this.label13, 0, 12);
			this.tableLayoutPanel2.Controls.Add(this.label14, 0, 13);
			this.tableLayoutPanel2.Controls.Add(this.lblOrderId, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblCustomerId, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.lblEmployeeId, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.lblOrderDate, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.lblRequiredDate, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.lblShippingDate, 1, 5);
			this.tableLayoutPanel2.Controls.Add(this.lblShipVia, 1, 6);
			this.tableLayoutPanel2.Controls.Add(this.lblFreight, 1, 7);
			this.tableLayoutPanel2.Controls.Add(this.lblShipName, 1, 8);
			this.tableLayoutPanel2.Controls.Add(this.lblShipAddress, 1, 9);
			this.tableLayoutPanel2.Controls.Add(this.lblShipCity, 1, 10);
			this.tableLayoutPanel2.Controls.Add(this.lblShipRegion, 1, 11);
			this.tableLayoutPanel2.Controls.Add(this.lblShipPostalCode, 1, 12);
			this.tableLayoutPanel2.Controls.Add(this.lblShipCountry, 1, 13);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(372, 10);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 15;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(827, 711);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "OrderID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(242, 50);
			this.label2.TabIndex = 1;
			this.label2.Text = "CustomerID";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(242, 50);
			this.label3.TabIndex = 2;
			this.label3.Text = "EmployeeID";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(242, 50);
			this.label4.TabIndex = 3;
			this.label4.Text = "OrderDate";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(242, 50);
			this.label5.TabIndex = 4;
			this.label5.Text = "RequiredDate";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(3, 250);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(242, 50);
			this.label6.TabIndex = 5;
			this.label6.Text = "ShippingDate";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(3, 300);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(242, 50);
			this.label7.TabIndex = 6;
			this.label7.Text = "ShipVia";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Location = new System.Drawing.Point(3, 350);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(242, 50);
			this.label8.TabIndex = 7;
			this.label8.Text = "Freight";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Location = new System.Drawing.Point(3, 400);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(242, 50);
			this.label9.TabIndex = 8;
			this.label9.Text = "ShipName";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.Location = new System.Drawing.Point(3, 450);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(242, 50);
			this.label10.TabIndex = 9;
			this.label10.Text = "ShipAddress";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label11.Location = new System.Drawing.Point(3, 500);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(242, 50);
			this.label11.TabIndex = 10;
			this.label11.Text = "ShipCity";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label12.Location = new System.Drawing.Point(3, 550);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(242, 50);
			this.label12.TabIndex = 11;
			this.label12.Text = "ShipRegion";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label13.Location = new System.Drawing.Point(3, 600);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(242, 50);
			this.label13.TabIndex = 12;
			this.label13.Text = "ShipPostalCode";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label14.Location = new System.Drawing.Point(3, 650);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(242, 50);
			this.label14.TabIndex = 13;
			this.label14.Text = "ShipCountry";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblOrderId
			// 
			this.lblOrderId.AutoSize = true;
			this.lblOrderId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblOrderId.Location = new System.Drawing.Point(251, 0);
			this.lblOrderId.Name = "lblOrderId";
			this.lblOrderId.Size = new System.Drawing.Size(573, 50);
			this.lblOrderId.TabIndex = 14;
			this.lblOrderId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCustomerId
			// 
			this.lblCustomerId.AutoSize = true;
			this.lblCustomerId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCustomerId.Location = new System.Drawing.Point(251, 50);
			this.lblCustomerId.Name = "lblCustomerId";
			this.lblCustomerId.Size = new System.Drawing.Size(573, 50);
			this.lblCustomerId.TabIndex = 15;
			this.lblCustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblEmployeeId
			// 
			this.lblEmployeeId.AutoSize = true;
			this.lblEmployeeId.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblEmployeeId.Location = new System.Drawing.Point(251, 100);
			this.lblEmployeeId.Name = "lblEmployeeId";
			this.lblEmployeeId.Size = new System.Drawing.Size(573, 50);
			this.lblEmployeeId.TabIndex = 16;
			this.lblEmployeeId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblOrderDate
			// 
			this.lblOrderDate.AutoSize = true;
			this.lblOrderDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblOrderDate.Location = new System.Drawing.Point(251, 150);
			this.lblOrderDate.Name = "lblOrderDate";
			this.lblOrderDate.Size = new System.Drawing.Size(573, 50);
			this.lblOrderDate.TabIndex = 17;
			this.lblOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblRequiredDate
			// 
			this.lblRequiredDate.AutoSize = true;
			this.lblRequiredDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblRequiredDate.Location = new System.Drawing.Point(251, 200);
			this.lblRequiredDate.Name = "lblRequiredDate";
			this.lblRequiredDate.Size = new System.Drawing.Size(573, 50);
			this.lblRequiredDate.TabIndex = 18;
			this.lblRequiredDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblShippingDate
			// 
			this.lblShippingDate.AutoSize = true;
			this.lblShippingDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblShippingDate.Location = new System.Drawing.Point(251, 250);
			this.lblShippingDate.Name = "lblShippingDate";
			this.lblShippingDate.Size = new System.Drawing.Size(573, 50);
			this.lblShippingDate.TabIndex = 19;
			this.lblShippingDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblShipVia
			// 
			this.lblShipVia.AutoSize = true;
			this.lblShipVia.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblShipVia.Location = new System.Drawing.Point(251, 300);
			this.lblShipVia.Name = "lblShipVia";
			this.lblShipVia.Size = new System.Drawing.Size(573, 50);
			this.lblShipVia.TabIndex = 20;
			this.lblShipVia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFreight
			// 
			this.lblFreight.AutoSize = true;
			this.lblFreight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblFreight.Location = new System.Drawing.Point(251, 350);
			this.lblFreight.Name = "lblFreight";
			this.lblFreight.Size = new System.Drawing.Size(573, 50);
			this.lblFreight.TabIndex = 21;
			this.lblFreight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblShipName
			// 
			this.lblShipName.AutoSize = true;
			this.lblShipName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblShipName.Location = new System.Drawing.Point(251, 400);
			this.lblShipName.Name = "lblShipName";
			this.lblShipName.Size = new System.Drawing.Size(573, 50);
			this.lblShipName.TabIndex = 22;
			this.lblShipName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblShipAddress
			// 
			this.lblShipAddress.AutoSize = true;
			this.lblShipAddress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblShipAddress.Location = new System.Drawing.Point(251, 450);
			this.lblShipAddress.Name = "lblShipAddress";
			this.lblShipAddress.Size = new System.Drawing.Size(573, 50);
			this.lblShipAddress.TabIndex = 23;
			this.lblShipAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblShipCity
			// 
			this.lblShipCity.AutoSize = true;
			this.lblShipCity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblShipCity.Location = new System.Drawing.Point(251, 500);
			this.lblShipCity.Name = "lblShipCity";
			this.lblShipCity.Size = new System.Drawing.Size(573, 50);
			this.lblShipCity.TabIndex = 24;
			this.lblShipCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblShipRegion
			// 
			this.lblShipRegion.AutoSize = true;
			this.lblShipRegion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblShipRegion.Location = new System.Drawing.Point(251, 550);
			this.lblShipRegion.Name = "lblShipRegion";
			this.lblShipRegion.Size = new System.Drawing.Size(573, 50);
			this.lblShipRegion.TabIndex = 25;
			this.lblShipRegion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblShipPostalCode
			// 
			this.lblShipPostalCode.AutoSize = true;
			this.lblShipPostalCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblShipPostalCode.Location = new System.Drawing.Point(251, 600);
			this.lblShipPostalCode.Name = "lblShipPostalCode";
			this.lblShipPostalCode.Size = new System.Drawing.Size(573, 50);
			this.lblShipPostalCode.TabIndex = 26;
			this.lblShipPostalCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblShipCountry
			// 
			this.lblShipCountry.AutoSize = true;
			this.lblShipCountry.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblShipCountry.Location = new System.Drawing.Point(251, 650);
			this.lblShipCountry.Name = "lblShipCountry";
			this.lblShipCountry.Size = new System.Drawing.Size(573, 50);
			this.lblShipCountry.TabIndex = 27;
			this.lblShipCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1211, 731);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Order List";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label lblOrderId;
		private System.Windows.Forms.Label lblCustomerId;
		private System.Windows.Forms.Label lblEmployeeId;
		private System.Windows.Forms.Label lblOrderDate;
		private System.Windows.Forms.Label lblRequiredDate;
		private System.Windows.Forms.Label lblShippingDate;
		private System.Windows.Forms.Label lblShipVia;
		private System.Windows.Forms.Label lblFreight;
		private System.Windows.Forms.Label lblShipName;
		private System.Windows.Forms.Label lblShipAddress;
		private System.Windows.Forms.Label lblShipCity;
		private System.Windows.Forms.Label lblShipRegion;
		private System.Windows.Forms.Label lblShipPostalCode;
		private System.Windows.Forms.Label lblShipCountry;
	}
}

