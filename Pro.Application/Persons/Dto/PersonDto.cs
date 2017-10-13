using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
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
	public class PersonDto : EntityDto<long>, IFullAudited, IPassivable, IExtendableObject
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public long? CreatorUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public long? LastModifierUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime? LastModificationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public long? DeleterUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public DateTime? DeletionTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public bool IsActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string ExtensionData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	}
}
