/*
For this exercise, create an interface. The interface should have at least 
5 properties and at at least one optional property. Create an array and fill it with at
least 3 objects which fit the interface you created. Be as specific as possible when 
declaring variables (Give all variables a type and don't use the "any" keyword)
*/

interface Car {
    make: string,
    model: string,
    year: number,
    engine: string,
    vin: string
}

const automobiles: Car[]=[
    {
        make: 'Audi',
    model: 'a4',
    year: 2014,
    engine: '2.0 i4 turbo',
    vin: 'bfeibcucnscu'
    }

    {
        make: 'BMW',
    model: 'M5 comp',
    year: 2022,
    engine: 's58',
    vin: 'eewuewubuixebuwefr'
    }

    {
        make: 'Dodge',
    model: 'trackhawk',
    year: 2018,
    engine: '5.7l supercharger',
    vin: 'eswthbvghjbjnjn'
    }
]

/* EXAMPLE TWO                

For each of the following variable declarations, add a type and make sure the program still compiles
    Do NOT use the "any" type.
    Create no more than 2 interfaces
    Do not delete any code.



*/




let age :  number = 4;
let fruit : string = 'banana';
let hungry : boolean = true;

let friends : Array<string | number> = ['Eren', 'Armin', 'Mikasa', 'Jean', 'Connie', 'Sasha'];

interface movies{

    title: string,
    year: number,
    directors: string,
    basedOn: string

}

let movie1: movies[]=[ {
    title: 'Jurassic Park',
    year: 1993,
    directors: ['Spielberg'],
    basedOn: 'Jurassic Park by Michael Crichton'
}
]

let movie2:movies[] = [ {
    title: 'Everything Everywhere All At Once',
    year: 2022,
    directors: ['Kwan', 'Scheinart']
}
]

let person = {
    name: 'Rick Grimes',
    favoriteMovie: {
        title: 'The Shawshank Redemption',
        year: 1994,
        directors: ['Darabont']
    }
}

let movies = [movie1, movie2]


/* EXAMPLE THREE 

Add a type to the following variables to eliminate compilation errors
Do NOT use the "any" type
Do NOT remove any code
*/

let year: string = "1999";
year = '1999';

let list: Array<string> = [];
list.push('cat');

let plumber:  = 'Mario';
plumber = {
    name: 'Mario',
    color: 'red',
    power: 'mushroom'
}
