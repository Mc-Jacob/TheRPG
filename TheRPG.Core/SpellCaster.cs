namespace TheRPG.Core;

public class SpellCaster:Adventurer
{
    
    protected override int CalcMaxHealth()
    {
        //Demo Purposes needs to be updated
        return Level * 4;
    }

    protected override int CalcMaxMp()
    {
        //Demo Purposes needs to be updated
        return Level * 12;
    }
}