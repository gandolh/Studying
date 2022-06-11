#pragma once
#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include <fstream> 
using std::string;
using std::ostream;
using std::istream;
using std::vector;
using std::endl;
using std::cout;

enum AutoturismColumnID
{
	AutoturismColumnID_numar,
	AutoturismColumnID_marca,
	AutoturismColumnID_model,
	AutoturismColumnID_tip,
	AutoturismColumnID_culoare,
};

enum BtnAction {
	None,
	Remove,
	Update
};

class Autoturism
{
private:
	string numar, marca, model, tip, culoare;
	static int last_Id;
	int id;



public:
	static const ImGuiTableSortSpecs* s_current_sort_specs;
	friend int CompareWithSortSpecs(const void* lhs, const void* rhs);
	Autoturism();
	Autoturism(string marca, string model, string tip, string culoare, string numar);
	~Autoturism();
	friend void showTable(vector<Autoturism>& items, BtnAction btn_action);
	friend void showTable(vector<Autoturism>& items, ImGuiTextFilter& Filter);
	friend void AddAutovehicul();
	friend void UpdateTabContent();
	string getNumar() const;
	string getMarca() const;
	string getModel() const;
	string getTip() const;
	string getCuloare() const;
	void setNumar(string) ;
	void setMarca(string) ;
	void setModel(string) ;
	void setTip(string) ;
	void setCuloare(string);
	//friend bool operator<(const Autoturism& l, const Autoturism& r);
	bool operator <(Autoturism& x);
};



int Autoturism::last_Id = 0;
const ImGuiTableSortSpecs* Autoturism::s_current_sort_specs = NULL;
// Compare function to be used by qsort()
 int  CompareWithSortSpecs(const void* lhs, const void* rhs)
{
	 //cout << "compareWithSort"<<endl;
	const Autoturism* a = (const Autoturism*)lhs;
	const Autoturism* b = (const Autoturism*)rhs;
	for (int n = 0; n < Autoturism::s_current_sort_specs->SpecsCount; n++)
	{
		// Here we identify columns using the ColumnUserID value that we ourselves passed to TableSetupColumn()
		// We could also choose to identify columns based on their index (sort_spec->ColumnIndex), which is simpler!
		const ImGuiTableColumnSortSpecs* sort_spec = &Autoturism::s_current_sort_specs->Specs[n];
		int delta = 0;
		switch (sort_spec->ColumnIndex)
		{
		case 0:             delta = (strcmp(a->numar.c_str(), b->numar.c_str()));              break;
		case 1:           delta = (strcmp(a->marca.c_str(), b->marca.c_str()));     break;
		case 2:      delta = (strcmp(a->model.c_str(), b->model.c_str()));   break;
		case 3:    delta = (strcmp(a->tip.c_str(), b->tip.c_str()));    break;
		case 4:   delta = (strcmp(a->culoare.c_str(), b->culoare.c_str()));    break;
		default: IM_ASSERT(0); break;
		}
		if (delta > 0)
			return (sort_spec->SortDirection == ImGuiSortDirection_Ascending) ? +1 : -1;
		if (delta < 0)
			return (sort_spec->SortDirection == ImGuiSortDirection_Ascending) ? -1 : +1;
	}

	// sort() is instable so always return a way to differenciate items.
	// Your own compare function may want to avoid fallback on implicit sort specs e.g. a Name compare if it wasn't already part of the sort specs.
	return (strcmp(a->numar.c_str(), b->numar.c_str()));
}


Autoturism::Autoturism()
{
	this->id = ++last_Id;	
	this->marca = "";
	this->model = "";
	this->tip = "";
	this->culoare = "";
	this->numar = "";
}

Autoturism::Autoturism(string marca, string model, string tip, string culoare, string numar)
{
	this->id = ++last_Id;
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


string Autoturism::getNumar() const {
	return this->numar;
}

string Autoturism::getMarca() const {
	return this->marca;
}

string Autoturism::getCuloare() const {
	return this->culoare;
}

string Autoturism::getModel() const {
	return this->model;
}

string Autoturism::getTip() const {
	return this->tip;
}

void Autoturism::setNumar(string a) {
	this->numar = a;
}
void Autoturism::setMarca(string a) {
	this->marca = a;
}
void Autoturism::setModel(string a) {
	this->model = a;
}
void Autoturism::setTip(string a) {
	this->tip = a;
}
void Autoturism::setCuloare(string a) {
	this->culoare = a;
}

//bool operator<(const Autoturism& l, const Autoturism& r)
//{
//	return CompareWithSortSpecs(&l, &r) <= 0 ? true : false;
//}

bool Autoturism::operator <(Autoturism& x)
{
	return CompareWithSortSpecs(this, &x) <= 0 ? true : false;
}

class FlotaAuto {
private:
	vector<Autoturism> static items;
	static string PathToDB;
public:
	void static readFromDB();
	void static SaveIntoDB();
	vector<Autoturism> static& getVector();
	void static Add(string marca, string model, string tip, string culoare, string numar);
	void static Remove(int);
	void static Update(int index,string marca, string model, string tip, string culoare, string numar);
};
string FlotaAuto::PathToDB = "db/autovehicule.csv";
vector<Autoturism> FlotaAuto::items = vector<Autoturism>();
void FlotaAuto::readFromDB() {
	items = vector<Autoturism>();
	std::ifstream auto_csv(PathToDB);
	//skip header
	string myText;
	getline(auto_csv, myText);
	string marca, model, tip, culoare, numar;
	while (getline(auto_csv, marca, ';')) {
		if (marca == "\n")
			continue;
		getline(auto_csv, model, ';');
		getline(auto_csv, tip, ';');
		getline(auto_csv, culoare, ';');
		getline(auto_csv, numar, ';');
		if (marca[0] == '\n')
			marca = marca.substr(1);
		items.push_back(Autoturism(marca, model, tip, culoare, numar));
	}
	auto_csv.close();
}

void FlotaAuto::SaveIntoDB() {
	std::ofstream auto_csv(PathToDB);
	auto_csv << "Marca;Model;Tip;Culoare;Numar;\n";
	for (Autoturism& item : items)
		auto_csv << item.getMarca()<<";"
		<< item.getModel() << ";"
		<< item.getTip() << ";"
		<< item.getCuloare() << ";"
		<< item.getNumar() << ";\n";
	auto_csv.close();
}


vector<Autoturism>& FlotaAuto::getVector() {
	if (items.size() == 0)
		readFromDB();
	return items;
}

void FlotaAuto::Add(string marca, string model, string tip, string culoare, string numar) {
	items.push_back(Autoturism( marca,  model,  tip,  culoare, numar));
	FlotaAuto::SaveIntoDB();
}

void FlotaAuto::Remove(int index) {
	items.erase(items.begin()+ index);
	SaveIntoDB();
}

void FlotaAuto::Update(int index, string marca, string model, string tip, string culoare, string numar) {
	items[index].setMarca(marca);
	items[index].setModel(model);
	items[index].setTip(tip);
	items[index].setCuloare(culoare);
	items[index].setNumar(numar);
	SaveIntoDB();
}