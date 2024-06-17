using System;

namespace Task_1_1
{
	internal class Person : Client
    {
		public Person(int person_id, string adress, string client_name, int account_num) 
			: base(person_id, client_name, account_num)
		{
			this.person_id = person_id;
			this.adress = adress;
		}

		private int person_id;
		private string adress;

        public int PersonId { get { return person_id; } }
		public string Adress { get { return adress; } }
    }
}
