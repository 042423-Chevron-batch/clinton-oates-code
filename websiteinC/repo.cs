using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using RpsApiModels;

namespace websiteinC
{
    public class Repository
    {
        // ADO.NET code to access the Database./////////////////////////////////////////
        private static SqlConnection con { get; set; } = new SqlConnection("Server=tcp:clintdbserver.database.windows.net,1433;Initial Catalog=clintsMachineDB;Persist Security Info=False;User ID=clintsDB;Password={Smokie127k};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


        

        // SELECT CustomerId/password FROM [dbo].[Customer] WHERE 
        public bool Login(string userID, string userP)
        {
            SqlCommand comm = new SqlCommand("SELECT CustomerId, userPassword FROM [dbo].[Customer] WHERE FirstName = @userID AND LastName = @userP;", con);
            comm.Parameters.AddWithValue("@userID", userID);
            comm.Parameters.AddWithValue("@userP", userP);
            con.Open();
            
            //Authenticationn process
            if(userID==fname && userP==lname){
                return true;
                
            }
            else{
                return false;

            }
        }

        public static createNewUser(string userID, string firstName, string userP)
        {
            SqlCommand comm = new SqlCommand("INSERT CustomerId, FirstName, userPassword INTO Customer WHERE CustomerId=@userID AND FirstName=@fname AND userPassword=@userP ", con);
            comm.Parameters.AddWithValue("@userID", userID);
            comm.Parameters.AddWithValue("@fname", firstName);
            comm.Parameters.AddWithValue("@userP", userP);

            con.Open();
            

            
        }


    
        //function to show all of the available stores/////////////////////////////////////////
        public static List<location> getStores()
        {
            SqlCommand comm = new SqlCommand("SELECT * FROM locations;", con);
            con.Open();
            SqlDataReader ret = comm.ExecuteReader();
            //create list of stores and show them all////
            List<location> myList = new List<location>();
            // this while loop will iterate over all the rows in the return. You will need to store all the rows in a List<Person>
            while (ret.Read())
            {
                myList.Add(new location(ret.GetString(1)));
            }
            return myList;
        }





        ///View available products from any given store//////
        
       public static List<products> showProducts(string storePicked){
        SqlCommand comm = new SqlCommand("SELECT * FROM [dbo].[products];", con);
        comm.Parameters.AddWithValue("@storePicked", storePicked);
            con.Open();
            SqlDataReader ret2 = comm.ExecuteReader();
            /// create list of products ad iterate through it//////
            List<products> myList = new List<products>();

            while (ret2.Read())
            {
                myList.Add(new products(ret.GetInt32(0), ret.GetInt32(1), ret.GetString(2), ret.GetString(3)));
            }
            return myList;
       }
       //fill cart with user chosen product based on the ID that 
        public static makeOrder(int addThis){
            SqlCommand comm = new SqlCommand("INSERT  productID, price, itemDescription, itemName INTO order WHERE productID = {@addThis};", con);
            comm.Parameters.AddWithValue("@addThis", addThis);



        }

        //get all the customers (example)
        public static List<Person> findCustomer(string fname, string lname)
        {
            SqlCommand comm = new SqlCommand("SELECT CustomerId, FirstName, LastName, Email FROM [dbo].[Customer];", con);
            con.Open();
            SqlDataReader ret = comm.ExecuteReader();

            List<Person> myList = new List<Person>();
            // this while loop will iterate over all the rows in the return. You will need to store all the rows in a List<Person>
            while (ret.Read())
            {
                if(){

                }
                else(){
                    
                }
            }
            return myList;
        }




    }

}