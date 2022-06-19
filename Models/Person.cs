using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetFrameworkLeaner.Models
{
	[Table("Users")]
	public class Person
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string NickName { get; set; }
		[Required]
		public string PasswordDigest { get; set; }
	}
}

