using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using WinFormTreeViewExercise.Properties;

namespace WinFormTreeViewExercise
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			using (var cn = new SqlConnection(Settings.Default.Northwind))
			{
				var nodesData = cn.Query<CustomerOrderInfo>(@"
					SELECT
						C.CustomerID,
						C.CompanyName,
						O.OrderID
					FROM
						Customers AS C
						LEFT JOIN
						Orders AS O ON C.CustomerID = O.CustomerID;");

				var nodes = from data in nodesData
							group data by (data.CustomerID, data.CompanyName) into g
							select new TreeNode(
								$"{g.Key.CompanyName}({g.Key.CustomerID})",
								g.Select(orderData => new TreeNode(orderData.OrderID.ToString())
								{
									Tag = orderData.OrderID
								}).ToArray());

				treeDataList.Nodes.AddRange(nodes.ToArray());

			}
		}

		private void treeDataList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			var clickedNode = e.Node;

			lblOrderId.Text = string.Empty;
			lblCustomerId.Text = string.Empty;
			lblEmployeeId.Text = string.Empty;
			lblOrderDate.Text = string.Empty;
			lblRequiredDate.Text = string.Empty;
			lblShippingDate.Text = string.Empty;
			lblShipVia.Text = string.Empty;
			lblFreight.Text = string.Empty;
			lblShipName.Text = string.Empty;
			lblShipAddress.Text = string.Empty;
			lblShipCity.Text = string.Empty;
			lblShipRegion.Text = string.Empty;
			lblShipPostalCode.Text = string.Empty;
			lblShipCountry.Text = string.Empty;

			if (e.Node.Tag is int orderId)
			{
				using (var cn = new SqlConnection(Settings.Default.Northwind))
				{
					var orderData = cn.Query(@"
						SELECT
							[OrderID],
							[CustomerID],
							[EmployeeID],
							[OrderDate],
							[RequiredDate],
							[ShippedDate],
							[ShipVia],
							[Freight],
							[ShipName],
							[ShipAddress],
							[ShipCity],
							[ShipRegion],
							[ShipPostalCode],
							[ShipCountry]
						FROM
							Orders
						WHERE
							OrderID = @orderId",
						new
						{
							orderId = orderId
						}).FirstOrDefault();

					lblOrderId.Text = orderData.OrderID.ToString();
					lblCustomerId.Text = orderData.CustomerID;
					lblEmployeeId.Text = orderData.EmployeeID.ToString();
					lblOrderDate.Text = orderData.OrderDate.ToString("yyyy/MM/dd");
					lblRequiredDate.Text = orderData.RequiredDate.ToString("yyyy/MM/dd");
					lblShippingDate.Text = orderData.ShippedDate.ToString("yyyy/MM/dd");
					lblShipVia.Text = orderData.ShipVia.ToString();
					lblFreight.Text = orderData.Freight.ToString();
					lblShipName.Text = orderData.ShipName;
					lblShipAddress.Text = orderData.ShipAddress;
					lblShipCity.Text = orderData.ShipCity;
					lblShipRegion.Text = orderData.ShipRegion;
					lblShipPostalCode.Text = orderData.ShipPostalCode;
					lblShipCountry.Text = orderData.ShipCountry;
				}
			}
		}
	}
}
