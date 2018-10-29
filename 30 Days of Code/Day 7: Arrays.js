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
    const n = parseInt(readLine(), 10);

    const arr = readLine().split(' ').map(arrTemp => parseInt(arrTemp, 10));
    // Expected Output: [ 1, 4, 3, 2 ] --> console.log(arr)
    
    // We need to reverse the array
    var reversedArray = arr.reverse();
    // Expected Output: [ 2, 3, 4, 1 ] --> console.log(reversedArray)
    
    // We need to make this a string separated by a space instead of commas
    var answer = reversedArray.join(' ');
    console.log(answer)
    
}