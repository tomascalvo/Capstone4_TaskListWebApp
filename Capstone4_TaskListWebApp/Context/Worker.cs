using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone4_TaskListWebApp.Context
{
	public class Worker
	{
		//Properties:
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { get; set; }
		[MaxLength(30)]
		public string FirstName { get; set; }
		[MaxLength(30)]
		public string LastName { get; set; }
		public int Salary { get; set; }
		//Constructor:
		public Worker() { }
	}
}
