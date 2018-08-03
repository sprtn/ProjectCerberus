namespace ToolLibrary.Dungeons.Abilities
{
    public class Ability
    {
        public string GetTitle()
        {
            return Title;
        }

        public int GetAbilityScore()
        {
            return AbilityScore;
        }

        public void SetAbilityScore(int newAbilityScore)
        {
            AbilityScore = newAbilityScore;
        }

        public int GetAbilityModifier()
        {
            if (AbilityScore >= 10)
                return (AbilityScore - 10) / 2;
            return ((AbilityScore - 11) / 2);
        }

        public string Title { get; }
        public int AbilityScore { get; set; }

        public Ability(string title, int abilityScore)
        {
            Title = title;
            AbilityScore = abilityScore;
        }
    }
}
