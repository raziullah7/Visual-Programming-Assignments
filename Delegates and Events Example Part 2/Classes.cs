namespace Delegates_and_Events_Example_Part_2;
// want all these classes to be ignorant to each other
// but we also want separate classes to execute their
// methods when a new member is added


public class Guild
{   // a list of members
    private readonly List<string> _members = new List<string>();

    // making an event delegate
    public event Action<string> NewMemberAdded;

    // method to add a new member and invoke the event
    public void AddMember(string memberName)
    {
        _members.Add(memberName);
        // invoking use null propagation
        NewMemberAdded?.Invoke(memberName);
    }
}


public class MemberWelcome
{
    public void WelcomeMember(string memberName)
    {
        Console.WriteLine($"Welcome {memberName}");
    }
}


public class GuildHall
{
    public void AddBedroom(string memberName)
    {
        Console.WriteLine($"A room has been added to the guildhall for {memberName}");
    }
}