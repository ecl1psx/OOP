namespace ClassRoom;

public class BadPupil: Pupil
{
    protected override SkillLevel _read()
    {
        var rand = new Random();
        
        if (rand.Next(0, 10) < 8)
        {
            return SkillLevel.Normal;
        }
        
        return SkillLevel.Bad;
    }
    
    protected override SkillLevel _write()
    {
        return SkillLevel.Bad;
    }
    
    protected override SkillLevel _study()
    {
        if (TiredLevel > 10)
        {
            return SkillLevel.Bad;
        }
        
        return SkillLevel.Normal;
    }
    
    protected override SkillLevel _relax()
    {
        var rand = new Random();
        
        if (TiredLevel < 15)
        {
            return SkillLevel.Bad;
        }
        
        return SkillLevel.Normal;
    }
}