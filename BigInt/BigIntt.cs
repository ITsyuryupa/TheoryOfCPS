using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigUInt
{
    internal class BigUIntntenger
    {
        //массив хранящий число
        uint[] Data { get; set; }

        //конструкторы
        public BigUIntntenger()
        {
            Data = new uint[1000];
        }

        public BigUIntntenger(int Lenght)
        {
            Data = new uint[Lenght + 1];
        }
        //деструктор
        ~BigUIntntenger()
        {
            this.Dispos();
        }
        // метод высвобождающий память
        public void Dispos()
        {
            this.Data = null;
        }
        //перегрузка оператора *
        public static BigUIntntenger operator *(BigUIntntenger big, uint Innt)
        {
            BigUIntntenger result = new BigUIntntenger(big.Data.Length + 1);
            for(uint i = 0; i < big.Data.Length; i++)
            {
                if (big.Data[i]*Innt > 10 && i != big.Data.Length)
                {
                    if(i == big.Data.Length - 1)
                    {
                        try
                        {
                            big.Data[i] = checked(big.Data[i] * Innt);
                        }
                        catch (Exception)
                        {
                            Array.Copy(big.Data, big.Data, big.Data.Length + 5);
                            
                        }
                    }
                    big.Data[i + 1] += big.Data[i] * Innt / 10;
                }
            }
            return result;
        }
    }
}
