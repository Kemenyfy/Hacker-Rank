function processData(input) {
    // We need to separate the given input
    var separatedInput = input.split("\n");
    // Expected Output: [ '2', 'Hacker', 'Rank' ] --> console.log(separatedInput)
    
    // We need to record the amount of Strings given
    var T = parseInt(separatedInput[0]);
    // Expected Output: 2 --> console.log(T)
    
    // We are going to loop through our array of strings
    for (var x = 0; x < T; x++) {
        
        // Create a variable to find the different strings given
        var givenStrings = separatedInput[x + 1];
        // Expected Output: Hacker Rank --> console.log(givenStrings)
        
        // Create a variable to find the length of the different strings given
        var wordLength = givenStrings.length;
        // Expected Output: 6 4 --> console.log(wordLength)
        
        // Separate given strings to an array of letters
        var letters = givenStrings.split('');
        //Expected Output: [ 'H', 'a', 'c', 'k', 'e', 'r' ] --> console.log(letters)
        
        // Initialize to variables for each side of array
        var leftPortion = "";
        var rightPortion = "";
        
        // Loop throughout letters adding them to right or left portion according to odd/even
        for (var y = 0; y < wordLength; y++) {
            
            if (y%2 == 0) {
                leftPortion = leftPortion + letters[y];
            } else {
                rightPortion = rightPortion + letters[y];
            }
        }
        // Print left portion and right portion separated by a space
        console.log(leftPortion + " " + rightPortion);
        
    }
    
    
} 

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input);
});
