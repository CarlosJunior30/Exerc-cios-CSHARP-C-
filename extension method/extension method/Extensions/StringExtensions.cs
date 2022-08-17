
namespace System
{
    static class StringExtensions
    {
        public static string cut(this string thisobj, int count)
        {
            if (thisobj.Length <= count)// se o stringo original tiver o nome menor ou igual, nao precisa recortar
            {
                return thisobj;

            }
            else
            {
                return thisobj.Substring(0, count) + "...";
            }

        }
    }
}
