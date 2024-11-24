/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
 let arr = [0,10,20,30];
var filter = function(arr, fn) {
    let filtered=[];
    for(let i=0;i<arr.length;i++){
        if(fn(arr[i],i)){
            filtered.push(arr[i])
        }
    }
    return filtered;
};