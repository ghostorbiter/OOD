using System;

namespace Lab1
{
    public static class TranslatorManipulator
    {
        public static ITranslator SetTranslatorToBroken(ITranslator translator, string message)
        {
            return new MyTranslators.TranslatorBroken(translator.GetName(), translator.GetTranslationsLeft(), message);
        }
        
        public static ITranslator MakeTranslatorSmart(ITranslator translator)
        {
            return new MyTranslators.TranslatorSmart(translator.GetName(), translator.GetTranslationsLeft());
        }
        
        public static ITranslator EncryptMessages(ITranslator translator, int offset, int maxCallsNumber)
        {
            return new MyTranslators.TranslatorEncrypted(translator.GetName(), translator.GetTranslationsLeft(), offset, maxCallsNumber);
        }
        
        public static ITranslator DecryptMessages(ITranslator translator, int offset)
        {
            return new MyTranslators.TranslatorDecrypted(translator.GetName(), translator.GetTranslationsLeft(), offset);
        }
    }
}