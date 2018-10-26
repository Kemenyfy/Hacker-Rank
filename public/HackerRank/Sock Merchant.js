function sockMerchant(n, ar) {
    
    var pairs = 0;
    
    // Loop through the array of socks
    for (var i = 0; i < n; i++) {
        // Find the index of the pair for current sock
        var pairId = ar.indexOf(ar[i], i + 1);
        // If the pair exists:
        if (pairId > -1) {
            // Remove both from the array
            ar.splice(i, 1);
            ar.splice(pairId - 1, 1);
            // Add 1 to pair and reset the loop
            pairs++,
            i = -1;
        } 
    }
    
    // Output
    return pairs;

}