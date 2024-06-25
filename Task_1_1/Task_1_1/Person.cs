namespace Task_1_1
{
    internal class Person
    {
        public int PersonId
        {
            get { return personId; }
        }

        public string Adress
        {
            get { return adress; }
        }

        public Person(int personId, string adress, string clientName)
        {
            this.personId = personId;
            this.adress = adress;
        }

        private int personId;
        private string adress;
    }
}
