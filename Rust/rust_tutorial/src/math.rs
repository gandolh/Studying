#![allow(unused)]


use std::io;
use rand::Rng;
use std::io::{Write, BufReader, BufRead, ErrorKind};
use std::fs::File;
use std::cmp::Ordering;
fn main() {
    let num_1:f32 = 1.11111111111111;
    println!("f32: {}", num_1 + 0.11111111111111);
    let num_2:f64 = 1.11111111111111;
    println!("f64: {}", num_2 + 0.11111111111111);

    let mut num_3: u32 =5;
    let num_4: u32 =4;
    println!("5 + 4 = {}", num_3 + num_4);
    println!("5 - 4 = {}", num_3 - num_4);
    println!("5 * 4 = {}", num_3 * num_4);
    println!("5 / 4 = {}", num_3 / num_4);
    println!("5 % 4 = {}", num_3 % num_4);
    num_3 +=1;
    let random_num = rand::thread_rng().gen_range(1..101);
    println!("Random : {}", random_num)
}
