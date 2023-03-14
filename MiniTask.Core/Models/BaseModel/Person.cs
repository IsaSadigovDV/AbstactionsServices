using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTask.Models.BaseModel
{
    public abstract class Person
    {

        private string _name;
        private string _surname;
        private string _groupno;

        private static int _count = 0;

        public readonly int Id;
        public string Name
        {
            get => _name;
            set
            {
                if(value.Length >= 3 && value.Length <= 30)
                {
                    _name = value;
                }
            }
            
        }
        public string Surname
        {
            get => _surname;
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    _surname = value;
                }
            }
        }
        public string GroupNo
        {
            get => _groupno;
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    _groupno = value;
                }
            }
        }





        public override string ToString()
        {
            return ($"Name: {Name}, Surname: {Surname} Group No: {GroupNo} ID: {Id}");
        }


        public Person()
        {
            _count++;
            Id = _count;
        }


    
    }
}
