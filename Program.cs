namespace Tools_Library_Application_Software
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            MemberCollection memberCollection = new MemberCollection();
            Member member1 = new Member("Navid", "Ahmed", "0450077117", "0000");
            memberCollection.add(member1);
            Member member2 = new Member("Chelsea", "Jenkins", "044565437", "7854");
            memberCollection.add(member2);

            Console.WriteLine(member1.ToString());
            Console.WriteLine(member2.ToString());

            ToolCollection toolCollection = new ToolCollection(20);
            Tool tool1 = new Tool("Chainsaw", 5, 5, 0);
            toolCollection.add(tool1);
            Tool tool2 = new Tool("Hammer", 7, 6, 0);
            toolCollection.add(tool2);

            Console.WriteLine(tool1.ToString());
            Console.WriteLine(tool2.ToString());

            member1.addTool(tool1);
            member2.addTool(tool2);
            */

            ToolLibrarySystem toolLibrarySystem = new ToolLibrarySystem();

            Tool tool1 = new Tool("Irwin 125mm orbital sander", 5, 3, 2);
            Tool tool2 = new Tool("Rocket sanding block holder", 2, 1, 1);
            Tool tool3 = new Tool("Powerfit 120 triangular sander", 1, 1, 0);

            toolLibrarySystem.add(tool1, ToolTypes.basicHandTools);
            toolLibrarySystem.add(tool2, ToolTypes.basicHandTools);
            toolLibrarySystem.add(tool3, ToolTypes.basicHandTools);


        }
    }
}
