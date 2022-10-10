using System;
using System.Collections.Generic;

namespace Lab1
{
    class MyTranslators
    {
        public static class EXTENSION
        {
            private static char Cipher(char ch, int key)
            {
                if (!char.IsLetter(ch))
                    return ch;

                char offset = char.IsUpper(ch) ? 'A' : 'a';
                return (char)((((ch + key) - offset) % 26) + offset);
            }

            public static string Encipher(string input, int key)
            {
                string output = string.Empty;

                foreach (char ch in input)
                    output += Cipher(ch, key);

                return output;
            }

            public static string Decipher(string input, int key)
            {
                return Encipher(input, 26 - key);
            }
        }

        public class TranslatorBroken : ITranslator
        {
            private readonly string _name;
            private readonly int _translationNumber;
            private readonly string _msg;

            public string GetName()
            {
                return _name;
            }

            public int GetMaxLength()
            {
                return 0;
            }

            public TranslatorType GetTranslatorType()
            {
                return TranslatorType.Broken;
            }

            public string TranslateMessage(string message)
            {
                return message;
            }

            private int _i;

            public TranslatorBroken(string name, int translationNumber, string msg)
            {
                _name = name + " translator broken";
                _translationNumber = translationNumber;
                _msg = msg;
            }

            public int GetTranslationsLeft()
            {
                return 0;
            }
        }

        public class TranslatorSmart : ITranslator
        {
            private readonly string _name;
            private readonly int _translationNumber;
            public string SafeSubstring(string text, int start, int length)
            {
                return text.Length <= start ? ""
                    : text.Length - start <= length ? text.Substring(start)
                    : text.Substring(start, length);
            }
            public string GetName()
            {
                return _name;
            }

            public int GetMaxLength()
            {
                return 30;
            }

            public TranslatorType GetTranslatorType()
            {
                return TranslatorType.Smart;
            }

            public string TranslateMessage(string message)
            {
                if (message.Length > GetMaxLength())
                {
                    string str = "";
                    for (int j = 0; j < message.Length / GetMaxLength() + 1; j++)
                    {
                        if (_i++ < _translationNumber)
                        {
                            str = str + SafeSubstring(message.Substring(j * GetMaxLength(), GetMaxLength()), j * GetMaxLength(), GetMaxLength());
                        }
                        return str;
                    }
                }
                else
                {
                    if (_i++ < _translationNumber)
                    {
                        if (message.Length > GetMaxLength())
                            return message.Substring(0, GetMaxLength());
                        return message;
                    }
                }

                return "";
            }

            private int _i;

            public TranslatorSmart(string name, int translationNumber)
            {
                _name = name + " translator smart";
                _translationNumber = translationNumber;
            }

            public int GetTranslationsLeft()
            {
                return _translationNumber - _i;
            }
        }

        public class TranslatorEncrypted : ITranslator
        {
            private readonly string _name;
            private readonly int _translationNumber;
            private readonly int _numOfCalls;
            private readonly int _offset;

            public string GetName()
            {
                return _name;
            }

            public int GetMaxLength()
            {
                return 30;
            }

            public TranslatorType GetTranslatorType()
            {
                return TranslatorType.Encryption;
            }

            public string TranslateMessage(string message)
            {
                ++_i;
                if (_i > _numOfCalls)
                    return "Translator auto-destroyed";
                return EXTENSION.Encipher(message, _offset);

            }

            private int _i;

            public TranslatorEncrypted(string name, int translationNumber, int offset, int calls)
            {
                _name = name + " translator encrypted";
                _translationNumber = translationNumber;
                _offset = offset;
                _numOfCalls = calls;
            }

            public int GetTranslationsLeft()
            {
                if (_i < _numOfCalls)
                    return _translationNumber - (_numOfCalls - _i);
                return 0;
            }
        }

        public class TranslatorDecrypted : ITranslator
        {
            private readonly string _name;
            private readonly int _translationNumber;
            private readonly int _offset;

            public string GetName()
            {
                return _name;
            }

            public int GetMaxLength()
            {
                return 30;
            }

            public TranslatorType GetTranslatorType()
            {
                return TranslatorType.Decryption;
            }

            public string TranslateMessage(string message)
            {
                ++_i;
                return EXTENSION.Decipher(message, _offset);
            }

            private int _i;

            public TranslatorDecrypted(string name, int translationNumber, int offset)
            {
                _name = name + " translator decrypted";
                _translationNumber = translationNumber;
                _offset = offset;
            }

            public int GetTranslationsLeft()
            {
                return _translationNumber - _i;
            }
        }
    }
}
