using UnityEngine;

public class CustomRangeAttribute : PropertyAttribute
{
     public string MinVariable;
    public string MaxVariable;

    public CustomRangeAttribute(string minVariable, string maxVariable)
    {
        MinVariable = minVariable;
        MaxVariable = maxVariable;
    }
}