pub fn is_armstrong_number(num: u32) -> bool {
    let mut currentNum=num;
    let mut digitVec: Vec<u32> = Vec::new();
    while currentNum>0{
        digitVec.push(currentNum%10);
        currentNum/=10;
    }
    let sum:u64=digitVec.iter().map(|digit|digit.pow(digitVec.len() as u32) as u64).sum();
    return sum== num as u64
}
