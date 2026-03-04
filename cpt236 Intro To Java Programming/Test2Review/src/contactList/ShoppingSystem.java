package contactList;

import java.util.ArrayList;

public class ShoppingSystem {

	public static void main(String[] args) 
	{
		ArrayList<CartItem> cart = new ArrayList<>();
		// product
		
		Product soap = new Product(1, "Soap", 1);
		Product corn = new Product(2, "Corn", 20);
		
		// cartItem
		
		CartItem soapCI = new CartItem(soap, 1);
		CartItem cornCI = new CartItem(corn, 4);
		
		// customer
		
		Customer john = new Customer(1, "John", cart);
		
		cart.add(soapCI);
		cart.add(cornCI);
		
		System.out.println(cart);

	}

}
