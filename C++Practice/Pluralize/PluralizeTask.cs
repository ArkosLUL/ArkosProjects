namespace Pluralize
{
	public static class PluralizeTask
	{
        public static string PluralizeRubles(int count)
        {
            if (count  == 1 || (count % 100 != 11 && count % 10 == 1))
            {
                return "рубль";
            }
            else
            {
                if (count  == 2 || count  == 3 || count  == 4)
                    return "рубля";
                else
                {
                    if(count>20 && ((count %10 == 2 && count % 100 != 12)|| (count % 10 == 3 && count % 100 != 13) || (count % 10 == 4 && count % 100 != 14)))
                        {
                        return "рубля";
                        }
                    else
                        
                    return "рублей";
                }
            }
            
		}
	}
}