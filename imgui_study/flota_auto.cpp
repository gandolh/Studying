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
	string marca, model, tip, culoare, numar;
public:
	Autoturism();
	Autoturism(string marca, string model, string tip, string culoare, string numar);
	~Autoturism();
	friend ostream& operator <<(ostream& os, Autoturism& x);
	string getNumar()
	{
		return this->numar;
	}
	void setMarca(string marca)
	{
		this->marca = marca;
	}
	void setModel(string model)
	{
		this->model = model;
	}
	void setTip(string tip)
	{
		this->tip = tip;
	}
	void setCuloare(string culoare)
	{
		this->culoare = culoare;
	}
};

Autoturism::Autoturism()
{
	this->marca = nullptr;
	this->model = nullptr;
	this->tip = nullptr;
	this->culoare = nullptr;
	this->numar = nullptr;
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

}

ostream& operator <<(ostream& os, Autoturism& x)
{
	os << endl << "Marca: " << x.marca << endl << "Model: " << x.model << endl << "Tip vehicul: " << x.tip << endl << "Culoare: " << x.culoare << endl << "Numar inmatriculare: " << x.numar << endl;
	return os;
}

void optiuni()
{
	cout << endl << "0 - Opreste executia";
	// printf("\n0 - Opreste executia");
	cout << endl << "1 - Vizualizeaza toate autoturismele";
	// printf("\n1 - Vizualizeaza toate autoturismele");
	cout << endl << "2 - Cauta un autoturism";
	// printf("\n2 - Cauta un autoturism");
	cout << endl << "3 - Adauga un autoturism";
	// printf("\n3 - Adauga un autoturism");
	cout << endl << "4 - Actualizeaza un autoturism";
	// printf("\n4 - Actualizeaza un autoturism");
	cout << endl << "5 - Sterge un autoturism";
	// printf("\n5 - Sterge un autoturism");
	cout << endl << "6 - Reaminteste-mi optiunile" << endl;
	// printf("\n6 - Reaminteste-mi optiunile\n");
}

void printAll(vector <Autoturism> v)
{
	for (int i = 0; i < v.size(); i++)
		cout << v[i] << endl;
}

void search(vector <Autoturism> v, string numar)
{
	int ok = 0;
	for (int i = 0; i < v.size(); i++)
		if (v[i].getNumar() == numar)
		{
			ok = 1;
			cout << endl << "Autoturismul cu numarul de inmatriculare " << numar << " a fost gasit cu succes!" << endl;
			cout << v[i];
			break;
		}
	if (ok == 0)
		cout << endl << "Autoturismul cu numarul de inmatriculare " << numar << " nu exista in baza de date!" << endl;
}

void appendWithText(vector <Autoturism>& v, string marca, string model, string tip, string culoare, string numar)
{
	Autoturism t(marca, model, tip, culoare, numar);
	v.push_back(t);
	cout << endl << "Autoturismul a fost adaugat cu succes!" << endl;
}

int searchOnly(vector <Autoturism> v, string numar)
{
	for (int i = 0; i < v.size(); i++)
		if (v[i].getNumar() == numar)
			return i;
	return -1;
}

void update(vector <Autoturism>& v, string marca, string model, string tip, string culoare, string numar)
{
	int poz = searchOnly(v, numar);
	cout << endl << "Datele inainte de actualizare:" << endl << v[poz];

	if (marca.size() > 1)
		v[poz].setMarca(marca);
	if (model.size() > 1)
		v[poz].setModel(model);
	if (tip.size() > 1)
		v[poz].setTip(tip);
	if (culoare.size() > 1)
		v[poz].setCuloare(culoare);
	cout << endl << "Datele dupa actualizare:" << endl << v[poz];
}

