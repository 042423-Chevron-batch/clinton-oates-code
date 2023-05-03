int numOfGuesses=0; //initiate guesses to zero





    string[] words = { "apple", "banana", "cherry", "orange", "kiwi", "mango","pear","peach" }; //array to choose a guessable word from
    Random rand = new Random(); ///object created 
    int number = rand.Next(0, 8); //returns random number between 0-9 //pick a random number that corresponds to which word from the array will be chosen.
    string chosenWord= words[number]; //assign chosen word variable to random word chosen

    string[] guessedLetters = new string [26]; //initialize array for guessed letters

    Console.WriteLine("What is your First guess?...Hint- type of fruit: ");//get the users first guess

    while(numOfGuesses < 6){
    
    char userGuess = Console.ReadLine()[0];
    bool result = chosenWord.Contains(userGuess);
    
    
    
        if (result==true){
            Console.WriteLine("That letter is in the word!\n what is your next guess?");
            Console.WriteLine(userGuess);
            for (int i = 0; i < chosenWord.Length; i ++)
                {
                    if(chosenWord[i]==userGuess){
                        Console.Write(userGuess);
                    }
                    else{
                        Console.Write("*");
                    }
                }
        }
        else if (result==false){
            Console.WriteLine("That letter is not in the word...You have used one of your guesses.");
            numOfGuesses+=1;
            //guessedLetters[numOfGuesses]=userGuess;
            
        }



    }
    Console.WriteLine("The word was " + chosenWord + " Were you able to guess it?");
    Console.WriteLine("YOU ARE OUT OF GUESSES___HANGMAN__");


 
