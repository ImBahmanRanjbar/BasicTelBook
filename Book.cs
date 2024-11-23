using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Book
    {
    Contact[] contacts = new Contact[20];
        public void ADD(Contact p)
        {
            for (int index = 0; index < contacts.Length; index++)
            {
                if (contacts[index]==null)
                {
                    contacts[index] = p;
                    break;
                }

            }

        }
        public void RemoveAtNum(string Number)
        {
            for (int index = 0; index < contacts.Length; index++)
            {
                if (contacts[index] != null && contacts[index].Phone == Number)
                {
                    contacts[index] = null;
                   
                }

            }
        }
        public Contact findbyNum(string number)
        {
            for (int index = 0; index < contacts.Length; index++)
            {
                if (contacts[index] != null && contacts[index].Phone == number)
                {
                  return  contacts[index];

                }

            }
            return null;
        }
        public Contact findbyName(string name)
        {
            for (int index = 0; index < contacts.Length; index++)
            {
                if (contacts[index] != null && contacts[index].Name == name)
                {
                    return contacts[index];

                }

            }
            return null;
        }
        public int ToTalConracts
        {
            get
            {
                int count = 0;
                for (int index = 0; index < contacts.Length; index++)
                {
                    if (contacts[index] != null)
                        count++;

                }
                return count;
            }
        }
        public void Update(string number,Contact p)
        {
            var old = findbyNum(number);
               old.Name = p.Name;
                old.Phone = p.Phone;
                old.Email = p.Email;
            old.Address = p.Address;
           

        }

    }
}
