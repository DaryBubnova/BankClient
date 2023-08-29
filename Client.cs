using System;

namespace BankClient
{
    class Client
    {
        private int _age;

        public string Name { get; set; } = "John";
        
        public int Age
        {
            get => _age;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Возраст не может быть отрицательным");

                _age = value;
            }
        }   
    }
}