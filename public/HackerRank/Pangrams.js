function pangrams(s) {
    let letters = s.replace(/\s/gi, '').toLowerCase().split('');
    let countEachLetter = letters.filter(function (x, pos) { return letters.indexOf(x) === pos; }).length;
    return (countEachLetter === 26) ? 'pangram' : 'not pangram'
}