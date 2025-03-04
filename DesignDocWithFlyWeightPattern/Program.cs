namespace DesignDocWithFlyWeightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Data in the word: Time to Study
             */
            CharacterFactory characterFactory = new CharacterFactory();
            Characters characters = characterFactory.CreateCharacter('T');
            characters.Display(0, 0);
        }
    }
}
