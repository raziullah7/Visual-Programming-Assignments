// See https://aka.ms/new-console-template for more information

using Delegates_and_Events_Example_Part_2;

// making objects for use
Guild guild = new Guild();
MemberWelcome welcomer = new MemberWelcome();
GuildHall hall = new GuildHall();

// assigning event subscriptions
guild.NewMemberAdded += welcomer.WelcomeMember;
guild.NewMemberAdded += hall.AddBedroom;

// adding member
guild.AddMember("Tarodev");