void delete_car(vector <Autoturism>& v, string numar)
{
	int poz = searchOnly(v, numar);
	v.erase(v.begin() + poz);
	cout << endl << "Autoturismul a fost sters cu succes!" << endl;
}
//
//int main()
//{
//    vector <Autoturism> v;
//    Autoturism a("Subaru", "Outback", "SUV", "Gri", "TM 72 ACU"), b("Toyota", "Highlander", "SUV", "Albastru", "B 819 ALB");
//    v.push_back(a);
//    v.push_back(b);
//
//
//
//    cout << endl << "Buna ziua! Va rugam sa alegeti una dintre urmatoarele optiuni apasand tasta corespunzatoare si apoi enter:";
//    // printf("\nBuna ziua! Va rugam sa alegeti una dintre urmatoarele optiuni apasand tasta corespunzatoare si apoi enter:");
//    optiuni();
//
//    int decizie, ok;
//    string opt;
//    char temp;
//
//    cout << endl << "Optiunea: ";
//    // printf("\nOptiunea: ");
//    getline(cin, opt);
//    // scanf("%[^\n]", opt);
//    while (opt.size() != 1)
//    {
//        cout << endl << "Optiunea: ";
//        // printf("\nOptiunea: ");
//        // scanf("%c",&temp);
//        getline(cin, opt);
//        // scanf("%[^\n]", opt);
//    }
//
//    decizie = opt[0] - '0';
//
//    string marca, model, tip, culoare, numar, rsp;
//
//    while (decizie)
//    {
//        switch (decizie)
//        {
//        case 1:
//            printAll(v);
//            break;
//        case 2:
//            cout << endl << "Introduceti numarul de inmatriculare al autoturismului cautat: ";
//            // printf("\nIntroduceti numarul de inmatriculare al autoturismului cautat: ");
//            getline(cin, numar);
//            // scanf("%[^\n]", numar);
//            for (int i = 0; i < numar.size(); i++)
//                numar[i] = toupper(numar[i]);
//            search(v, numar);
//            break;
//        case 3:
//            cout << endl << "Va rugam sa introduceti urmatoarele detalii: ";
//            // printf("\nVa rugam sa introduceti urmatoarele detalii: ");
//            cout << endl << "-> Marca autoturismului: ";
//            // printf("\n-> Marca autoturismului: ");
//            getline(cin, marca);
//            // scanf("%[^\n]", marca);
//            marca[0] = toupper(marca[0]);
//            cout << "-> Modelul autoturismului: ";
//            // printf("-> Modelul autoturismului: ");
//            getline(cin, model);
//            // scanf("%[^\n]", model);
//            model[0] = toupper(model[0]);
//            cout << "-> Tipul autoturismului: ";
//            // printf("-> Tipul autoturismului: ");
//            getline(cin, tip);
//            // scanf("%[^\n]", tip);
//            tip[0] = toupper(tip[0]);
//            cout << "-> Culoarea autoturismului: ";
//            // printf("-> Culoarea autoturismului: ");
//            getline(cin, culoare);
//            // scanf("%[^\n]", culoare);
//            culoare[0] = toupper(culoare[0]);
//            cout << "-> Numarul de inmatriculare al autoturismului: ";
//            // printf("-> Numarul de inmatriculare al autoturismului: ");
//            getline(cin, numar);
//            // scanf("%[^\n]", numar);
//            for (int i = 0; i < numar.size(); i++)
//                numar[i] = toupper(numar[i]);
//            appendWithText(v, marca, model, tip, culoare, numar);
//            break;
//        case 4:
//            cout << endl << "Introduceti numarul de inmatriculare al autoturismului care trebuie actualizat: ";
//            // printf("\nIntroduceti numarul de inmatriculare al autoturismului care trebuie actualizat: ");
//            getline(cin, numar);
//            // scanf("%[^\n]", numar);
//            for (int i = 0; i < numar.size(); i++)
//                numar[i] = toupper(numar[i]);
//            ok = 1;
//            while (searchOnly(v, numar) == -1)
//            {
//                cout << endl << "Autoturismul cu numarul de inmatriculare " << numar << " nu exista in baza de date!";
//                // printf("\nAutoturismul cu numarul de inmatriculare %s nu exista in baza de date!", numar);
//                cout << endl << "Doriti sa cautati alt autoturism? (DA/NU)" << endl;
//                // printf("\nDoriti sa cautati alt autoturism? (DA/NU)\n");
//                // scanf("%c",&temp);
//                getline(cin, rsp);
//                // scanf("%[^\n]", &rsp);
//                if (rsp == "da")
//                {
//                    cout << endl << "Va rugam sa introduceti alt numar de inmatriculare: ";
//                    // printf("\nVa rugam sa introduceti alt numar de inmatriculare: ");
//                    getline(cin, numar);
//                    // scanf("%[^\n]", numar);
//                    for (int i = 0; i < numar.size(); i++)
//                        numar[i] = toupper(numar[i]);
//                }
//                else
//                {
//                    ok = 0;
//                    break;
//                }
//            }
//            if (ok)
//            {
//                cout << endl << "Va rugam sa introduceti urmatoarele detalii: (daca nu doriti ca respectivul camp sa fie actualizat, lasati un '-')";
//                //printf("\nVa rugam sa introduceti urmatoarele detalii: (daca nu doriti ca respectivul camp sa fie actualizat, lasati un '-')");
//                cout << endl << "-> Marca autoturismului: ";
//                // printf("\n-> Marca autoturismului: ");
//                getline(cin, marca);
//                // scanf("%[^\n]", marca);
//                marca[0] = toupper(marca[0]);
//                cout << "-> Modelul autoturismului: ";
//                // printf("-> Modelul autoturismului: ");
//                getline(cin, model);
//                // scanf("%[^\n]", model);
//                model[0] = toupper(model[0]);
//                cout << "-> Tipul autoturismului: ";
//                // printf("-> Tipul autoturismului: ");
//                getline(cin, tip);
//                // scanf("%[^\n]", tip);
//                tip[0] = toupper(tip[0]);
//                cout << "-> Culoarea autoturismului: ";
//                // printf("-> Culoarea autoturismului: ");
//                getline(cin, culoare);
//                // scanf("%[^\n]", culoare);
//                culoare[0] = toupper(culoare[0]);
//                update(v, marca, model, tip, culoare, numar);
//            }
//            break;
//        case 5:
//            cout << endl << "Introduceti numarul de inmatriculare al autoturismului care trebuie sters: ";
//            // printf("\nIntroduceti numarul de inmatriculare al autoturismului care trebuie sters: ");
//            getline(cin, numar);
//            // scanf("%[^\n]", numar);
//            for (int i = 0; i < numar.size(); i++)
//                numar[i] = toupper(numar[i]);
//            ok = 1;
//            while (searchOnly(v, numar) == -1)
//            {
//                cout << endl << "Autoturismul cu numarul de inmatriculare " << numar << " nu exista in baza de date!";
//                // printf("\nAutoturismul cu numarul de inmatriculare %s nu exista in baza de date!", numar);
//                cout << endl << "Doriti sa stergeti alt autoturism? (DA/NU)" << endl;
//                // printf("\nDoriti sa cautati alt autoturism? (DA/NU)\n");
//                // scanf("%c",&temp);
//                getline(cin, rsp);
//                // scanf("%[^\n]", &rsp);
//                if (rsp == "da")
//                {
//                    cout << endl << "Va rugam sa introduceti alt numar de inmatriculare: ";
//                    // printf("\nVa rugam sa introduceti alt numar de inmatriculare: ");
//                    getline(cin, numar);
//                    // scanf("%[^\n]", numar);
//                    for (int i = 0; i < numar.size(); i++)
//                        numar[i] = toupper(numar[i]);
//                }
//                else
//                {
//                    ok = 0;
//                    break;
//                }
//            }
//            if (ok)
//                delete_car(v, numar);
//            break;
//        case 6:
//            optiuni();
//            break;
//        }
//
//        cout << endl << "Optiunea: ";
//        // printf("\nOptiunea: ");
//        getline(cin, opt);
//        // scanf("%[^\n]", opt);
//        while (opt.size() != 1)
//        {
//            cout << endl << "Optiunea: ";
//            // printf("\nOptiunea: ");
//            // scanf("%c",&temp);
//            getline(cin, opt);
//            // scanf("%[^\n]", opt);
//        }
//
//        decizie = opt[0] - '0';
//
//    }
//
//    cout << endl << "Oprirea executiei!";
//    // printf("\nOprirea executiei!");
//
//
//    return 0;
//}
