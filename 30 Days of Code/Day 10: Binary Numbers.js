'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.replace(/\s*$/, '')
        .split('\n')
        .map(str => str.replace(/\s*$/, ''));

    main();
});

function readLine() {
    return inputString[currentLine++];
}



function main() {
    let n = parseInt(readLine(), 10);

    let result = "";
    while (n != 0) {
        let bit = Math.floor(n % 2) != 0 ? "1" : "0";
        result = bit + result;

        n = Math.floor(n / 2);
    }

    while (Math.floor(result.length % 8) != 0)
        result = "0" + result;

    let array = result.split('')
    let count = 0;
    let answer = 0;

    for (let i = 0; i < array.length; i++) {

        if (array[i] == 1) {
            count = count + 1;
        }
        else if (array[i] == 0) {
            if (count > answer)
                answer = count;
                count = 0;
        }
    }

    if (count > answer) {
        answer = count;
    }

    console.log(answer)
}
