function compareTriplets(a, b) {
    let scoreArray = []
    let aScore = 0
    let bScore = 0

    for (let i = 0; i < 3; i++) {
        if (a[i] > b[i]) {
            aScore += 1
        } else if (a[i] < b[i]) {
            bScore += 1
        }
    }
    scoreArray.push(aScore)
    scoreArray.push(bScore)
    return scoreArray

}