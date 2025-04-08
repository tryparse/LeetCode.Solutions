namespace LeetCode.Solutions.Solutions.Easy.StrStr
{
    public class StrStrSolution
    {
        private const int NOT_FOUND = -1;

        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (needle.Length > haystack.Length)
            {
                return NOT_FOUND;
            }

            for (var i = 0; i < haystack.Length; i++)
            {
                if (haystack.Length - i < needle.Length)
                {
                    return NOT_FOUND;
                }

                if (haystack[i] != needle[0])
                {
                    continue;
                }

                if (needle.Length == 1)
                {
                    return i;
                }

                var equalityCount = 1;

                for (var j = 1; j < needle.Length; j++)
                {
                    var sourceIndex = i + j;

                    if (haystack.Length < sourceIndex
                        || needle[j] != haystack[sourceIndex])
                    {
                        break;
                    }

                    equalityCount++;

                    if (equalityCount == needle.Length)
                    {
                        return i;
                    }
                }
            }

            return NOT_FOUND;
        }
    }
}
