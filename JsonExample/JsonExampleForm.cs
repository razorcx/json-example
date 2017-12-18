using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JsonExample
{
	public partial class JsonExampleForm : Form
	{
		private readonly string _path = $"d:\\RazorCX\\Development\\Customer.json";

		public JsonExampleForm()
		{
			InitializeComponent();
		}

		private void buttonReadJson_Click(object sender, EventArgs e)
		{
			try
			{
				string jsonFromFile;
				using (var reader = new StreamReader(_path))
				{
					jsonFromFile = reader.ReadToEnd();
				}

				richTextBoxReadJson.Text = jsonFromFile;

				var customerFromJson = JsonConvert.DeserializeObject<Customer>(jsonFromFile);
			}
			catch (Exception ex)
			{
				// ignored
			}
		}

		private void buttonWriteJson_Click(object sender, EventArgs e)
		{
			try
			{
				var customer = GetCustomer();

				var jsonToWrite = JsonConvert.SerializeObject(customer, Formatting.Indented);

				using (var writer = new StreamWriter(_path))
				{
					writer.Write(jsonToWrite);
				}
			}
			catch (Exception ex)
			{
				// ignored
			}
		}

		private Customer GetCustomer()
		{
			var customer = new Customer
			{
				Id = 1,
				FirstName = "Bob",
				LastName = "Smith",
				Location = new Location
				{
					City = "Vancouver",
					Province = "BC",
					Country = "Canada"
				},
				Orders = new List<Order>
				{
					new Order
					{
						Id = 1,
						Items = new List<Item>
						{
							new Item
							{
								Product = new Product
								{
									Sku = "34RTW89",
									Name = "Turbocharger",
									Price = 1050.00
								},
								Quantity = 3
							},
							new Item
							{
								Product = new Product
								{
									Sku = "14UPU90",
									Name = "Hotrod",
									Price = 987.00
								},
								Quantity = 4
							},
							new Item
							{
								Product = new Product
								{
									Sku = "11UPE70",
									Name = "Barn",
									Price = 1902.00
								},
								Quantity = 1
							}
						}
					}
				}
			};

			return customer;
		}
	}

	public class Customer
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Location Location { get; set; }
		public List<Order> Orders { get; set; }
	}

	public class Location
	{
		public string City { get; set; }
		public string Province { get; set; }
		public string Country { get; set; }
	}

	public class Order
	{
		public int Id { get; set; }
		public List<Item> Items { get; set; }
	}

	public class Item
	{
		public Product Product { get; set; }
		public int Quantity { get; set; }
	}

	public class Product
	{
		public string Sku { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
	}
}
