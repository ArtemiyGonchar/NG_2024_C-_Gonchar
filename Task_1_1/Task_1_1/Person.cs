namespace Task_1_1
{
    internal class Person
    {
        public int PersonId { get; set; }
        public string Adress { get; set; }

        public Person(int personId, string adress, string clientName)
        {
            this.PersonId = personId;
            this.Adress = adress;
        }
    }
}
