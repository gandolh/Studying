// MoshTutorial.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <cmath>
#include <cstdlib>
#include <ctime>
void swap(int& a, int& b) {
    int t = a;
    a = b;
    b = t;
}

void Exercise1() {
    int a = 1, b = 2;
    swap(a,b);
    std::cout << a;
}

double Exercise2(int x, int y) {
    return ((x + 10) / (3.0 * y));
}

void Exercise3(int sales) {
    
	std::cout << "Sales: $" << sales << std::endl;
	std::cout << "State tax: $" << sales * 4 / 100 << std::endl;
	std::cout << "County tax: $" << sales * 2 / 100 << std::endl;
	std::cout << "Total tax: $" << sales * 6 / 100 << std::endl;


}

void Exercise4() {
    std::cout << "Enter temperature in fahrenheit: ";
    double Fahrenheit;
    std::cin >> Fahrenheit;
    double Celsius = (Fahrenheit - 32) * 5 / 9;
    std::cout << "Temperature in Celsius is " << Celsius << std::endl;
}

void Exercise5() {
    double radius;
    std::cout << "Enter radius of a circle: ";
    std::cin >> radius;
    const double pi = 3.14;
     std::cout << pi * radius * radius;
}

void Exercise6() {
    const int minValue = 1;
    const int maxValue = 6;
    long elapsedSeconds = time(nullptr);
    srand(elapsedSeconds);
    int number = rand() % (maxValue - minValue + 1) + minValue;
    
    std::cout << number;    

}

int main()
{
    int file_size = 100;
    
    //Exercise1();
    //std::cout << Exercise2(10,5);
    //Exercise3(95000);
    //Exercise4();
    //Exercise5();
    Exercise6();
}
