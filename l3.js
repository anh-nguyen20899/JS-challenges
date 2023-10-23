// Nhap vao so a. Kiem tra chia het cho 2
let a = prompt("Your number ");
function divideBy2 (a) {
    return a / 2 == 0;
}
function output() {
    let result = divideBy2(a);
    switch(result) {
        case true: {
            console.log("Chia het cho 2");
            break;
        }
        case false: {
            console.log("Khong chia het cho 2");
            break;
        }
        default: {
            console.log("Day la so 0");
            break;
        }

    }
}