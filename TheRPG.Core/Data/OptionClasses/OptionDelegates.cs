namespace TheRPG.Core.Data.OptionClasses;

public static class OptionDelegates
{
    public static OptionResponse ActivateOptionSelectionA(Adventurer adv)
    {
        var success = false;
        var responseVerbage = "";
        var dice = new Random();
        // Here we test to see if the option choice was successful or not. Then make changes based on status.
        var roll = dice.Next(1, 20);
        if (adv.Intelligence >= roll)
        {
            responseVerbage = "Great it worked!";
            success = true;
            adv.CurrentHealth += 5;
        }
        else
        {
            responseVerbage = "oh man, sorry it failed!";
            adv.CurrentHealth -= 5;
        }

        // return Option response built with values created and passed here.
        return new OptionResponse()
        {
            ResultVerbage = responseVerbage,
            Success = success,
            UpdatedAdventurer = adv
        };
    }
}