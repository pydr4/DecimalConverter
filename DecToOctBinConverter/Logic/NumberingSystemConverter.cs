namespace DecToOctBinConverter
{
    class NumberingSystemConverter
    {
        public enum NumberBase { OCTAL = 8, BINARY = 2 };

        /*
          Takes long number and base number  octal = 8, Binary = 2
          Converts number to given baseValues
             */
        public static long DecimalToBaseSystem(long number, int baseValue)
        {
            
            if (baseValue > 10)
            {
                //can only convert numbering system with integers
                return number;
            }

            long decimalToReturn = 0;
            int digits = 1;


            while (number >= baseValue)
            {
                long reminder = (long)(number % baseValue);

                decimalToReturn += reminder * digits;

                number = (long)number / baseValue;
                digits *= 10;
            }

            decimalToReturn += number * digits;

            return decimalToReturn;
        }

        



    }
    
}
