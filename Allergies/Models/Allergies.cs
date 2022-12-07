namespace Allergies 
{
  public class AllergyCalc
  {
    private Dictionary<string, int> allergies = new Dictionary<string, int>()
    {
      {"eggs", 1},
      {"peanuts", 2},
      {"shellfish", 4},
      {"strawberries", 8},
      {"tomatoes", 16},
      {"chocolate", 32},
      {"pollen", 64},
      {"cats", 128}
    };
    
    // public List<string> CalcScore(int input)
    // {
      
    // }

    public Dictionary<string, int> FindHigh(int input)
    {
      Dictionary<string, int> highAllergies = new Dictionary<string, int>() {};
      for (int i = 0; i < allergies.Count; i++)
      {
        KeyValuePair<string, int> item = allergies.ElementAt(i);
        if (item.Value < input)
        {
          highAllergies[item.Key] = item.Value;
        }
      }
    }
  }
}