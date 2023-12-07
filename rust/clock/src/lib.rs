use std::fmt;
use std::ptr::eq;

#[derive(PartialEq,Debug)]
pub struct Clock{
    hours:i32,
    minutes:i32,
}
const  MAX_HOURS: i32 = 24;
const MAX_MINUTES: i32 = 60;
impl Clock {

    pub fn new(hours: i32, minutes: i32) -> Self {
        let hoursToAddFromMinutes=if minutes>=0 {minutes/MAX_MINUTES}else if minutes%MAX_MINUTES!=0{(minutes/MAX_MINUTES)-1}else{minutes/MAX_MINUTES};
        let mut hour=(hours+hoursToAddFromMinutes)%MAX_HOURS;
        if hour<0{
            hour=MAX_HOURS+hour;
        }
        let mut minute=minutes%MAX_MINUTES;
        if minute<0{
            minute=MAX_MINUTES+minute;
        }
        Clock{hours:hour,minutes:minute}
    }

    pub fn add_minutes(&self, minutes: i32) -> Self {
       Clock::new(self.hours,self.minutes+minutes)
    }
}
impl fmt::Display for Clock {
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
        write!(f, "{:0>2}:{:0>2}", self.hours, self.minutes)
    }
}