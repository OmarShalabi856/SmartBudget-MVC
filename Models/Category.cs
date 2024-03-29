using System.ComponentModel.DataAnnotations;

namespace SmartBudget.Models
{
	public class Category
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Title is required")]
		public string Title { get; set; }
		public string Icon { get; set; }

		[Required(ErrorMessage = "Type is required")]
		public string Type { get; set; } = "Expense";
	}
}
