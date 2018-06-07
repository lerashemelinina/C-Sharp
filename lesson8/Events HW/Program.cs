using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[7];
            Signature[] signatureArray = new Signature[7];

            peopleArray[0] = new Person()
            {
                FullName = "Bob Arnold",
                WantToSing = true
            };
            peopleArray[0].SignatureHandler += (string s) =>
            {
                return s.ToLower();
            };


            peopleArray[1] = new Person()
            {
                FullName = "Alice Avery",
                WantToSing = true
            };
            peopleArray[1].SignatureHandler += (string s) => { return s.Replace(" ", ""); };


            peopleArray[2] = new Person()
            {
                FullName = "Albert Bailey",
                WantToSing = true
            };
            peopleArray[2].SignatureHandler += (string s) =>
            {
                string str = "";
                s.Split(' ').ToList().ForEach(i => { str += i[0]; });
                return str;
            };



            peopleArray[3] = new Person()
            {
                FullName = "Matt Baker",
                WantToSing = false
            };
            peopleArray[3].SignatureHandler += (string s) =>
            {
                string str;
                List<string> temp = new List<string>();
                temp = s.Split(' ').ToList();
                str = temp[0];
                str = str[0] + temp[1];

                return str;
            };



            peopleArray[4] = new Person()
            {
                FullName = "Carol Campbell",
                WantToSing = true
            };
            peopleArray[4].SignatureHandler += (string s) => { return s.ToUpper(); };



            peopleArray[5] = new Person()
            {
                FullName = "Kewin Brown",
                WantToSing = false
            };
            peopleArray[5].SignatureHandler += (string s) => { return s.Replace(" ", "."); };



            peopleArray[6] = new Person()
            {
                FullName = "Lisa Bower",
                WantToSing = true
            };
            peopleArray[6].SignatureHandler += (string s) =>
            {
                List<string> temp = new List<string>();
                temp = s.Split(' ').ToList();
                return temp[0].ToLower();
            };



            for (int i = 0; i < signatureArray.Length; i++)
            {
                signatureArray[i] = new Signature(peopleArray[i].FullName, peopleArray[i].SingAction());
            }

            foreach (Signature item in signatureArray)
            {
                Console.WriteLine(item.FullName);
                Console.WriteLine(item.FullSignature);
            }

            Console.ReadKey();

        }
    }
}
