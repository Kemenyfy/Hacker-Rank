function plusMinus(arr) {

    var pos = 0;
    var neg = 0;
    var zero = 0;
    var length = arr.length;

    for (let i = 0; i < length; i++) {
        let value = arr[i];
        if (value > 0) {
            pos += 1;
        } else if (value < 0) {
            neg += 1;
        } else {
            zero += 1;
        }
    }

    var FractionOfPostive = pos / length;
    var FractionOfNegative = neg / length;
    var FractionOfZero = zero / length;

    console.log(FractionOfPostive.toFixed(6)),
        console.log(FractionOfNegative.toFixed(6)),
        console.log(FractionOfZero.toFixed(6));

}