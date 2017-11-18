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
								g.Select(orderData => new TreeNode(orderData.OrderID.ToString())).ToArray());

				treeDataList.Nodes.AddRange(nodes.ToArray());

			}
		}
	}
}
