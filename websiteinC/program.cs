using System;
class Program{
    static void Main(string[]args){

        var username;
        var password;

        Console.WriteLine("Please enter your username");
        username=Console.ReadLine();
        Console.WriteLine("Please enter your password");
        userpassword=Console.ReadLine();
        login(userame,password);
        


        // if userame and password dont match create account
        if(login==false){
            string uName;
            string fiName;
            string paWord;

            Console.WriteLine("Your username and password dont match...you must register as anew user");
            Console.WriteLine("PLEASE ENTER A USERNAME:");
            uName=Console.ReadLine();
            Console.WriteLine("PLEASE ENTER YOUR FIRSTNAME:");
            fiName=Console.ReadLine();
            Console.WriteLine("PLEASE ENTER A PASSWORD:");
            paWord=Console.ReadLine();

            createNewUser(uName,fiName,paWord);
        


        }


        //if username and password  match and login fuction returns as true  allow access

        else if(login==true){
            string chosenStore;
            int addThistoOrder;


            // Drop locations of different stores
            Console.WriteLine(getStores());

            //take user input for chosen store and call fuctionn or class that will display inventory.
            Console.WriteLine("Please enter the store location you would like to shop from!!");
            chosenStore=Console.readLine();









        // go into the website for that specific location and show items to shop around
            showProducts(chosenStore);
            Console.WriteLine("If you would like to add something to your cart, type in the item ID");
            makeOrder(addThistoOrder);


        }
        }
}