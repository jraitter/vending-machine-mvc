 - Create an app where users can vend items from a "vending machine"
 - Users have the options to "add quarter", "purchase", "change"
 - Using the MVC Pattern have a collection of "purchasables" in your store, feel free to use an interface like IPurchasable and several different item classes like "Food", "Electronics", or inheritance like "Frozen:Food", "Healthy:Food", etc.
 - When a user attempts to purchase food, check that they have the proper funds and write the error if they do not
 - If successfully vended, deduct the total from the "transaction" value.
Extended Challenges:
 - Allow the user to deposit more than a "quarter" with TryParse to check the number.
 - Use "Message" class to improve console Design
 - Keep track of the total "Machine Money" so you can see how much money has been made instead of just the transaction.
 - Add Quantities to each of your "Purchasables" to track the available stock of an item