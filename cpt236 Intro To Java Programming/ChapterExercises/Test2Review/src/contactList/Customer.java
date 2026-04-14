package contactList;

import java.util.ArrayList;

public class Customer 
{
    private int customerID;
    private String name;
    private ArrayList<CartItem> cart = new ArrayList<>();

    public Customer(int customerID, String name, ArrayList<CartItem> cart)
    {
        this.customerID = customerID;
        this.name = name;
        this.cart = cart;
    }
}