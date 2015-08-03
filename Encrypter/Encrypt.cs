using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter
{
    class Encrypt
    {
        public int passWordMinimum = 4;
        string al = "ç:╪[{,.<>};~´!ùºúõó╫òªìíèéã/àázyx?wv]ut|srqpo#nmlk$jihgf%edcba¨0987&654A32*1§ÚÙÕ(ÒÓ\"\'ÌÍ)ÈÉÃÀÁ- ZYX_WVUTS+RQPON=MLKJIHGFE\\@DCB πσ┌³²";
        private string getInitializingVector(int length)
        {
            string charArray = al;
            string iVector = "";
            Random n = new Random();
            for(int i =0;i<length;i++)
            {
               
                iVector += charArray[n.Next(0, charArray.Length)];
            }
            return shuffleChar(iVector);
        }

        public string encryptUsingKey(string key,string message)
        {
            string initializingVector = getInitializingVector(key.Length);
            key = mixWords(key, initializingVector);
            string encryptedMessage = "";
            int length = message.Length;
            int num = (length % passWordMinimum == 0) ? (length / passWordMinimum) : (int)(Math.Floor(length / (float)passWordMinimum) + 1);
            for (int i = 0; i < num; i++) 
            {
                if (i + 1 == num)
                    encryptedMessage += mixWords(key, message.Substring(i * passWordMinimum, length - (i * passWordMinimum)));
                else
                    encryptedMessage += mixWords(key, message.Substring((i) * passWordMinimum, passWordMinimum));

                key = mixWords(key, initializingVector);
            }


            return encryptedMessage+ initializingVector;
        }

        public string decryptUsingKey(string key, string message)
        {
            string initializingVector = message.Substring(message.Length - key.Length);
            string tm = message.Substring(0, message.Length - key.Length);
            key = mixWords(key, initializingVector);
            int length = tm.Length;
            int num = (length % passWordMinimum == 0) ? (length / passWordMinimum) : (int)(Math.Floor(length / (float)passWordMinimum) + 1);
            
            string decryptedMessage = "";
            for (int i = 0; i < num; i++)
            {
                if (i + 1 == num)
                    decryptedMessage += unMixWords(key, tm.Substring(i * passWordMinimum, length - (i * passWordMinimum)));
                else
                    decryptedMessage += unMixWords(key, tm.Substring((i) * passWordMinimum, passWordMinimum));

                key = mixWords(key, initializingVector);
            }

            return decryptedMessage;
        }

        private string shuffleChar(string str)
        {
            List<char> r = str.ToList();
            string result = "";
            while(!result.Length.Equals(str.Length))
            {
                Random random = new Random();
                int index = random.Next(0, r.Count);
                result += r[index];
                r.RemoveAt(index);
            }
            return result;
        }

        private int absoluteValue(int value)
        {
            if (value < 0) return value * -1;
            else return value;
        }
        private int getResultAfterCicles(int value)
        {
            string allowedChar = al;
            int maxCodifiedValue = allowedChar.Length;
            if(value == maxCodifiedValue)
            {
                return value;
            }
            else if(value > maxCodifiedValue)
            {
                return (value % maxCodifiedValue == 0) ? maxCodifiedValue :value % maxCodifiedValue;
            }
            else if(value < maxCodifiedValue && value > 0)
            {
                return value;
            }
            else
            {
                int r = value;
                do
                {
                    r = maxCodifiedValue + r;
                }
                while (absoluteValue(r) > maxCodifiedValue);
                return absoluteValue(r);
            }
        }
        private int getCharCode(char charSample)
        {
            string charArray = al;
            return charArray.IndexOf(charSample) + 1;
        }

        private char getChar(int charCode)
        {
            string charArray = al;
            return charArray[(charCode - 1)] ;
        }
        private string unMixWords(string key, string encryptTarget)
        {
            string allowedChar = al;
            int maxCodifiedValue = allowedChar.Length;
            //int keyCicles = encryptTarget.Length / key.Length;
            string encryptedMessage = "";
            int index = 0;
            int keyIndex = 0;
            while (!encryptedMessage.Length.Equals(encryptTarget.Length))
            {
                int encryptedCharCode = getCharCode(encryptTarget[index]) - getCharCode(key[keyIndex]);
                encryptedCharCode = getResultAfterCicles(encryptedCharCode);
                encryptedCharCode = (encryptedCharCode == 0) ? maxCodifiedValue : encryptedCharCode;
                encryptedMessage += getChar(encryptedCharCode);
                keyIndex++;
                index++;
                if (((float)keyIndex) / ((float)key.Length) == 1) keyIndex = 0;
            }
            return encryptedMessage;
        }

        private string mixWords(string key,string encryptTarget)
        {
            string allowedChar = al;
                int maxCodifiedValue = allowedChar.Length;
                //int keyCicles = encryptTarget.Length / key.Length;
                string encryptedMessage = "";
                int index = 0;
                int keyIndex = 0;
                while (!encryptedMessage.Length.Equals(encryptTarget.Length))
                {
                    int encryptedCharCode = getCharCode(encryptTarget[index]) + getCharCode(key[keyIndex]);
                    encryptedCharCode = getResultAfterCicles(encryptedCharCode);
                    encryptedMessage += getChar(encryptedCharCode);
                    keyIndex++;
                    index++;
                    if (((float)keyIndex) / ((float)key.Length) == 1) keyIndex = 0;
                }
               /* if(encryptTarget == this.unMixWords(key,encryptedMessage))
                {
                    return encryptedMessage;
                }
                else
                {
                    return mixWords(key, encryptTarget);
                }*/
                return encryptedMessage;


                
        }

    }
}
