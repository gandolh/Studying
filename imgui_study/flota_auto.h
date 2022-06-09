#pragma once
#include <iostream>
#include <fstream>
#include <vector>
#include <string>

using std::string;
using std::ostream;
using std::istream;
using std::vector;
using std::endl;
using std::cout;



class Autoturism
{
private:
	string marca, model, tip, culoare, numar;
public:
	Autoturism();
	Autoturism(string marca, string model, string tip, string culoare, string numar);
	~Autoturism();
};


Autoturism::Autoturism()
{
	this->marca = "";
	this->model = "";
	this->tip = "";
	this->culoare = "";
	this->numar = "";
}

Autoturism::Autoturism(string marca, string model, string tip, string culoare, string numar)
{
	this->marca = marca;
	this->model = model;
	this->tip = tip;
	this->culoare = culoare;
	this->numar = numar;
}

Autoturism::~Autoturism()
{
	//strings delete themselves :D
}



