using System;
using System.Text;

namespace Receipt
{
    class Program
    {
        private const int TotalWidth = 40;
        private const char Pipe = '|';
        private const char Space = ' ';
        
        static void Main(string[] args)
        {
            var lineString = MakeLine(TotalWidth);
            Console.WriteLine(lineString);
            Console.WriteLine(CenteredString("кассовый чек", TotalWidth));
            Console.WriteLine(CenteredString("ООО 'Ромашка'", TotalWidth));

            var dateTime = new DateTime(2020, 03, 19)
                .AddHours(10)
                .AddMinutes(42);
            var dateString = BuildLeadingString(FormattedStringFromDateTime(dateTime), TotalWidth);
            Console.WriteLine(dateString);
            Console.WriteLine(BuildLeadingTrailingString("СНО", "ОСН", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("КАССИР", "Казакова Н.А.", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("РН ККТ", "0015344535006899", TotalWidth));
            Console.WriteLine(BuildLeadingString("614015, ул. Ленина 25", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("МЕСТО РАСЧЕТОВ", "Офис", TotalWidth));
            Console.WriteLine(BuildLeadingString("[M] Сигареты \"L&M\" Lights blue", TotalWidth));
            Console.WriteLine(BuildLeadingString("ТОВАР", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("1 * 150.00 =", "150.00", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("НДС 20%", "25.00", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("ИТОГ", "150.00", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("НАЛИЧНЫМИ", "150.0", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("ПОЛУЧЕНО", "150.0", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("СУММА НДС 20%", "25.0", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("САЙТ ФНС", "nalog.ru", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("ФД", "34", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("ФН", "9999078900009278", TotalWidth));
            Console.WriteLine(BuildLeadingTrailingString("ФП", "2675072330", TotalWidth));
            Console.WriteLine(lineString);
        }

        private static string MakeLine(int lenght)
        {
            return BuildCharacterSequence('-', lenght);
        }

        private static string BuildCharacterSequence(char character, int sequenceLenght)
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < sequenceLenght; i++)
            {
                stringBuilder.Append(character);
            }

            return stringBuilder.ToString();
        }

        private static string CenteredString(string text, int totalWidth)
        {
            if (text.Length >= totalWidth)
            {
                return text;
            }
            
            var availableSpace = totalWidth - text.Length;
            var halfAvailableSpace = availableSpace * 0.5;
            var intHalfAvailableSpace = (int) halfAvailableSpace;

            var leadingSpaces = BuildCharacterSequence(Space, intHalfAvailableSpace);

            var totalStringBuilder = new StringBuilder();
            totalStringBuilder.Append(Pipe);
            totalStringBuilder.Append(leadingSpaces);
            totalStringBuilder.Append(text);

            var trailingAvailableSpace = totalWidth - totalStringBuilder.ToString().Length;
            var trailingSpaces = BuildCharacterSequence(Space, trailingAvailableSpace - 1);

            totalStringBuilder.Append(trailingSpaces);
            totalStringBuilder.Append(Pipe);

            return totalStringBuilder.ToString();
        }

        private static string FormattedStringFromDateTime(DateTime dateTime)
        {
            var format = "dd.mm.yy HH:MM";
            return dateTime.ToString(format);
        }

        private static string BuildLeadingString(string text, int totalWidth)
        {
            // Currently ignoring text boundary check... 
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(Pipe);
            stringBuilder.Append(text);

            var trailineSpace = totalWidth - stringBuilder.ToString().Length - 1;
            var trailingString = BuildCharacterSequence(Space, trailineSpace);

            stringBuilder.Append(trailingString);
            stringBuilder.Append(Pipe);

            return stringBuilder.ToString();
        }
        
        private static string BuildLeadingTrailingString(string leadingText, string trailingText, int totalWidth)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(Pipe);
            stringBuilder.Append(leadingText);

            var availableSpace = totalWidth - stringBuilder.ToString().Length - trailingText.Length - 1;
            if (availableSpace <= 0)
            {
                stringBuilder.Append(trailingText);
                return stringBuilder.ToString();
            }

            var spacesString = BuildCharacterSequence(Space, availableSpace);
            stringBuilder.Append(spacesString);
            stringBuilder.Append(trailingText);
            stringBuilder.Append(Pipe);

            return stringBuilder.ToString();
        }
    }
}