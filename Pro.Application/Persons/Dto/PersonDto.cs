using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using Pro.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Persons.Dto
{
	//[AutoMapTo(typeof(User))]
	public class PersonDto : EntityDto<long>, IHasCreationTime
	{


		public string Name { get; set; }

		public string Surname { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }
		public DateTime CreationTime { get => DateTime.Now; set => CreationTime = value; }
	}
}
