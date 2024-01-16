namespace desafios_leetcode.Services;

public class AppService
{
    public int SearchInsert(int[] nums, int target)
    {
        var indexFromTarget = 0;

        if (nums.Length == 0 || target < 0)
        {
            return indexFromTarget;
        }

        int[] newArray = new int[nums.Length + 1];

        for (int index = 0; index < nums.Length; index++)
        {
            newArray[index] = nums[index];
        }

        newArray[nums.Length] = target;

        Array.Sort(newArray);

        for (int index = 0; index < newArray.Length; index++)
        {
            if (newArray[index] == target)
            {
                indexFromTarget = index;
                break;
            }
        }

        return indexFromTarget;
    }

    public int LengthOfLastWord(string text)
    {
        string[] splitText = text.Split(" ");

        if (splitText.Contains(""))
        {
            splitText = splitText.Where(x => x != "").ToArray();
        }

        var totalCharacters = 0;

        for (int index = splitText.Length - 1; index < splitText.Length; index++)
        {
            char[] getCharactersQuantityFromLastWord = splitText[index].ToCharArray();

            totalCharacters = getCharactersQuantityFromLastWord.Length;
        }

        return totalCharacters;
    }
}
