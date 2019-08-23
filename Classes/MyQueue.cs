using System;


namespace Qiwi.Classes
{
    public class MyQueue
    {
        private Person person;

        public MyQueue()
        {
            person = new Person();

        }

        public void enqueue(string[] item)
        {

            person.PhoneNumber = new string[item.Length];
            person.Id = new int[item.Length];



            for (int i = 0; i < item.Length; i++)
            {
                person.Id[i] = i + 1;
                person.PhoneNumber[i] = item[i];
            }

        }

        public string dequeue()
        {

            string[] first = new string[1];
            first[0] = person.PhoneNumber[0];
            Array.Clear(person.PhoneNumber, 0, person.PhoneNumber.Length);
            Array.Clear(person.Id, 0, person.Id.Length);
            return first[0];
        }

        public bool isEmpty()
        {

            if (Size() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int Size()
        {
            return person.PhoneNumber.Length;
        }

        public void sortByID()
        {
            Array.Sort(person.Id);
        }

        public void sortByPhoneNumber()
        {
            Array.Sort(person.PhoneNumber);
        }

        public void getResult(int args)
        {
            for (int i = 0; i < args; i++)
            {
                
                    Console.WriteLine("В очереди номер:{0}", person.PhoneNumber[i]);
                    Console.WriteLine("Id  очереди:{0}", person.Id[i]);
                
            }
        }

        
    }
}
