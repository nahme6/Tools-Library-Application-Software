using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Tools_Library_Application_Software;

public class Tool: iTool, IComparable<Tool>
{
    private string name;
    private int quantity;
    private int availableQuantity;
    private int noBorrowings;
    private MemberCollection members = new MemberCollection();

    public Tool(string name, int quantity, int availableQuantity, int noBorrowings)
	{
        this.name = name;
        this.quantity = quantity;
        this.availableQuantity = availableQuantity;
        this.noBorrowings = noBorrowings;
    }

    public string Name { get => name; set => name = value;}
    public int Quantity { get => quantity; set => quantity = value; }
    public int AvailableQuantity { get => availableQuantity; set => availableQuantity = value; }
    public int NoBorrowings { get => noBorrowings; set => noBorrowings = value; }

    public MemberCollection GetBorrowers => members;

    public void addBorrower(Member aMember)
    {
        members.add(aMember);
    }

    public int CompareTo(Tool tool)
    {
        if (name.CompareTo(tool.name) < 0) {
            return -1;
        } else if (name.CompareTo(tool.name) == 0) {
            return 0;
        }
        return 1;
    }

    public void deleteBorrower(Member aMember)
    {
        members.delete(aMember);
    }

    public override string ToString()
    {
        return "Tool Name: " + name + "\n" +
            "Quantity: " + quantity + "\n";
    }
}
