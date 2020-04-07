using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infbez4
{
    // Класс с вспомогательными функциями
    public static class functions
    {
        // Переводит 16-ричную строку (Хэш) в байты
        public static byte[] StringHEXtoByteArray(string strHEX)
        {
            int N = strHEX.Length;
            byte[] bytes = new byte[N / 2];
            for(int i = 0; i < N; i += 2)
                bytes[i / 2] = Convert.ToByte(strHEX.Substring(i, 2), 16);
            return bytes;
        }

        // Переводит байты в значение 16-ричной строки
        public static string ByteArrayToStringHEX(byte[] byteArr)
        {
            return BitConverter.ToString(byteArr).Replace("-", "").ToUpper();
        }
    }
}
