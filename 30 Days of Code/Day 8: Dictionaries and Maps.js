function processData(input) {

    // Convert input into array in different lines
    let inputToArray = input.split('\n');

    // Convert to Int first index to know how many phone numbers in our phone book
    let numberOfPhones = parseInt(inputToArray[0]);

    let searchSize = inputToArray.length - numberOfPhones;
    let phoneBook = {};

    // Loop starting on Index 1 until total contacts added to phone book
    for (i = 1; i <= numberOfPhones; i++) {
        let contacts = inputToArray[i].split(' ');
        phoneBook[contacts[0]] = contacts[1];
    }

    // Loop starting on Index 1 searching if name provided matches contacts in phone book3
    for (y = 1; y < searchSize; y++) {
        let contact = inputToArray[y + numberOfPhones];

        if (phoneBook.hasOwnProperty(contact)) {
            console.log(contact + '=' + phoneBook[contact]);
        } else {
            console.log('Not found');
        }
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
