namespace _6._6
{
    static class Accauntant
    {
        public static bool AskForBonus(Post post, int hours)
        {
            return hours > (int)post ? true : false;
        }
    }
}
