public class Dog
{
    float weight;

    public Dog(float weight)
    {
        this.weight = weight;
    }

    public string getFoodAmount()
    {
        string foodAmount;
        if (weight < 5.6)
        {
            foodAmount = "0,3 to 1";
        }
        else if (weight < 9.1)
        {
            foodAmount = "1 to 1,3";
        }
        else if (weight < 16)
        {
            foodAmount = "1,3 to 2";
        }
        else if (weight < 22.6)
        {
            foodAmount = "2 to 2,6";
        }
        else if (weight < 34.1)
        {
            foodAmount = "2,6 to 3,3";
        }
        else if (weight <= 45)
        {
            foodAmount = "3,3 to 4,25";
        }
        else
        {
            bool foundCorrectWeight = false;
            int n = 1;

            while (!foundCorrectWeight)
            {
                if (weight < 45 + 4.5 * n)
                {
                    foundCorrectWeight = true;
                }
                else
                {
                    n++;
                }
            }

            float result = 4.25f + 0.25f * (n - 1);
            foodAmount = result.ToString();
        }

        return foodAmount;

    }
}

