use std::ops::Add;
use std::time::Duration;
use time::PrimitiveDateTime as DateTime;

// Returns a DateTime one billion seconds after start.
pub fn after(start: DateTime) -> DateTime {
    let gigaseconds=1000000000;
    start.add( Duration::from_secs(gigaseconds))
}
