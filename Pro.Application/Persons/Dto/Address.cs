using Abp.Domain.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Persons.Dto
{
	public class Address : ValueObject<Address>
	{
		public Guid CityId { get; private set; } //A reference to a City entity.
		public string Street { get; private set; }
		public int Number { get; private set; }
		public Address(Guid cityId, string street, int number)
		{
			CityId = cityId;
			Street = street;
			Number = number;
		}
	}
}
