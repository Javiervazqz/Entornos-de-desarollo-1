namespace ExamenRugby
{
    public class Game
    {
        public List<Character> characters;
        public int RoundCount { get; set; }

        public void SeparateCharacters()
        {

        }
        public void GenerateCharacters()
        {
            characters = new List<Character>();
            foreach (Character character in characters)
            {

            }
        }
        public void GenerateGrid()
        {

        }
        public void PrintCharacters()
        {
            foreach (Character character in characters)
            {
                Console.WriteLine(character.Name + " del equipo: " + character.Team);
            }
        }
    }
}
