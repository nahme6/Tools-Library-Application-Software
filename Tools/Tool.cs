using Assignment;
using System;

public class Tool: iTool
{
    private string name;
    private int quantity;
    private int availableQuantity;
    private int noBorrowings;

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

    public iMemberCollection GetBorrowers => throw new NotImplementedException();

    public void addBorrower(iMember aMember)
    {
        throw new NotImplementedException();
    }

    public void deleteBorrower(iMember aMember)
    {
        throw new NotImplementedException();
    }
}
